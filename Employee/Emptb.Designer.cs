namespace Employee
{
    partial class Emptb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employee_dbDataSet = new Employee.Employee_dbDataSet();
            this.employeedbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Employee.Employee_dbDataSetTableAdapters.EmployeesTableAdapter();
            this.tblemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_employeeTableAdapter = new Employee.Employee_dbDataSetTableAdapters.tbl_employeeTableAdapter();
            this.employee_dbDataSet1 = new Employee.Employee_dbDataSet1();
            this.tblemployeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_employeeTableAdapter1 = new Employee.Employee_dbDataSet1TableAdapters.tbl_employeeTableAdapter();
            this.tblemployeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblemployeeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblemployeeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblemployeeBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeedbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_dbDataSet
            // 
            this.employee_dbDataSet.DataSetName = "Employee_dbDataSet";
            this.employee_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeedbDataSetBindingSource
            // 
            this.employeedbDataSetBindingSource.DataSource = this.employee_dbDataSet;
            this.employeedbDataSetBindingSource.Position = 0;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeedbDataSetBindingSource;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tblemployeeBindingSource
            // 
            this.tblemployeeBindingSource.DataMember = "tbl_employee";
            this.tblemployeeBindingSource.DataSource = this.employeedbDataSetBindingSource;
            // 
            // tbl_employeeTableAdapter
            // 
            this.tbl_employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employee_dbDataSet1
            // 
            this.employee_dbDataSet1.DataSetName = "Employee_dbDataSet1";
            this.employee_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblemployeeBindingSource1
            // 
            this.tblemployeeBindingSource1.DataMember = "tbl_employee";
            this.tblemployeeBindingSource1.DataSource = this.employee_dbDataSet1;
            // 
            // tbl_employeeTableAdapter1
            // 
            this.tbl_employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // tblemployeeBindingSource2
            // 
            this.tblemployeeBindingSource2.DataMember = "tbl_employee";
            this.tblemployeeBindingSource2.DataSource = this.employeedbDataSetBindingSource;
            // 
            // tblemployeeBindingSource3
            // 
            this.tblemployeeBindingSource3.DataMember = "tbl_employee";
            this.tblemployeeBindingSource3.DataSource = this.employeedbDataSetBindingSource;
            // 
            // tblemployeeBindingSource4
            // 
            this.tblemployeeBindingSource4.DataMember = "tbl_employee";
            this.tblemployeeBindingSource4.DataSource = this.employee_dbDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.mobilenoDataGridViewTextBoxColumn,
            this.joiningDateDataGridViewTextBoxColumn,
            this.designationIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblemployeeBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1142, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblemployeeBindingSource5
            // 
            this.tblemployeeBindingSource5.DataMember = "tbl_employee";
            this.tblemployeeBindingSource5.DataSource = this.employeedbDataSetBindingSource;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "First_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "Middle_name";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Middle_name";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // mobilenoDataGridViewTextBoxColumn
            // 
            this.mobilenoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_no";
            this.mobilenoDataGridViewTextBoxColumn.HeaderText = "Mobile_no";
            this.mobilenoDataGridViewTextBoxColumn.Name = "mobilenoDataGridViewTextBoxColumn";
            // 
            // joiningDateDataGridViewTextBoxColumn
            // 
            this.joiningDateDataGridViewTextBoxColumn.DataPropertyName = "Joining_Date";
            this.joiningDateDataGridViewTextBoxColumn.HeaderText = "Joining_Date";
            this.joiningDateDataGridViewTextBoxColumn.Name = "joiningDateDataGridViewTextBoxColumn";
            // 
            // designationIDDataGridViewTextBoxColumn
            // 
            this.designationIDDataGridViewTextBoxColumn.DataPropertyName = "Designation_ID";
            this.designationIDDataGridViewTextBoxColumn.HeaderText = "Designation_ID";
            this.designationIDDataGridViewTextBoxColumn.Name = "designationIDDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Table";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Emptb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1152, 629);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emptb";
            this.ShowIcon = false;
            this.Text = "Emptb";
            this.Load += new System.EventHandler(this.Emptb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeedbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource employeedbDataSetBindingSource;
        private Employee_dbDataSet employee_dbDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Employee_dbDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource tblemployeeBindingSource;
        private Employee_dbDataSetTableAdapters.tbl_employeeTableAdapter tbl_employeeTableAdapter;
        private Employee_dbDataSet1 employee_dbDataSet1;
        private System.Windows.Forms.BindingSource tblemployeeBindingSource1;
        private Employee_dbDataSet1TableAdapters.tbl_employeeTableAdapter tbl_employeeTableAdapter1;
        private System.Windows.Forms.BindingSource tblemployeeBindingSource2;
        private System.Windows.Forms.BindingSource tblemployeeBindingSource3;
        private System.Windows.Forms.BindingSource tblemployeeBindingSource4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblemployeeBindingSource5;
        private System.Windows.Forms.Label label1;
    }
}