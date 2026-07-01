using System;
using System.Threading;
using System.Windows.Forms;

namespace ServerStartUp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool result;
            var mutex = new System.Threading.Mutex(true, "BoR_ServerStartUp_Identifier", out result);
            if (!result)
            {
                MessageBox.Show("Another ServerStartUp is already running.");
                return;
            }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new bor_FMain());
                GC.KeepAlive(mutex); // mutex shouldn't be released - important line
        }
    }
}
