using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BirthdayMapper
{
    public class SqlDataAccess
    {
        private static string LoadConnectionString(string id = "BirthdayMapperDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection conn = new SqlConnection(LoadConnectionString()))
            {
                var output = conn.Query<PersonModel>("SELECT * FROM People", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePerson(PersonModel person)
        {
            using(IDbConnection conn = new SqlConnection(LoadConnectionString()))
            {
                conn.Execute("INSERT INTO People (FirstName,LastName,DOB) VALUES (@FirstName,@LastName,@DOB)", person);
            }
        }

        public static bool CheckUserExists(PersonModel person)
        {
            using (IDbConnection conn = new SqlConnection(LoadConnectionString()))
            {
                return conn.ExecuteScalar<bool>("SELECT COUNT(1) FROM PEOPLE WHERE FirstName=@FirstName AND LastName=@LastName", person);
            }
        }

        public static void DeleteUser(string id)
        {
            using (IDbConnection conn = new SqlConnection(LoadConnectionString()))
            {
                conn.Execute($"DELETE FROM People WHERE Id={id}");
            }
        }

        public static void UpdateUserData(PersonModel person, string id)
        {
            using (IDbConnection conn = new SqlConnection(LoadConnectionString()))
            {
                conn.Execute($"UPDATE People SET FirstName=@FirstName, LastName=@LastName, DOB=@DOB WHERE Id={id}", person);
            }
        }
    }
}