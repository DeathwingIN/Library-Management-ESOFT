using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIB_Original
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //   Application.Run(new MemberMangement());
            //  Application.Run(new Account());
            // Application.Run(new Catlog());
            // Application.Run(new Login());
             Application.Run(new UserSelection());
            //Application.Run(new AdminLogin());
            // Application.Run(new UserUI());
            //Application.Run(new ADMINUI());
            //Application.Run(new ReturnBook());
             // Application.Run(new IssueBooks());
            //Application.Run(new CompleteBookDetails());
            //Application.Run(new FeePayments());
          //Application.Run(new Dashbord());

        }
    }
    }


