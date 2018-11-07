using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       11/2/18           
/// Purpose:    Create a new Employee System (11EmployeePart2)
/// </summary>

namespace _11EmployeePart2
{
    public partial class FullTimeForm : Form
    {
        private SqlDataAdapter fullTimeDataAdap;
        private DataSet memberDS;
        //private SqlCommandBuilder cBuilder;
        private SqlConnection dbConn;
        private SqlCommand dbCmd;
        private string sConnection;
        private string sql;

        public FullTimeForm()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sConnection =
                    "Data Source=stusql-fa18cis151-rr.cimq4ah3jd04.us-east-2.rds.amazonaws.com,1433; " +
                    "Initial Catalog=; User Id=; Password=";

                dbConn = new SqlConnection(sConnection);
                dbConn.Open();

                //Set up sql statement
                sql = "SELECT * FROM FullTime " +
                      "ORDER BY LastName ASC, FirstName ASC;";
                //Create command object
                dbCmd = new SqlCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                //Set up data adapter
                fullTimeDataAdap = new SqlDataAdapter();
                fullTimeDataAdap.SelectCommand = dbCmd;

                //Set up dataset
                memberDS = new DataSet();
                fullTimeDataAdap.Fill(memberDS, "memberTable");

                //Connect to data grid
                dataGrid.DataSource = memberDS;
                dataGrid.DataMember = "memberTable";
                lblMessage.Text = "Data Loaded";
            }//end of try
            catch (System.Exception exc)
            {
                lblMessage.Text = exc.Message;
            }//end of catch
        }
    }
}
