namespace Employee
{
    partial class Desig
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
            this.designlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DesigNamebox = new System.Windows.Forms.TextBox();
            this.dgvdesign = new System.Windows.Forms.DataGridView();
            this.DesigIDBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdesign)).BeginInit();
            this.SuspendLayout();
            // 
            // designlabel
            // 
            this.designlabel.AutoSize = true;
            this.designlabel.Location = new System.Drawing.Point(193, 14);
            this.designlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.designlabel.Name = "designlabel";
            this.designlabel.Size = new System.Drawing.Size(93, 13);
            this.designlabel.TabIndex = 0;
            this.designlabel.Text = "Designation Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Designation Name";
            // 
            // DesigNamebox
            // 
            this.DesigNamebox.Location = new System.Drawing.Point(126, 157);
            this.DesigNamebox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DesigNamebox.Name = "DesigNamebox";
            this.DesigNamebox.Size = new System.Drawing.Size(137, 20);
            this.DesigNamebox.TabIndex = 1;
            // 
            // dgvdesign
            // 
            this.dgvdesign.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdesign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdesign.Location = new System.Drawing.Point(0, 250);
            this.dgvdesign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvdesign.Name = "dgvdesign";
            this.dgvdesign.RowHeadersWidth = 62;
            this.dgvdesign.RowTemplate.Height = 28;
            this.dgvdesign.Size = new System.Drawing.Size(400, 432);
            this.dgvdesign.TabIndex = 3;
            // 
            // DesigIDBox
            // 
            this.DesigIDBox.Location = new System.Drawing.Point(126, 129);
            this.DesigIDBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DesigIDBox.Name = "DesigIDBox";
            this.DesigIDBox.Size = new System.Drawing.Size(110, 20);
            this.DesigIDBox.TabIndex = 0;
            this.DesigIDBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DesigIDBox_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(41, 206);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 22);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(126, 206);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 22);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(236, 206);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 22);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Desig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1118, 682);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.DesigIDBox);
            this.Controls.Add(this.dgvdesign);
            this.Controls.Add(this.DesigNamebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.designlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Desig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdesign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label designlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DesigNamebox;
        private System.Windows.Forms.DataGridView dgvdesign;
        private System.Windows.Forms.TextBox DesigIDBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}