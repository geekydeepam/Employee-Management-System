using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Employee
{
    public partial class Desig : Form
    {
        string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        //SqlDataAdapter sqlDataAdapter;

       // string ConnectionString = "Data Source=DESKTOP-JB7EMK3;Initial Catalog=Employee_db;Integrated Security=True";
        public Desig()
        {
            InitializeComponent();
        }



        public void LoadDesignationData()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConnectionString;
            try
            {
                sqlConnection.Open();
                //Execute the Query

                string selectQuery = "select * from tbl_designation";
                //string selectQuery = "select E.Emp_ID as Employee_ID,E.First_name as FIRST,E.Middle_name as MIDDLE,E.Last_name as LAST,D.Designation_ID as DESIGNATION_ID,D.Designation_Name as DESIGNATION_NAME from tbl_employee as E" +
                //    "JOIN tbl_designation as D ON E.Designation_ID=D.Designation_ID ";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, ConnectionString);
                //create data table class object
                DataTable table = new DataTable();
                //add table to data adpater to fill virtual data into table
                sqlDataAdapter.Fill(table);

                dgvdesign.DataSource = table;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }


        //private void LoadDesignation()
        //{
        //    SqlConnection conn = new SqlConnection(ConnectionString);
        //    string query = "SELECT Designation_ID,DesignationName FROM tbl_Designation";
        //    SqlDataAdapter da = new SqlDataAdapter(query, conn);
        //    conn.Open();
        //    DataSet ds = new DataSet();
        //    da.Fill(ds, "Designation");
        //    DesigCombo.DisplayMember = "DesignationName";
        //    DesigCombo.ValueMember = "Designation_ID";
        //    DesigCombo.DataSource = ds.Tables["Designation"];
        //}

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadDesignationData();
        }

        private void DesigCombo_MouseClick(object sender, MouseEventArgs e)
        {
            //LoadDesignation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int DesignationID = Convert.ToInt32(DesigIDBox.Text);
            string DesignationNAME = DesigNamebox.Text;

            string insertQuery = $"insert into tbl_designation(Designation_ID,DesignationName)" +
                $"Values ({DesignationID},'{DesignationNAME}')";

            sqlCommand = new SqlCommand(insertQuery, sqlConnection);

            try
            {
                //Open the connection
                sqlConnection.Open();

                //Execute the Query
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //Close the connection
                sqlConnection.Close();
                MessageBox.Show("Saved");
                LoadDesignationData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int DesignationID = Convert.ToInt32(DesigIDBox.Text);
            string DesignationNAME = DesigNamebox.Text;

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConnectionString;

            string UpdateQuery = $"Update tbl_designation SET Designation_ID={DesignationID}," +
                $"DesignationName='{DesignationNAME}' where Designation_ID={Convert.ToInt32(DesigIDBox.Text)}";


            sqlCommand = new SqlCommand(UpdateQuery, sqlConnection);

            try
            {
                //Open the connection
                sqlConnection.Open();

                //Execute the Query
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //Close the connection
                sqlConnection.Close();
                MessageBox.Show("Saved");
                LoadDesignationData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConnectionString;
            string DeleteQuery = $"DELETE from  tbl_designation where Designation_ID={Convert.ToInt32(DesigIDBox.Text)}";

            sqlCommand = new SqlCommand(DeleteQuery, sqlConnection);

            try
            {
                //Open the connection
                sqlConnection.Open();

                //Execute the Query
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //Close the connection
                sqlConnection.Close();
                MessageBox.Show("Deleted Succesfully");
                LoadDesignationData();
            }
        }

        private void DesigIDBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
