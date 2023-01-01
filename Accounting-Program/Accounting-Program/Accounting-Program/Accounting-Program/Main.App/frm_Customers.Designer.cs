namespace Main.App
{
    partial class frm_Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customers));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_AddNewCustomer = new System.Windows.Forms.ToolStripButton();
            this.btn_EditCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btn_RefreshCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_Filter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddNewCustomer,
            this.btn_EditCustomer,
            this.toolStripButton1,
            this.btn_RefreshCustomer,
            this.toolStripLabel1,
            this.txt_Filter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 70);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_AddNewCustomer
            // 
            this.btn_AddNewCustomer.Image = global::Main.App.Properties.Resources.doc_add;
            this.btn_AddNewCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_AddNewCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddNewCustomer.Name = "btn_AddNewCustomer";
            this.btn_AddNewCustomer.Size = new System.Drawing.Size(56, 67);
            this.btn_AddNewCustomer.Text = "ثبت کاربر";
            this.btn_AddNewCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AddNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AddNewCustomer.Click += new System.EventHandler(this.btn_AddNewCustomer_Click);
            // 
            // btn_EditCustomer
            // 
            this.btn_EditCustomer.Image = global::Main.App.Properties.Resources.doc_edit;
            this.btn_EditCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_EditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditCustomer.Name = "btn_EditCustomer";
            this.btn_EditCustomer.Size = new System.Drawing.Size(73, 67);
            this.btn_EditCustomer.Text = "ویرایش کاربر";
            this.btn_EditCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_EditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_EditCustomer.Click += new System.EventHandler(this.btn_EditCustomer_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Main.App.Properties.Resources.doc_remove;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 67);
            this.toolStripButton1.Text = "حذف کاربر";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btn_RefreshCustomer
            // 
            this.btn_RefreshCustomer.Image = global::Main.App.Properties.Resources.refresh;
            this.btn_RefreshCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_RefreshCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_RefreshCustomer.Name = "btn_RefreshCustomer";
            this.btn_RefreshCustomer.Size = new System.Drawing.Size(60, 67);
            this.btn_RefreshCustomer.Text = "بروزرسانی";
            this.btn_RefreshCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_RefreshCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_RefreshCustomer.ToolTipText = "بروزرسانی";
            this.btn_RefreshCustomer.Click += new System.EventHandler(this.btn_RefreshCustomer_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::Main.App.Properties.Resources.print_preview;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 67);
            this.toolStripLabel1.Text = "جست و جو:";
            // 
            // txt_Filter
            // 
            this.txt_Filter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Filter.Name = "txt_Filter";
            this.txt_Filter.Size = new System.Drawing.Size(100, 70);
            this.txt_Filter.TextChanged += new System.EventHandler(this.txt_Filter_TextChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 70);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(634, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.AllowUserToAddRows = false;
            this.dgv_Customers.AllowUserToDeleteRows = false;
            this.dgv_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.Full_Name,
            this.Mobile,
            this.Email,
            this.Address});
            this.dgv_Customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Customers.Location = new System.Drawing.Point(0, 95);
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.ReadOnly = true;
            this.dgv_Customers.Size = new System.Drawing.Size(634, 316);
            this.dgv_Customers.TabIndex = 2;
            // 
            // Customer_ID
            // 
            this.Customer_ID.DataPropertyName = "CustomerID";
            this.Customer_ID.HeaderText = "Customer ID";
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            this.Customer_ID.Visible = false;
            // 
            // Full_Name
            // 
            this.Full_Name.DataPropertyName = "FullName";
            this.Full_Name.HeaderText = "نام و نام خانوادگی";
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Date,
            this.lbl_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(118, 17);
            this.lbl_Date.Text = "toolStripStatusLabel1";
            // 
            // lbl_Time
            // 
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(118, 17);
            this.lbl_Time.Text = "toolStripStatusLabel2";
            // 
            // frm_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgv_Customers);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_Customers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست اشخاص";
            this.Load += new System.EventHandler(this.frm_Customers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_AddNewCustomer;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_EditCustomer;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btn_RefreshCustomer;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_Filter;
        private System.Windows.Forms.DataGridView dgv_Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Date;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Time;
    }
}