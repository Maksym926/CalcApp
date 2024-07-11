using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcEngine;

using System.Windows.Forms;

namespace CalcForm
{
    
    static class Program 
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WinForm winForm = new WinForm();
            Presenter presenter = new Presenter(winForm);
            Application.Run(winForm);
           
            





        }
    }
}
