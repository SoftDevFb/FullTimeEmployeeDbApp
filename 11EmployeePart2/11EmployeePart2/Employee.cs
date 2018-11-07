using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       10/19/2018 - 11/2/18
/// Purpose:    The objective is to create the Employee Management System base class. 
///             Inheritance Usage
/// </summary>

namespace _11EmployeePart2
{
    class Employee
    {
        #region -- Class Fields
        private string firstName;
        private string lastName;
        private DateTime dateHired;
        private string ssn;
        private string email;
        private decimal taxRate;
        private int id;
        #endregion -- Class Fields

        #region -- Public Properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateHired { get => dateHired; set => dateHired = value; }
        public string Ssn { get => ssn; set => ssn = value; }
        public string Email { get => email; set => email = value; }
        public decimal TaxRate { get => taxRate; set => taxRate = value; }
        public int Id { get => id; set => id = value; }
        #endregion -- Public Properties

        #region -- Constructors
        /// <summary>
        /// Default No Arg
        /// </summary>
        public Employee()
        {

        }

        public Employee(string fName, string lName, DateTime dHired, string social, string eAddress, decimal tRate, int employeeId)
        {
            firstName = fName;
            lastName = lName;
            dateHired = dHired;
            ssn = social;
            email = eAddress;
            taxRate = tRate;
            id = employeeId;
        }
        #endregion -- Constructors

        #region -- Methods
        /// <summary>
        /// To String ()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();//Modify Later
        }

        //The virtual keyword is used to modify a method, property, indexer,
        //or event declaration and allow for it to be overridden in a derived class.
        /// <summary>
        /// Calculate Taxes Method
        /// </summary>
        /// <returns></returns>
        public virtual decimal calculateTaxes()
        {
            //Leaving blank due to not having access to needed fields since only Employee Class built at this point
        }

        ///// <summary>
        ///// Calculate Total Earnings Method
        ///// </summary>
        ///// <returns></returns>
        public virtual decimal calcTotalEarnings()
        {
            //Leaving blank due to not having access to needed fields since only Employee Class built at this point

        }
        #endregion -- Methods

    }
}
