using System;
using System.Windows.Forms;

namespace Ex05.BoolPgia.UI
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BoardForm());
        }
    }
}
