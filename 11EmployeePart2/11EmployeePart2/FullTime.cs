using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       11/2/18           
/// Purpose:    Create a new Employee System (11EmployeePart2)
/// </summary>

namespace _11EmployeePart2
{
    class FullTime : Employee //Inheritance 
    {
        #region Class Fields
        private decimal salary;
        private double vacDays;
        private double sickDays;
        private bool taxExempt;
        private bool insured;        
        #endregion Class Fields

        #region Public Properties
        public decimal Salary { get => salary; set => salary = value; }
        public double VacDays { get => vacDays; set => vacDays = value; }
        public double SickDays { get => sickDays; set => sickDays = value; }
        public bool TaxExempt { get => taxExempt; set => taxExempt = value; }
        public bool Insured { get => insured; set => insured = value; }
        #endregion Public Properties

        #region Constructors
        /// <summary>
        /// No Arg Constructor
        /// </summary>
        public FullTime()
        {

        }

        /// <summary>
        /// Full Constructor
        /// </summary>
        public FullTime(decimal salaryAmt, double vDays, double sDays, bool taxEx, bool insurance)
        {
            salary = salaryAmt;
            vacDays = vDays;
            sickDays = sDays;
            taxExempt = taxEx;
            insured = insurance;
        }

        /// <summary>
        /// Added by refactoring to solve an error
        /// with GetAllFullTime() in DataAdapter Class
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <param name="v4"></param>
        public FullTime(string v1, string v2, string v3, string v4)
        {
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Overrides ToString 
        /// and
        /// Returns First and Last names from Employee Class Inheritance
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        /// <summary>
        /// CalcTaxes method that overrides the virtual 
        /// method declared in the base class
        /// </summary>
        /// <returns></returns>
        public override decimal calculateTaxes()
        {
            //Leaving blank due to not having access to needed fields yet
        }

        /// <summary>
        /// CalcTotalEarnings method that overrides 
        /// the virtual method declared in the base class
        /// </summary>
        /// <returns></returns>
        public override decimal calcTotalEarnings()
        {
            //Leaving blank due to not having access to needed fields yet
        }
        #endregion Methods


    }
}
