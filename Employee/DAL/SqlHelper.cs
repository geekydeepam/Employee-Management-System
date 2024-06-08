using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee.DAL
{ 
    public class SqlHelper
    {
        //string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
       
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        
        SqlCommand sqlCommand = new SqlCommand(ConfigurationManager.AppSettings["ConnectionString"]);
        
        SqlDataAdapter adapter=new SqlDataAdapter(); 
        
        public DataSet data=new DataSet();

        public List<SqlParameter> Parameters = new List<SqlParameter>();
       
        DataTable table = new DataTable();


        public void AddParam(string paraName,object value)
        {
            SqlParameter sqlParameter = new SqlParameter(paraName,value);
            
            Parameters.Add(sqlParameter);
        }
        //public void ad(SqlCommand sqlC,string query)
        //{
        //    data=new DataSet();
        //    adapter = new SqlDataAdapter(sqlC);
        //    count=adapter.Fill(data,query);
        //}
        
        
        public void ExecSqlLoadAdapter(string query)                   ////LOAD EMPLOYEE DATA BY STORED PROCEDURE
        {
            
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);

                foreach (var param in Parameters)
                {
                    sqlCommand.Parameters.Add(param);
                }
                Parameters.Clear();

                adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(data,query);

                
                
                //sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(sqlConnection.State==ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }




        public void ExecSqlQuery(string Query)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand=new SqlCommand(Query,sqlConnection);

                foreach (var param in Parameters) 
                {
                    sqlCommand.Parameters.Add(param);
                }
                Parameters.Clear();
                sqlCommand.ExecuteNonQuery();   
                sqlConnection.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
            
            if(sqlConnection.State==ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

    }
}
