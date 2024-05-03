namespace InventoryManagement
{
    partial class ManageVendors
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtVenContact = new System.Windows.Forms.TextBox();
            this.btnDeleteVen = new System.Windows.Forms.Button();
            this.btnClearVenRec = new System.Windows.Forms.Button();
            this.txtVenName = new System.Windows.Forms.TextBox();
            this.btnVenHome = new System.Windows.Forms.Button();
            this.txtVenID = new System.Windows.Forms.TextBox();
            this.btnEditVen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddVen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GridVendors = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVendors)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Vendors";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.White;
            this.lable1.Location = new System.Drawing.Point(197, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(473, 39);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "MART MANAGEMENT SYSYTEM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(39, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Vendor Contact";
            // 
            // txtVenContact
            // 
            this.txtVenContact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenContact.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtVenContact.Location = new System.Drawing.Point(137, 243);
            this.txtVenContact.Name = "txtVenContact";
            this.txtVenContact.Size = new System.Drawing.Size(198, 27);
            this.txtVenContact.TabIndex = 57;
            // 
            // btnDeleteVen
            // 
            this.btnDeleteVen.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDeleteVen.FlatAppearance.BorderSize = 0;
            this.btnDeleteVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVen.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteVen.Location = new System.Drawing.Point(260, 330);
            this.btnDeleteVen.Name = "btnDeleteVen";
            this.btnDeleteVen.Size = new System.Drawing.Size(75, 32);
            this.btnDeleteVen.TabIndex = 54;
            this.btnDeleteVen.Text = "Delete";
            this.btnDeleteVen.UseVisualStyleBackColor = false;
            this.btnDeleteVen.Click += new System.EventHandler(this.btnDeleteVen_Click);
            // 
            // btnClearVenRec
            // 
            this.btnClearVenRec.BackColor = System.Drawing.Color.BlueViolet;
            this.btnClearVenRec.FlatAppearance.BorderSize = 0;
            this.btnClearVenRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearVenRec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearVenRec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearVenRec.Location = new System.Drawing.Point(218, 382);
            this.btnClearVenRec.Name = "btnClearVenRec";
            this.btnClearVenRec.Size = new System.Drawing.Size(75, 32);
            this.btnClearVenRec.TabIndex = 56;
            this.btnClearVenRec.Text = "Clear";
            this.btnClearVenRec.UseVisualStyleBackColor = false;
            this.btnClearVenRec.Click += new System.EventHandler(this.btnClearVenRec_Click);
            // 
            // txtVenName
            // 
            this.txtVenName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenName.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtVenName.Location = new System.Drawing.Point(137, 210);
            this.txtVenName.Name = "txtVenName";
            this.txtVenName.Size = new System.Drawing.Size(198, 27);
            this.txtVenName.TabIndex = 46;
            // 
            // btnVenHome
            // 
            this.btnVenHome.BackColor = System.Drawing.Color.BlueViolet;
            this.btnVenHome.FlatAppearance.BorderSize = 0;
            this.btnVenHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVenHome.Location = new System.Drawing.Point(137, 382);
            this.btnVenHome.Name = "btnVenHome";
            this.btnVenHome.Size = new System.Drawing.Size(75, 32);
            this.btnVenHome.TabIndex = 55;
            this.btnVenHome.Text = "Home";
            this.btnVenHome.UseVisualStyleBackColor = false;
            this.btnVenHome.Click += new System.EventHandler(this.btnVenHome_Click);
            // 
            // txtVenID
            // 
            this.txtVenID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenID.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtVenID.Location = new System.Drawing.Point(137, 177);
            this.txtVenID.Name = "txtVenID";
            this.txtVenID.Size = new System.Drawing.Size(198, 27);
            this.txtVenID.TabIndex = 47;
            // 
            // btnEditVen
            // 
            this.btnEditVen.BackColor = System.Drawing.Color.BlueViolet;
            this.btnEditVen.FlatAppearance.BorderSize = 0;
            this.btnEditVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditVen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVen.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditVen.Location = new System.Drawing.Point(179, 330);
            this.btnEditVen.Name = "btnEditVen";
            this.btnEditVen.Size = new System.Drawing.Size(75, 32);
            this.btnEditVen.TabIndex = 53;
            this.btnEditVen.Text = "Edit";
            this.btnEditVen.UseVisualStyleBackColor = false;
            this.btnEditVen.Click += new System.EventHandler(this.btnEditVen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(39, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Vendor ID";
            // 
            // btnAddVen
            // 
            this.btnAddVen.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAddVen.FlatAppearance.BorderSize = 0;
            this.btnAddVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVen.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddVen.Location = new System.Drawing.Point(98, 330);
            this.btnAddVen.Name = "btnAddVen";
            this.btnAddVen.Size = new System.Drawing.Size(75, 32);
            this.btnAddVen.TabIndex = 52;
            this.btnAddVen.Text = "Add";
            this.btnAddVen.UseVisualStyleBackColor = false;
            this.btnAddVen.Click += new System.EventHandler(this.btnAddVen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(39, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Vendor Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(554, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 24);
            this.label8.TabIndex = 51;
            this.label8.Text = "VENDORS LIST";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // GridVendors
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.GridVendors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridVendors.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVendors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVendors.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridVendors.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridVendors.Location = new System.Drawing.Point(459, 151);
            this.GridVendors.Name = "GridVendors";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.GridVendors.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridVendors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridVendors.Size = new System.Drawing.Size(344, 350);
            this.GridVendors.TabIndex = 50;
            this.GridVendors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVendors_CellContentClick);
            // 
            // ManageVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 528);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVenContact);
            this.Controls.Add(this.btnDeleteVen);
            this.Controls.Add(this.btnClearVenRec);
            this.Controls.Add(this.txtVenName);
            this.Controls.Add(this.btnVenHome);
            this.Controls.Add(this.txtVenID);
            this.Controls.Add(this.btnEditVen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddVen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GridVendors);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageVendors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageVendors";
            this.Load += new System.EventHandler(this.ManageVendors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVendors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVenContact;
        private System.Windows.Forms.Button btnDeleteVen;
        private System.Windows.Forms.Button btnClearVenRec;
        private System.Windows.Forms.TextBox txtVenName;
        private System.Windows.Forms.Button btnVenHome;
        private System.Windows.Forms.TextBox txtVenID;
        private System.Windows.Forms.Button btnEditVen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddVen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GridVendors;
    }
}