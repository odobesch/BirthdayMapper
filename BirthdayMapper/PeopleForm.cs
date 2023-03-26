using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BirthdayMapper
{
    public partial class PeopleForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        WaitFormFunc waitForm = new WaitFormFunc();

        public PeopleForm()
        {
            waitForm.Show();
            InitializeComponent();
            LoadPeopleList();
            Thread.Sleep(5000);
            waitForm.Close();
        }

        private void LoadPeopleList()
        {
            people = SqlDataAccess.LoadPeople();
            dataGridPeople.DataSource = people;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string actionResult = AddPerson();
            ActivateMainUIForm();
            LoadPeopleList();

            if (actionResult == "OK")
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("New person has been added to database successfully");
                }
                ClearForm();
            }
            else
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show(actionResult);
                }
            }
        }

        private string AddPerson()
        {
            waitForm.Show();
            PersonModel person = new PersonModel();
            person.FirstName = tbFirstName.Text.Trim();
            person.LastName = tbLastName.Text.Trim();
            person.DOB = Convert.ToDateTime(tbDOB.Text.Trim());

            try
            {
                bool userExists = SqlDataAccess.CheckUserExists(person);
                if (!userExists)
                {
                    SqlDataAccess.SavePerson(person);
                    return "OK";
                }
                else
                {
                    return "User with this name already exists!";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
            finally
            {
                waitForm.Close();
            }
        }

        private string GetPersonAge(string date)
        {
            try
            {
                TimeSpan ts = DateTime.Now - Convert.ToDateTime(date);
                int age = Convert.ToInt32(ts.Days) / 365;
                return age.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }

        private void ClearForm()
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbDOB.Text = string.Empty;
            tbAge.Text = string.Empty;
            tbId.Text = string.Empty;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            tbDOB.Text = dtpBirth.Value.ToShortDateString();
        }

        private void tbDOB_TextChanged(object sender, EventArgs e)
        {
            tbAge.Text = GetPersonAge(dtpBirth.Value.ToString("d"));
            CheckAllFieldsFullfilled();
        }

        private void tbDOB_Leave(object sender, EventArgs e)
        {
            tbAge.Text = GetPersonAge(tbDOB.Text.Trim());
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            CheckAllFieldsFullfilled();
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            CheckAllFieldsFullfilled();
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {
            CheckAllFieldsFullfilled();
        }

        private void CheckAllFieldsFullfilled()
        {
            btnAdd.Enabled = tbFirstName.Text != string.Empty && tbLastName.Text != string.Empty && tbDOB.Text != string.Empty && tbAge.Text != string.Empty;
            btnDelete.Enabled = btnEdit.Enabled =
                tbFirstName.Text != string.Empty && tbLastName.Text != string.Empty
                && tbDOB.Text != string.Empty && tbAge.Text != string.Empty
                && tbId.Text != string.Empty;
        }

        //private void dataGridPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    tbId.Text = dataGridPeople.Rows[e.RowIndex].Cells[0].Value.ToString();
        //    tbFirstName.Text = dataGridPeople.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    tbLastName.Text = dataGridPeople.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    tbDOB.Text = dataGridPeople.Rows[e.RowIndex].Cells[3].Value.ToString().Replace(" 0:00:00", "");
        //    tbAge.Text = dataGridPeople.Rows[e.RowIndex].Cells[4].Value.ToString();
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string actionResult = DeletePerson();
            ActivateMainUIForm();
            LoadPeopleList();

            if (actionResult == "OK")
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show($"Person {tbFirstName.Text} {tbLastName.Text} has been deleted from database!");
                }
                ClearForm();
            }
            else
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show(actionResult);
                }
            }           
        }

        private string DeletePerson()
        {
            waitForm.Show();

            try
            {
                SqlDataAccess.DeleteUser(tbId.Text);
                return "OK";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
            finally
            {
                waitForm.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string actionResult = EditPerson();
            ActivateMainUIForm();
            LoadPeopleList();

            if (actionResult == "OK")
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show($"Person {tbFirstName.Text} {tbLastName.Text} has been updated successfully");
                }
                ClearForm();
            }
            else
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show(actionResult);
                }
            }
        }

        private string EditPerson()
        {
            waitForm.Show(this);
            string result = string.Empty;
            PersonModel person = new PersonModel();
            person.FirstName = tbFirstName.Text.Trim();
            person.LastName = tbLastName.Text.Trim();
            person.DOB = Convert.ToDateTime(tbDOB.Text.Trim());

            try
            {
                SqlDataAccess.UpdateUserData(person, tbId.Text.Trim());
                return "OK";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
            finally
            {
                waitForm.Close();
            }
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisableNonLetterChars(e);
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisableNonLetterChars(e);
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            ActivateMainUIForm();
        }

        private void ActivateMainUIForm()
        {
            this.Show();
            this.Activate();
        }

        private void dataGridPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbId.Text = dataGridPeople.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbFirstName.Text = dataGridPeople.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbLastName.Text = dataGridPeople.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbDOB.Text = dataGridPeople.Rows[e.RowIndex].Cells[3].Value.ToString().Replace(" 0:00:00", "");
                tbAge.Text = dataGridPeople.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void tbFilterName_TextChanged(object sender, EventArgs e)
        {
            tbFilterLastName.Text = string.Empty;

            List<PersonModel> result;
            if(tbFilterName.Text != string.Empty)
            {
               result = people.Where(x => x.FirstName.Contains(tbFilterName.Text)).ToList();
            }
            else
            {
                result = people;
            }
             dataGridPeople.DataSource = result;
        }

        private void tbFilterLastName_TextChanged(object sender, EventArgs e)
        {
            tbFilterName.Text = string.Empty;

            List<PersonModel> result;
            if (tbFilterLastName.Text != string.Empty)
            {
                result = people.Where(x => x.LastName.Contains(tbFilterLastName.Text)).ToList();
            }
            else
            {
                result = people;
            }
            dataGridPeople.DataSource = result;
        }

        private void tbFilterName_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisableNonLetterChars(e);
        }

        private void tbFilterLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisableNonLetterChars(e);
        }

        private void DisableNonLetterChars(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBirthThisMonth_Click(object sender, EventArgs e)
        {
            List<PersonModel> result;
            result = people.Where(x => x.DOB.Month == DateTime.Now.Month).ToList();
            dataGridPeople.DataSource = result;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridPeople.DataSource = people;
        }
    }
}
