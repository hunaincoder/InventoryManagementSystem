namespace InventoryManagement
{
    partial class ManageEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboUserID = new System.Windows.Forms.ComboBox();
            this.btnClearEmpRec = new System.Windows.Forms.Button();
            this.btnEmpHome = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.comboAccLvl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpSched = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpDesig = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateAssigned = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.GridEmployee = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.comboAssignedBy = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lable1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 100);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(845, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Employees";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.White;
            this.lable1.Location = new System.Drawing.Point(206, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(473, 39);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "MART MANAGEMENT SYSYTEM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.BlueViolet;
            this.label10.Location = new System.Drawing.Point(48, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Assigned Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(48, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "User ID";
            // 
            // comboUserID
            // 
            this.comboUserID.FormattingEnabled = true;
            this.comboUserID.Location = new System.Drawing.Point(146, 268);
            this.comboUserID.Name = "comboUserID";
            this.comboUserID.Size = new System.Drawing.Size(198, 21);
            this.comboUserID.TabIndex = 69;
            // 
            // btnClearEmpRec
            // 
            this.btnClearEmpRec.BackColor = System.Drawing.Color.BlueViolet;
            this.btnClearEmpRec.FlatAppearance.BorderSize = 0;
            this.btnClearEmpRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEmpRec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEmpRec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearEmpRec.Location = new System.Drawing.Point(187, 463);
            this.btnClearEmpRec.Name = "btnClearEmpRec";
            this.btnClearEmpRec.Size = new System.Drawing.Size(75, 32);
            this.btnClearEmpRec.TabIndex = 68;
            this.btnClearEmpRec.Text = "Clear";
            this.btnClearEmpRec.UseVisualStyleBackColor = false;
            // 
            // btnEmpHome
            // 
            this.btnEmpHome.BackColor = System.Drawing.Color.BlueViolet;
            this.btnEmpHome.FlatAppearance.BorderSize = 0;
            this.btnEmpHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmpHome.Location = new System.Drawing.Point(106, 463);
            this.btnEmpHome.Name = "btnEmpHome";
            this.btnEmpHome.Size = new System.Drawing.Size(75, 32);
            this.btnEmpHome.TabIndex = 67;
            this.btnEmpHome.Text = "Home";
            this.btnEmpHome.UseVisualStyleBackColor = false;
            this.btnEmpHome.Click += new System.EventHandler(this.btnEmpHome_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDeleteEmp.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteEmp.Location = new System.Drawing.Point(227, 411);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(75, 32);
            this.btnDeleteEmp.TabIndex = 66;
            this.btnDeleteEmp.Text = "Delete";
            this.btnDeleteEmp.UseVisualStyleBackColor = false;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.BackColor = System.Drawing.Color.BlueViolet;
            this.btnEditEmp.FlatAppearance.BorderSize = 0;
            this.btnEditEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditEmp.Location = new System.Drawing.Point(146, 411);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(75, 32);
            this.btnEditEmp.TabIndex = 65;
            this.btnEditEmp.Text = "Edit";
            this.btnEditEmp.UseVisualStyleBackColor = false;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAddEmp.FlatAppearance.BorderSize = 0;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddEmp.Location = new System.Drawing.Point(65, 411);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(75, 32);
            this.btnAddEmp.TabIndex = 64;
            this.btnAddEmp.Text = "Add";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // comboAccLvl
            // 
            this.comboAccLvl.FormattingEnabled = true;
            this.comboAccLvl.Location = new System.Drawing.Point(146, 295);
            this.comboAccLvl.Name = "comboAccLvl";
            this.comboAccLvl.Size = new System.Drawing.Size(198, 21);
            this.comboAccLvl.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.BlueViolet;
            this.label7.Location = new System.Drawing.Point(48, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Access Level";
            // 
            // txtEmpSched
            // 
            this.txtEmpSched.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSched.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtEmpSched.Location = new System.Drawing.Point(146, 235);
            this.txtEmpSched.Name = "txtEmpSched";
            this.txtEmpSched.Size = new System.Drawing.Size(198, 27);
            this.txtEmpSched.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(48, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Emp Schedule";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtEmpName.Location = new System.Drawing.Point(146, 170);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(198, 27);
            this.txtEmpName.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(48, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Emp Designation";
            // 
            // txtEmpDesig
            // 
            this.txtEmpDesig.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpDesig.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtEmpDesig.Location = new System.Drawing.Point(146, 202);
            this.txtEmpDesig.Name = "txtEmpDesig";
            this.txtEmpDesig.Size = new System.Drawing.Size(198, 27);
            this.txtEmpDesig.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(48, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Employee Name";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtEmpID.Location = new System.Drawing.Point(146, 137);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(198, 27);
            this.txtEmpID.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(48, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Employee ID";
            // 
            // dateAssigned
            // 
            this.dateAssigned.Location = new System.Drawing.Point(146, 324);
            this.dateAssigned.Name = "dateAssigned";
            this.dateAssigned.Size = new System.Drawing.Size(200, 20);
            this.dateAssigned.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.BlueViolet;
            this.label9.Location = new System.Drawing.Point(48, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Assigned By";
            // 
            // GridEmployee
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.GridEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridEmployee.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridEmployee.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridEmployee.Location = new System.Drawing.Point(382, 146);
            this.GridEmployee.Name = "GridEmployee";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.GridEmployee.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEmployee.Size = new System.Drawing.Size(485, 358);
            this.GridEmployee.TabIndex = 76;
            this.GridEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEmployee_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.BlueViolet;
            this.label11.Location = new System.Drawing.Point(530, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 24);
            this.label11.TabIndex = 77;
            this.label11.Text = "EMPLOYEES LIST";
            // 
            // comboAssignedBy
            // 
            this.comboAssignedBy.FormattingEnabled = true;
            this.comboAssignedBy.Location = new System.Drawing.Point(146, 352);
            this.comboAssignedBy.Name = "comboAssignedBy";
            this.comboAssignedBy.Size = new System.Drawing.Size(198, 21);
            this.comboAssignedBy.TabIndex = 78;
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 570);
            this.ControlBox = false;
            this.Controls.Add(this.comboAssignedBy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GridEmployee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateAssigned);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboAccLvl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboUserID);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.btnClearEmpRec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEmpHome);
            this.Controls.Add(this.txtEmpDesig);
            this.Controls.Add(this.btnDeleteEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditEmp);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmpSched);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEmployee";
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboUserID;
        private System.Windows.Forms.Button btnClearEmpRec;
        private System.Windows.Forms.Button btnEmpHome;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.ComboBox comboAccLvl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmpSched;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpDesig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateAssigned;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView GridEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboAssignedBy;
    }
}