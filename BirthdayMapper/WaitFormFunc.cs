using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayMapper
{
    public class WaitFormFunc
    {
        WaitForm wait;
        Thread loadThread;

        public void Show()
        {
            loadThread = new Thread(new ThreadStart(LoadingProcess));
            loadThread.Start();
        }

        public void Show(Form parent)
        {
            loadThread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadThread.Start(parent);
        }

        public void Close()
        {
            if(wait != null)
            {
                wait.BeginInvoke(new ThreadStart(wait.CloseWaitForm));
                wait = null;
                loadThread = null;
            }
        }

        public void LoadingProcess()
        {
            wait = new WaitForm();
            wait.ShowDialog();
        }

        public void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            wait = new WaitForm(parent1);
            wait.ShowDialog();
        }
    }
}
