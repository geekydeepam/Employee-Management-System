namespace Employee
{
    partial class Emp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.MobileBox = new System.Windows.Forms.TextBox();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.MNameBox = new System.Windows.Forms.TextBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.Rmale = new System.Windows.Forms.RadioButton();
            this.Rfemale = new System.Windows.Forms.RadioButton();
            this.Rother = new System.Windows.Forms.RadioButton();
            this.JoiningPicker = new System.Windows.Forms.DateTimePicker();
            this.DesignationCombo = new System.Windows.Forms.ComboBox();
            this.StatusCombo = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Rname = new System.Windows.Forms.RadioButton();
            this.RempID = new System.Windows.Forms.RadioButton();
            this.RdesigID = new System.Windows.Forms.RadioButton();
            this.SearchbyBox = new System.Windows.Forms.TextBox();
            this.btnSearchBY = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Label();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mobile No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Joining Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Designation ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 271);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 296);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Salary";
            // 
            // IDbox
            // 
            this.IDbox.Location = new System.Drawing.Point(125, 66);
            this.IDbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(68, 20);
            this.IDbox.TabIndex = 10;
            this.IDbox.TextChanged += new System.EventHandler(this.IDbox_TextChanged);
            this.IDbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_keydown);
            // 
            // FNameBox
            // 
            this.FNameBox.Location = new System.Drawing.Point(125, 90);
            this.FNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(103, 20);
            this.FNameBox.TabIndex = 0;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(133, 141);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(172, 44);
            this.AddressBox.TabIndex = 6;
            // 
            // MobileBox
            // 
            this.MobileBox.Location = new System.Drawing.Point(133, 192);
            this.MobileBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MobileBox.MaxLength = 10;
            this.MobileBox.Name = "MobileBox";
            this.MobileBox.Size = new System.Drawing.Size(103, 20);
            this.MobileBox.TabIndex = 7;
            // 
            // SalaryBox
            // 
            this.SalaryBox.Location = new System.Drawing.Point(133, 294);
            this.SalaryBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SalaryBox.MaxLength = 8;
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(103, 20);
            this.SalaryBox.TabIndex = 12;
            // 
            // MNameBox
            // 
            this.MNameBox.Location = new System.Drawing.Point(231, 90);
            this.MNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MNameBox.Name = "MNameBox";
            this.MNameBox.Size = new System.Drawing.Size(103, 20);
            this.MNameBox.TabIndex = 1;
            // 
            // LNameBox
            // 
            this.LNameBox.Location = new System.Drawing.Point(336, 90);
            this.LNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(103, 20);
            this.LNameBox.TabIndex = 2;
            // 
            // Rmale
            // 
            this.Rmale.AutoSize = true;
            this.Rmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rmale.Location = new System.Drawing.Point(125, 115);
            this.Rmale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rmale.Name = "Rmale";
            this.Rmale.Size = new System.Drawing.Size(40, 13);
            this.Rmale.TabIndex = 3;
            this.Rmale.TabStop = true;
            this.Rmale.Text = "Male";
            this.Rmale.UseVisualStyleBackColor = true;
            // 
            // Rfemale
            // 
            this.Rfemale.AutoSize = true;
            this.Rfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rfemale.Location = new System.Drawing.Point(176, 115);
            this.Rfemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rfemale.Name = "Rfemale";
            this.Rfemale.Size = new System.Drawing.Size(49, 13);
            this.Rfemale.TabIndex = 4;
            this.Rfemale.TabStop = true;
            this.Rfemale.Text = "Female";
            this.Rfemale.UseVisualStyleBackColor = true;
            this.Rfemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Rother
            // 
            this.Rother.AutoSize = true;
            this.Rother.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rother.Location = new System.Drawing.Point(235, 115);
            this.Rother.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rother.Name = "Rother";
            this.Rother.Size = new System.Drawing.Size(42, 13);
            this.Rother.TabIndex = 5;
            this.Rother.TabStop = true;
            this.Rother.Text = "Other";
            this.Rother.UseVisualStyleBackColor = true;
            // 
            // JoiningPicker
            // 
            this.JoiningPicker.Location = new System.Drawing.Point(133, 218);
            this.JoiningPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.JoiningPicker.Name = "JoiningPicker";
            this.JoiningPicker.Size = new System.Drawing.Size(117, 20);
            this.JoiningPicker.TabIndex = 8;
            // 
            // DesignationCombo
            // 
            this.DesignationCombo.FormattingEnabled = true;
            this.DesignationCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.DesignationCombo.Location = new System.Drawing.Point(133, 246);
            this.DesignationCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DesignationCombo.Name = "DesignationCombo";
            this.DesignationCombo.Size = new System.Drawing.Size(68, 21);
            this.DesignationCombo.TabIndex = 9;
            this.DesignationCombo.Text = "Select";
            this.DesignationCombo.Click += new System.EventHandler(this.DesignationCombo_Click);
            // 
            // StatusCombo
            // 
            this.StatusCombo.FormattingEnabled = true;
            this.StatusCombo.Items.AddRange(new object[] {
            "Active",
            "Left"});
            this.StatusCombo.Location = new System.Drawing.Point(133, 269);
            this.StatusCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusCombo.Name = "StatusCombo";
            this.StatusCombo.Size = new System.Drawing.Size(103, 21);
            this.StatusCombo.TabIndex = 10;
            this.StatusCombo.Text = "Select";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Location = new System.Drawing.Point(343, 332);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 22);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(273, 332);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 22);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(131, 332);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 22);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(61, 332);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 22);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(-7, 371);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1292, 391);
            this.dgv.TabIndex = 29;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_double_click);
            // 
            // Rname
            // 
            this.Rname.AutoSize = true;
            this.Rname.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rname.Location = new System.Drawing.Point(857, 303);
            this.Rname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rname.Name = "Rname";
            this.Rname.Size = new System.Drawing.Size(55, 13);
            this.Rname.TabIndex = 30;
            this.Rname.TabStop = true;
            this.Rname.Tag = "";
            this.Rname.Text = "By Name";
            this.Rname.UseVisualStyleBackColor = true;
            this.Rname.Visible = false;
            // 
            // RempID
            // 
            this.RempID.AutoSize = true;
            this.RempID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RempID.Location = new System.Drawing.Point(857, 320);
            this.RempID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RempID.Name = "RempID";
            this.RempID.Size = new System.Drawing.Size(78, 13);
            this.RempID.TabIndex = 31;
            this.RempID.TabStop = true;
            this.RempID.Tag = "";
            this.RempID.Text = "By Employee ID";
            this.RempID.UseVisualStyleBackColor = true;
            this.RempID.Visible = false;
            // 
            // RdesigID
            // 
            this.RdesigID.AutoSize = true;
            this.RdesigID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdesigID.Location = new System.Drawing.Point(857, 338);
            this.RdesigID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RdesigID.Name = "RdesigID";
            this.RdesigID.Size = new System.Drawing.Size(84, 13);
            this.RdesigID.TabIndex = 32;
            this.RdesigID.TabStop = true;
            this.RdesigID.Tag = "";
            this.RdesigID.Text = "By Designation ID";
            this.RdesigID.UseVisualStyleBackColor = true;
            this.RdesigID.Visible = false;
            // 
            // SearchbyBox
            // 
            this.SearchbyBox.Location = new System.Drawing.Point(645, 337);
            this.SearchbyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchbyBox.Name = "SearchbyBox";
            this.SearchbyBox.Size = new System.Drawing.Size(149, 20);
            this.SearchbyBox.TabIndex = 13;
            this.SearchbyBox.Tag = "";
            this.SearchbyBox.TextChanged += new System.EventHandler(this.SearchbyBox_TextChanged);
            this.SearchbyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchbyBox_KeyDown);
            this.SearchbyBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchbyBox_KeyUp);
            // 
            // btnSearchBY
            // 
            this.btnSearchBY.Location = new System.Drawing.Point(797, 337);
            this.btnSearchBY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchBY.Name = "btnSearchBY";
            this.btnSearchBY.Size = new System.Drawing.Size(50, 20);
            this.btnSearchBY.TabIndex = 35;
            this.btnSearchBY.Tag = "";
            this.btnSearchBY.Text = "Search By";
            this.btnSearchBY.UseVisualStyleBackColor = true;
            this.btnSearchBY.Visible = false;
            this.btnSearchBY.Click += new System.EventHandler(this.btnSearchBY_Click);
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.Location = new System.Drawing.Point(279, 37);
            this.employee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(162, 26);
            this.employee.TabIndex = 36;
            this.employee.Text = "Employee Data";
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackColor = System.Drawing.Color.White;
            this.btnAddnew.FlatAppearance.BorderSize = 0;
            this.btnAddnew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddnew.Location = new System.Drawing.Point(202, 332);
            this.btnAddnew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(67, 22);
            this.btnAddnew.TabIndex = 37;
            this.btnAddnew.Text = "Add New";
            this.btnAddnew.UseVisualStyleBackColor = false;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.RdesigID);
            this.panel1.Controls.Add(this.btnAddnew);
            this.panel1.Controls.Add(this.Rname);
            this.panel1.Controls.Add(this.employee);
            this.panel1.Controls.Add(this.RempID);
            this.panel1.Controls.Add(this.btnSearchBY);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.SearchbyBox);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.FNameBox);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StatusCombo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DesignationCombo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.JoiningPicker);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Rother);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Rfemale);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Rmale);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.LNameBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.MNameBox);
            this.panel1.Controls.Add(this.IDbox);
            this.panel1.Controls.Add(this.SalaryBox);
            this.panel1.Controls.Add(this.AddressBox);
            this.panel1.Controls.Add(this.MobileBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 367);
            this.panel1.TabIndex = 38;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(645, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Search";
            // 
            // Emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1285, 783);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Emp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox MobileBox;
        private System.Windows.Forms.TextBox SalaryBox;
        private System.Windows.Forms.TextBox MNameBox;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.RadioButton Rmale;
        private System.Windows.Forms.RadioButton Rfemale;
        private System.Windows.Forms.RadioButton Rother;
        private System.Windows.Forms.DateTimePicker JoiningPicker;
        private System.Windows.Forms.ComboBox DesignationCombo;
        private System.Windows.Forms.ComboBox StatusCombo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RadioButton Rname;
        private System.Windows.Forms.RadioButton RempID;
        private System.Windows.Forms.RadioButton RdesigID;
        private System.Windows.Forms.TextBox SearchbyBox;
        private System.Windows.Forms.Button btnSearchBY;
        private System.Windows.Forms.Label employee;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
    }
}

