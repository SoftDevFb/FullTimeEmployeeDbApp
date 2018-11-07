using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       11/2/18           
/// Purpose:    Create a new Employee System (11EmployeePart2)
/// </summary>

namespace _11EmployeePart2
{
    class DataAdapter
    {
        #region Class Fields
        private static SqlConnection dbConn;
        private static SqlCommand dbCmd;
        private static SqlDataReader dbReader;
        private static Employee aMember;
        private static string sConnection =
            "Data Source=stusql-fa18cis151-rr.cimq4ah3jd04.us-east-2.rds.amazonaws.com,1433; " +
            "Initial Catalog=; User Id=; Password=";
        private static string sql;
        #endregion Class Fields

        /// <summary>
        /// Method to Connect/ Open Database
        /// </summary>
        private static void OpenDB()
        {
            try
            {
                dbConn = new SqlConnection(sConnection);
                dbConn.Open();
            }// end of try
            catch (System.Exception e)
            {
                Console.Error.WriteLine(e);
                throw;
            }// end of catch
        }//end of OpenDB()

        /// <summary>
        /// Method to Disconnect/ Close Database
        /// </summary>
        private static void CloseDB()
        {
            try
            {
                dbReader.Close();
            }//end of try 
            catch (System.Exception e)
            {
                Console.Error.WriteLine(e);
                throw;
            }//end of catch
            finally
            {
                dbConn.Close();
            }//end of finally
        }//end of CloseDB()

        /// <summary>
        /// Method to select all of the fulltime 
        /// employee data and return it in a collection
        /// </summary>
        /// <returns></returns>
        private static SqlDataReader ReadFullTime()
        {
            try
            {
                //set up SQL Comman 
                sql = "SELECT * FROM Employee" +
                    "LEFT JOIN FullTime ON Employee.ID = FullTime.ID;" +
                    "ORDER BY LastName ASC, FirstName ASC;";
                dbCmd = new SqlCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;
                // run the comman
                dbReader = dbCmd.ExecuteReader();
                return dbReader;
            }//end of try
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                throw;
            }//end of catch
        }//end of ReadEmployee()

        public static ArrayList GetAllFullTime()
        {
            OpenDB();
            dbReader = ReadFullTime();

            ArrayList employeeArray = new ArrayList();
            while (dbReader.Read())
            {
                aMember = new FullTime(
                    dbReader["EmployeeID"].ToString(),
                    dbReader["FirstName"].ToString(),
                    dbReader["LastName"].ToString(),
                    dbReader["PhoneNumber"].ToString());
                employeeArray.Add(aMember);
            }
            CloseDB();
            return employeeArray;
        }
    }
}
