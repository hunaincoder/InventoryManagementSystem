namespace InventoryManagement
{
    partial class ManageCategories
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
            this.btnClearCatRec = new System.Windows.Forms.Button();
            this.btnCatHome = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnEditCat = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.GridCategories = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.txtSubCat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCategories)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Customers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.White;
            this.lable1.Location = new System.Drawing.Point(189, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(473, 39);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "MART MANAGEMENT SYSYTEM";
            // 
            // btnClearCatRec
            // 
            this.btnClearCatRec.BackColor = System.Drawing.Color.BlueViolet;
            this.btnClearCatRec.FlatAppearance.BorderSize = 0;
            this.btnClearCatRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCatRec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCatRec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearCatRec.Location = new System.Drawing.Point(196, 379);
            this.btnClearCatRec.Name = "btnClearCatRec";
            this.btnClearCatRec.Size = new System.Drawing.Size(75, 32);
            this.btnClearCatRec.TabIndex = 43;
            this.btnClearCatRec.Text = "Clear";
            this.btnClearCatRec.UseVisualStyleBackColor = false;
            this.btnClearCatRec.Click += new System.EventHandler(this.btnClearCatRec_Click);
            // 
            // btnCatHome
            // 
            this.btnCatHome.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCatHome.FlatAppearance.BorderSize = 0;
            this.btnCatHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCatHome.Location = new System.Drawing.Point(115, 379);
            this.btnCatHome.Name = "btnCatHome";
            this.btnCatHome.Size = new System.Drawing.Size(75, 32);
            this.btnCatHome.TabIndex = 42;
            this.btnCatHome.Text = "Home";
            this.btnCatHome.UseVisualStyleBackColor = false;
            this.btnCatHome.Click += new System.EventHandler(this.btnCatHome_Click);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDeleteCat.FlatAppearance.BorderSize = 0;
            this.btnDeleteCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCat.Location = new System.Drawing.Point(238, 327);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(75, 32);
            this.btnDeleteCat.TabIndex = 41;
            this.btnDeleteCat.Text = "Delete";
            this.btnDeleteCat.UseVisualStyleBackColor = false;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnEditCat
            // 
            this.btnEditCat.BackColor = System.Drawing.Color.BlueViolet;
            this.btnEditCat.FlatAppearance.BorderSize = 0;
            this.btnEditCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditCat.Location = new System.Drawing.Point(157, 327);
            this.btnEditCat.Name = "btnEditCat";
            this.btnEditCat.Size = new System.Drawing.Size(75, 32);
            this.btnEditCat.TabIndex = 40;
            this.btnEditCat.Text = "Edit";
            this.btnEditCat.UseVisualStyleBackColor = false;
            this.btnEditCat.Click += new System.EventHandler(this.btnEditCat_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAddCat.FlatAppearance.BorderSize = 0;
            this.btnAddCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCat.Location = new System.Drawing.Point(76, 327);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(75, 32);
            this.btnAddCat.TabIndex = 39;
            this.btnAddCat.Text = "Add";
            this.btnAddCat.UseVisualStyleBackColor = false;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(520, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "CATEGORIES LIST";
            // 
            // GridCategories
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.GridCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridCategories.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCategories.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridCategories.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridCategories.Location = new System.Drawing.Point(437, 148);
            this.GridCategories.Name = "GridCategories";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.GridCategories.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCategories.Size = new System.Drawing.Size(344, 350);
            this.GridCategories.TabIndex = 37;
            this.GridCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCategories_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(17, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(17, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Category ID";
            // 
            // txtCatID
            // 
            this.txtCatID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatID.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtCatID.Location = new System.Drawing.Point(115, 174);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(198, 27);
            this.txtCatID.TabIndex = 33;
            this.txtCatID.TextChanged += new System.EventHandler(this.txtCatID_TextChanged);
            // 
            // txtCatName
            // 
            this.txtCatName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatName.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtCatName.Location = new System.Drawing.Point(115, 207);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(198, 27);
            this.txtCatName.TabIndex = 31;
            // 
            // txtSubCat
            // 
            this.txtSubCat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCat.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtSubCat.Location = new System.Drawing.Point(115, 240);
            this.txtSubCat.Name = "txtSubCat";
            this.txtSubCat.Size = new System.Drawing.Size(198, 27);
            this.txtSubCat.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(17, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Sub Category";
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 528);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSubCat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteCat);
            this.Controls.Add(this.btnClearCatRec);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.btnCatHome);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.btnEditCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GridCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCategories";
            this.Text = "ManageCategories";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button btnClearCatRec;
        private System.Windows.Forms.Button btnCatHome;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnEditCat;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GridCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.TextBox txtSubCat;
        private System.Windows.Forms.Label label5;
    }
}