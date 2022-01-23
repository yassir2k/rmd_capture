using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cac_status_checker
{
    static class Program
    {
        public static bool Status { get;  set; }
        public static string user_name { get; set; }
        public static string user_full_name { get; set; }
        public static string user_password { get; set; }
        public static string access_level { get; set; }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
            if (Status)
            {
                // MainForm is defined elsewhere
                Application.Run(new searchEntryForm ());
            }
            
        }
    }
}
