namespace InventoryManagement
{
    partial class ManageProducts
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
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.txtProdQty = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.btnClearProdRec = new System.Windows.Forms.Button();
            this.btnProdHome = new System.Windows.Forms.Button();
            this.btnDeleteProd = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.GridProduct = new System.Windows.Forms.DataGridView();
            this.comboBrand = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboVendor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(249, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Products";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.White;
            this.lable1.Location = new System.Drawing.Point(199, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(473, 39);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "MART MANAGEMENT SYSYTEM";
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdPrice.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtProdPrice.Location = new System.Drawing.Point(125, 226);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(198, 27);
            this.txtProdPrice.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(27, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(27, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Product Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(27, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(27, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Product ID";
            // 
            // txtProdID
            // 
            this.txtProdID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdID.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtProdID.Location = new System.Drawing.Point(125, 128);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(198, 27);
            this.txtProdID.TabIndex = 33;
            // 
            // txtProdQty
            // 
            this.txtProdQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdQty.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtProdQty.Location = new System.Drawing.Point(125, 193);
            this.txtProdQty.Name = "txtProdQty";
            this.txtProdQty.Size = new System.Drawing.Size(198, 27);
            this.txtProdQty.TabIndex = 32;
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtProdName.Location = new System.Drawing.Point(125, 161);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(198, 27);
            this.txtProdName.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.BlueViolet;
            this.label7.Location = new System.Drawing.Point(27, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Product Category";
            // 
            // comboCat
            // 
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(125, 286);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(198, 21);
            this.comboCat.TabIndex = 42;
            this.comboCat.SelectedIndexChanged += new System.EventHandler(this.comboCat_SelectedIndexChanged);
            // 
            // btnClearProdRec
            // 
            this.btnClearProdRec.BackColor = System.Drawing.Color.BlueViolet;
            this.btnClearProdRec.FlatAppearance.BorderSize = 0;
            this.btnClearProdRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearProdRec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearProdRec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearProdRec.Location = new System.Drawing.Point(166, 421);
            this.btnClearProdRec.Name = "btnClearProdRec";
            this.btnClearProdRec.Size = new System.Drawing.Size(75, 32);
            this.btnClearProdRec.TabIndex = 47;
            this.btnClearProdRec.Text = "Clear";
            this.btnClearProdRec.UseVisualStyleBackColor = false;
            this.btnClearProdRec.Click += new System.EventHandler(this.btnClearProdRec_Click);
            // 
            // btnProdHome
            // 
            this.btnProdHome.BackColor = System.Drawing.Color.BlueViolet;
            this.btnProdHome.FlatAppearance.BorderSize = 0;
            this.btnProdHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProdHome.Location = new System.Drawing.Point(85, 421);
            this.btnProdHome.Name = "btnProdHome";
            this.btnProdHome.Size = new System.Drawing.Size(75, 32);
            this.btnProdHome.TabIndex = 46;
            this.btnProdHome.Text = "Home";
            this.btnProdHome.UseVisualStyleBackColor = false;
            this.btnProdHome.Click += new System.EventHandler(this.btnProdHome_Click);
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDeleteProd.FlatAppearance.BorderSize = 0;
            this.btnDeleteProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteProd.Location = new System.Drawing.Point(206, 369);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(75, 32);
            this.btnDeleteProd.TabIndex = 45;
            this.btnDeleteProd.Text = "Delete";
            this.btnDeleteProd.UseVisualStyleBackColor = false;
            this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.BackColor = System.Drawing.Color.BlueViolet;
            this.btnEditProd.FlatAppearance.BorderSize = 0;
            this.btnEditProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditProd.Location = new System.Drawing.Point(125, 369);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(75, 32);
            this.btnEditProd.TabIndex = 44;
            this.btnEditProd.Text = "Edit";
            this.btnEditProd.UseVisualStyleBackColor = false;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAddProd.FlatAppearance.BorderSize = 0;
            this.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddProd.Location = new System.Drawing.Point(44, 369);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(75, 32);
            this.btnAddProd.TabIndex = 43;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.BlueViolet;
            this.label9.Location = new System.Drawing.Point(526, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "PRODUCTS LIST";
            // 
            // GridProduct
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.GridProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProduct.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridProduct.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridProduct.Location = new System.Drawing.Point(393, 170);
            this.GridProduct.Name = "GridProduct";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.GridProduct.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProduct.Size = new System.Drawing.Size(443, 328);
            this.GridProduct.TabIndex = 48;
            this.GridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProduct_CellContentClick);
            // 
            // comboBrand
            // 
            this.comboBrand.FormattingEnabled = true;
            this.comboBrand.Location = new System.Drawing.Point(125, 259);
            this.comboBrand.Name = "comboBrand";
            this.comboBrand.Size = new System.Drawing.Size(198, 21);
            this.comboBrand.TabIndex = 50;
            this.comboBrand.SelectedIndexChanged += new System.EventHandler(this.comboBrand_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(27, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Product Brand";
            // 
            // comboVendor
            // 
            this.comboVendor.FormattingEnabled = true;
            this.comboVendor.Location = new System.Drawing.Point(125, 313);
            this.comboVendor.Name = "comboVendor";
            this.comboVendor.Size = new System.Drawing.Size(198, 21);
            this.comboVendor.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.BlueViolet;
            this.label10.Location = new System.Drawing.Point(27, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Product Vendor";
            // 
            // comboSearch
            // 
            this.comboSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearch.ForeColor = System.Drawing.Color.BlueViolet;
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Location = new System.Drawing.Point(530, 142);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(149, 23);
            this.comboSearch.TabIndex = 54;
            this.comboSearch.Tag = "";
            this.comboSearch.Text = "Select Category";
            this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.comboSearch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.BlueViolet;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(676, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.BlueViolet;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Location = new System.Drawing.Point(757, 142);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 57;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 570);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboVendor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBrand);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GridProduct);
            this.Controls.Add(this.btnClearProdRec);
            this.Controls.Add(this.btnProdHome);
            this.Controls.Add(this.btnDeleteProd);
            this.Controls.Add(this.btnEditProd);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.comboCat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProdPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProdQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.TextBox txtProdQty;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboCat;
        private System.Windows.Forms.Button btnClearProdRec;
        private System.Windows.Forms.Button btnProdHome;
        private System.Windows.Forms.Button btnDeleteProd;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView GridProduct;
        private System.Windows.Forms.ComboBox comboBrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboVendor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
    }
}