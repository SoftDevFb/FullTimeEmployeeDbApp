using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       11/2/18           
/// Purpose:    Create a new Employee System (11EmployeePart2)
/// </summary>

namespace _11EmployeePart2
{
    static class Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FullTimeForm());
        }
    }
}
