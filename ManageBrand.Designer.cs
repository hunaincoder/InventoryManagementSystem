namespace InventoryManagement
{
    partial class ManageBrand
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
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtBrandID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GridBrands = new System.Windows.Forms.DataGridView();
            this.btnDeleteBrand = new System.Windows.Forms.Button();
            this.btnClearBrandRec = new System.Windows.Forms.Button();
            this.btnBrandHome = new System.Windows.Forms.Button();
            this.btnEditBrand = new System.Windows.Forms.Button();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBrands)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Brands";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.White;
            this.lable1.Location = new System.Drawing.Point(188, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(473, 39);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "MART MANAGEMENT SYSYTEM";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandName.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtBrandName.Location = new System.Drawing.Point(128, 212);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(198, 27);
            this.txtBrandName.TabIndex = 36;
            // 
            // txtBrandID
            // 
            this.txtBrandID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandID.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtBrandID.Location = new System.Drawing.Point(128, 179);
            this.txtBrandID.Name = "txtBrandID";
            this.txtBrandID.Size = new System.Drawing.Size(198, 27);
            this.txtBrandID.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(30, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Brand ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(30, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Brand Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(552, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "BRANDS LIST";
            // 
            // GridBrands
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.GridBrands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridBrands.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridBrands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridBrands.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridBrands.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridBrands.Location = new System.Drawing.Point(496, 141);
            this.GridBrands.Name = "GridBrands";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.GridBrands.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBrands.Size = new System.Drawing.Size(264, 350);
            this.GridBrands.TabIndex = 40;
            this.GridBrands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridBrands_CellContentClick);
            // 
            // btnDeleteBrand
            // 
            this.btnDeleteBrand.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDeleteBrand.FlatAppearance.BorderSize = 0;
            this.btnDeleteBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBrand.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteBrand.Location = new System.Drawing.Point(237, 318);
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.Size = new System.Drawing.Size(75, 32);
            this.btnDeleteBrand.TabIndex = 46;
            this.btnDeleteBrand.Text = "Delete";
            this.btnDeleteBrand.UseVisualStyleBackColor = false;
            this.btnDeleteBrand.Click += new System.EventHandler(this.btnDeleteBrand_Click);
            // 
            // btnClearBrandRec
            // 
            this.btnClearBrandRec.BackColor = System.Drawing.Color.BlueViolet;
            this.btnClearBrandRec.FlatAppearance.BorderSize = 0;
            this.btnClearBrandRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBrandRec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBrandRec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearBrandRec.Location = new System.Drawing.Point(195, 370);
            this.btnClearBrandRec.Name = "btnClearBrandRec";
            this.btnClearBrandRec.Size = new System.Drawing.Size(75, 32);
            this.btnClearBrandRec.TabIndex = 48;
            this.btnClearBrandRec.Text = "Clear";
            this.btnClearBrandRec.UseVisualStyleBackColor = false;
            this.btnClearBrandRec.Click += new System.EventHandler(this.btnClearBrandRec_Click);
            // 
            // btnBrandHome
            // 
            this.btnBrandHome.BackColor = System.Drawing.Color.BlueViolet;
            this.btnBrandHome.FlatAppearance.BorderSize = 0;
            this.btnBrandHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrandHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrandHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBrandHome.Location = new System.Drawing.Point(114, 370);
            this.btnBrandHome.Name = "btnBrandHome";
            this.btnBrandHome.Size = new System.Drawing.Size(75, 32);
            this.btnBrandHome.TabIndex = 47;
            this.btnBrandHome.Text = "Home";
            this.btnBrandHome.UseVisualStyleBackColor = false;
            this.btnBrandHome.Click += new System.EventHandler(this.btnBrandHome_Click);
            // 
            // btnEditBrand
            // 
            this.btnEditBrand.BackColor = System.Drawing.Color.BlueViolet;
            this.btnEditBrand.FlatAppearance.BorderSize = 0;
            this.btnEditBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBrand.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditBrand.Location = new System.Drawing.Point(156, 318);
            this.btnEditBrand.Name = "btnEditBrand";
            this.btnEditBrand.Size = new System.Drawing.Size(75, 32);
            this.btnEditBrand.TabIndex = 45;
            this.btnEditBrand.Text = "Edit";
            this.btnEditBrand.UseVisualStyleBackColor = false;
            this.btnEditBrand.Click += new System.EventHandler(this.btnEditBrand_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAddBrand.FlatAppearance.BorderSize = 0;
            this.btnAddBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBrand.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddBrand.Location = new System.Drawing.Point(75, 318);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(75, 32);
            this.btnAddBrand.TabIndex = 44;
            this.btnAddBrand.Text = "Add";
            this.btnAddBrand.UseVisualStyleBackColor = false;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // ManageBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 528);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteBrand);
            this.Controls.Add(this.btnClearBrandRec);
            this.Controls.Add(this.btnBrandHome);
            this.Controls.Add(this.btnEditBrand);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GridBrands);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.txtBrandID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBrand";
            this.Load += new System.EventHandler(this.ManageBrand_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBrands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.TextBox txtBrandID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GridBrands;
        private System.Windows.Forms.Button btnDeleteBrand;
        private System.Windows.Forms.Button btnClearBrandRec;
        private System.Windows.Forms.Button btnBrandHome;
        private System.Windows.Forms.Button btnEditBrand;
        private System.Windows.Forms.Button btnAddBrand;
    }
}