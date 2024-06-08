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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using Employee.DAL;

namespace Employee
{
    public partial class Emp : Form
    {
        string Fname;
        string Mname;
        string Lname;
        string Gender;
        string Address;
        string mobileno;
        string DOJ;
        string status;
        int DesignationId;
        double salary;

        SqlHelper sqlHelper=new SqlHelper();
        DataSet data=new DataSet();



        string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"]; 
        SqlConnection sqlConnection=new SqlConnection();
        SqlCommand sqlCommand=new SqlCommand();
        SqlDataAdapter sqlDataAdapter=new SqlDataAdapter();

        //string ConnectionString = "Data Source=DESKTOP-JB7EMK3;Initial Catalog=Employee_db;Integrated Security=True";


        public Emp()
        {
            InitializeComponent();
        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadEmpdata();
           //LoadEmployeeData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Fname = FNameBox.Text;
            Validation valid= new Validation();
            bool isnamevalid=valid.isValidText(Fname);

            if(!isnamevalid)
            {
                MessageBox.Show("Insert valid name");
                return;
            }

           // Fname = FNameBox.Text;
            Mname = MNameBox.Text;
            Lname = LNameBox.Text;

            if (Rmale.Checked)
            {
                Gender = "Male";
            }
            else if (Rfemale.Checked)
            {
                Gender = "Female";
            }
            else if (Rother.Checked)
            {
                Gender = "Other";
            }

            Address = AddressBox.Text;
            mobileno = MobileBox.Text;

            bool isvalidnum = valid.isValidNumber(mobileno);
            {
                if(!isvalidnum)
                {
                    MessageBox.Show("Enter Valid Number");
                    return;
                }
            }
            DOJ = JoiningPicker.Value.ToString("yyyy-MM-dd");
            status = StatusCombo.SelectedItem.ToString();
            DesignationId = Convert.ToInt32(DesignationCombo.SelectedValue);
            salary = Convert.ToDouble(SalaryBox.Text);


            ////////////sqlHelper.AddParam("@First_name",Fname);
            ////////////sqlHelper.AddParam("@Middle_name", Mname);
            ////////////sqlHelper.AddParam("@Last_name", Lname);
            ////////////sqlHelper.AddParam("@Gender", Gender);
            ////////////sqlHelper.AddParam("@Address", Address);
            ////////////sqlHelper.AddParam("@Mobile_no", mobileno);
            ////////////sqlHelper.AddParam("@Joining_Date", DOJ);
            ////////////sqlHelper.AddParam("@Designation_ID", DesignationId);
            ////////////sqlHelper.AddParam("@status", status);
            ////////////sqlHelper.AddParam("@Salary",salary);


            ////////////sqlHelper.ExecSqlQuery("exec insertEmployee @First_name,@Middle_name,@Last_name,@Gender,@Address,@Mobile_no,@Joining_Date,@Designation_ID,@status,@Salary");
            //sqlHelper.ExecSqlQuery($"exec insertEmployee '{Fname}','{Mname}','{Lname}','{Gender}','{Address}',{mobileno},'{DOJ}',{DesignationId},'{status}',{salary}");


            //sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = ConnectionString;



            //string insertQuery = $"INSERT INTO tbl_employee (First_name,Middle_name,Last_name,Gender,Address,Mobile_no,Joining_Date,Designation_ID,status,Salary)" +
            //$"VALUES ('{Fname}','{Mname}','{Lname}','{Gender}','{Address}',{mobileno},'{DOJ}',{DesignationId},'{status}',{salary})";

            //sqlCommand = new SqlCommand(insertQuery, sqlConnection);

            try
            {
                sqlHelper.ExecSqlQuery($"exec insertEmployee '{Fname}','{Mname}','{Lname}','{Gender}','{Address}',{mobileno},'{DOJ}',{DesignationId},'{status}',{salary}");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                MessageBox.Show("Saved");
                loadEmpdata();
            }


            //try
            //{
            //    //Open the connection
            //    sqlConnection.Open();

            //    //Execute the Query
            //    sqlCommand.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //finally
            //{
            //    //Close the connection
            //    sqlConnection.Close();
            //    MessageBox.Show("Saved");
            //    LoadEmployeeData();
            //}
        }

        private void ID_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string SearchQuery = $"Select * from tbl_employee Where Emp_ID={IDbox.Text}";

                sqlConnection = new SqlConnection();

                sqlConnection.ConnectionString = ConnectionString;

                sqlCommand = new SqlCommand(SearchQuery, sqlConnection);

                try
                {
                    if (sqlConnection.State != ConnectionState.Open)
                    {
                        sqlConnection.Open();
                    }
                    SqlDataReader reader = sqlCommand.ExecuteReader();//will fire our query, and save th edat ainside the reader
                    if (reader.Read())      //if able to read
                    {
                        FNameBox.Text = reader["First_name"].ToString();
                        MNameBox.Text = reader["Middle_name"].ToString();
                        LNameBox.Text = reader["Last_name"].ToString();
                        AddressBox.Text = reader["Address"].ToString();
                        MobileBox.Text = reader["Mobile_no"].ToString();
                        DesignationCombo.SelectedItem = reader["Designation_ID"].ToString();
                        JoiningPicker.Value = (DateTime)reader["Joining_date"];
                        SalaryBox.Text = reader["salary"].ToString() ;
                        StatusCombo.SelectedItem = reader["status"].ToString(); 


                        if (reader["Gender"].ToString() == "Male")
                        {
                            Rmale.Checked = true;
                        }
                        else if (reader["gender"].ToString() == "Female")
                        {
                            Rfemale.Checked = true;
                        }
                        else
                        {
                            Rother.Checked = true;
                        }

                    }
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);

                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = ConnectionString;

            //string DeleteQuery = $"DELETE from tbl_employee where Emp_ID={IDbox.Text}";

            //sqlCommand = new SqlCommand(DeleteQuery, sqlConnection);

            try
            {
                sqlHelper.ExecSqlQuery($"exec deleteEmployeeByEmpID {IDbox.Text}");  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                
                MessageBox.Show("Deleted Succesfully");
                //LoadEmployeeData();
                loadEmpdata();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             Fname = FNameBox.Text;
             Mname = MNameBox.Text;
             Lname = LNameBox.Text;


            if (Rmale.Checked)
            {
                Gender = "Male";
            }
            else if (Rfemale.Checked)
            {
                Gender = "Female";
            }
            else
            {
                Gender = "Other";
            }
            Address = AddressBox.Text;
            mobileno = MobileBox.Text;
            DOJ = JoiningPicker.Value.ToString("yyyy-MM-dd");
            status = StatusCombo.SelectedItem.ToString();
            DesignationId = Convert.ToInt32(DesignationCombo.SelectedValue);
            salary = Convert.ToDouble(SalaryBox.Text);

            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConnectionString;

            try
            {
                sqlHelper.ExecSqlQuery($"exec updateEmployee '{Fname}','{Mname}','{Lname}','{Gender}','{Address}',{mobileno},'{DOJ}',{DesignationId},'{status}',{salary},{Convert.ToInt32(IDbox.Text)}");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                MessageBox.Show("Saved");
                //LoadEmployeeData();
                loadEmpdata();
            }


            //string UpdateQuery = $"Update tbl_employee SET First_name='{Fname}', Middle_name='{Mname}', Last_name='{Lname}',Gender='{Gender}'," +
            //    $"Address='{Address}',Mobile_no={mobileno}, Joining_Date='{DOJ}',Designation_ID={DesignationId},status='{status}',salary={salary}  where Emp_ID={IDbox.Text}";

            // sqlCommand = new SqlCommand(UpdateQuery, sqlConnection);
            //try
            //{
            //    //Open the connection
            //    sqlConnection.Open();

            //    //Execute the Query
            //    sqlCommand.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //finally
            //{
            //    //Close the connection
            //    sqlConnection.Close();
            //    MessageBox.Show("Updated Succesfully");
            //    LoadEmployeeData();
            //}
        }



        private void cell_double_click(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dgv.Rows[e.RowIndex];
                IDbox.Text = dataGridViewRow.Cells[0].Value.ToString();
                FNameBox.Text = dataGridViewRow.Cells[1].Value.ToString();
                MNameBox.Text = dataGridViewRow.Cells[2].Value.ToString();
                LNameBox.Text = dataGridViewRow.Cells[3].Value.ToString();
                
                if (dataGridViewRow.Cells[4].Value.ToString().Equals("Male"))
                {
                    Rmale.Checked = true;
                }
                else if (dataGridViewRow.Cells[4].Value.ToString().Equals("Female"))
                {
                    Rfemale.Checked = true;
                }
                else 
                {
                    Rother.Checked = true;
                }

                AddressBox.Text = dataGridViewRow.Cells[5].Value.ToString();
                MobileBox.Text = dataGridViewRow.Cells[6].Value.ToString();
                JoiningPicker.Value = (DateTime)dataGridViewRow.Cells[7].Value;
                StatusCombo.SelectedItem = dataGridViewRow.Cells[8].Value.ToString();
                SalaryBox.Text = dataGridViewRow.Cells[9].Value.ToString();

            }
        }

        private void btnSearchBY_Click(object sender, EventArgs e)
        {
            search();
        }

        private void SearchbyBox_TextChanged(object sender, EventArgs e) ///////////////////////////////////
        {
            string[] searchparameters = {"First_name", "Middle_name", "Last_name", "Gender","Address", "Mobile_no", "Joining_Date", "D.Designation_ID", "status", "Salary","D.DesignationName" };
            string searchvalue=SearchbyBox.Text.ToString();
            
            sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = ConnectionString;

            try
            {
                for (int i = 0; i < searchparameters.Length; i++)
                {
                    string Query = $"select E.*,D.DesignationName from tbl_employee as E\r\njoin tbl_designation as D\r\non E.Designation_ID=D.Designation_ID Where {searchparameters[i]} Like '%{searchvalue}%' ";
                    sqlCommand = new SqlCommand(Query, sqlConnection);
                    if (sqlConnection.State != ConnectionState.Open)
                    {
                        sqlConnection.Open();
                    }
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Query, ConnectionString);
                        //create data table class object
                        DataTable table = new DataTable();
                        //add table to data adpater to fill virtual data into table
                        sqlDataAdapter.Fill(table);

                        dgv.DataSource = table;

                        sqlConnection.Close();
                        reader.Close();
                        break;
                    }
                    else
                    {
                        reader.Close();
                        continue;

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IDbox_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void DesignationCombo_Click(object sender, EventArgs e)
        {
            LoadDesignation();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            //Console.Beep();
            clear();
            string SearchQuery = $"select max(Emp_ID)+1 as MaxEMPID from tbl_employee;";

            sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = ConnectionString;

            sqlCommand = new SqlCommand(SearchQuery, sqlConnection);
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    IDbox.Text = reader["MaxEMPID"].ToString();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SearchbyBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.Enter)
            //{
            //    search();
            //}   
            
        }
        public void search()
        {
            string searchParameter = "First_name";
            string searchValue = string.Empty;

            if (Rname.Checked)
            {
                searchParameter = "First_name";
            }
            else if (RempID.Checked)
            {
                searchParameter = "Emp_ID";
            }
            else
            {
                searchParameter = "Designation_ID";
            }
            searchValue = SearchbyBox.Text;

            sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = ConnectionString;

            try
            {
                sqlConnection.Open();
                //Step 1 Create select Query for fetch data
                string selectQuery = $"Select * from tbl_employee Where {searchParameter} Like '%{searchValue}%' ";
                //step 2 Create SQL Data Adapter clasa object 
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, ConnectionString);
                //step create datatable class object for savaing data into virtual table 
                DataTable table = new DataTable();
                //add table to data adapter to fill virtual data into table
                sqlDataAdapter.Fill(table);
                dgv.DataSource = table;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void SearchbyBox_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Back)
            //{
            //    if(SearchbyBox.Text!=string.Empty)
            //    {
            //        search();
            //    }
            //    else
            //    {
            //        LoadEmployeeData();
            //    }
            //}
        }

        private void LoadDesignation()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string query = "SELECT Designation_ID,DesignationName FROM tbl_Designation";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            conn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Designation");
            DesignationCombo.DisplayMember = "DesignationName";
            DesignationCombo.ValueMember = "Designation_ID";
            DesignationCombo.DataSource = ds.Tables["Designation"];

        }
        public void LoadEmployeeData()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConnectionString; 
            try
            {
               // sqlHelper.ExecSql("exec getEmpData");

                sqlConnection.Open();
                ////Execu te the Query

                //string selectQuery = "exec getEmpData";
                string selectQuery = "select E.*,D.DesignationName from tbl_employee as E\r\n inner join tbl_designation as D\r\non E.Designation_ID=D.Designation_ID;";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, ConnectionString);
                ////create data table class object
                DataTable table = new DataTable();
                ////add table to data adpater to fill virtual data into table
                sqlDataAdapter.Fill(table);

                dgv.DataSource = table;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void loadEmpdata()
        {
            sqlHelper=new SqlHelper();
            sqlHelper.AddParam("@ACTION", "Select");
            sqlHelper.ExecSqlLoadAdapter("EXEC EMPLOYEE null,null,null,null,null,null,null,null,null,null,null,@ACTION");
            data = new DataSet();
            dgv.DataSource = sqlHelper.data.Tables[0];
        }
        public void clear()
        {
            IDbox.Clear();
            FNameBox.Clear();
            MNameBox.Clear();
            LNameBox.Clear();
            Rmale.Checked = false;
            Rfemale.Checked = false;
            Rother.Checked = false;
            AddressBox.Clear();
            MobileBox.Clear();
            DesignationCombo.Text = "Select";
            StatusCombo.Text = "Select";
            JoiningPicker.Value = DateTime.Now;
            SalaryBox.Clear();
        }
    }
}
