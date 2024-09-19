using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Emptb : Form
    {
        public Emptb()
        {
            InitializeComponent();
        }

        private void Emptb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_dbDataSet1.tbl_employee' table. You can move, or remove it, as needed.
            this.tbl_employeeTableAdapter1.Fill(this.employee_dbDataSet1.tbl_employee);
            // TODO: This line of code loads data into the 'employee_dbDataSet.tbl_employee' table. You can move, or remove it, as needed.
            this.tbl_employeeTableAdapter.Fill(this.employee_dbDataSet.tbl_employee);
            // TODO: This line of code loads data into the 'employee_dbDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employee_dbDataSet.Employees);

        }
    }
}
