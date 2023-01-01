namespace Main.App
{
    partial class frm_NewAccounting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NewAccounting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Filter = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.NumericUpDown();
            this.rb_Cost = new System.Windows.Forms.RadioButton();
            this.rb_Income = new System.Windows.Forms.RadioButton();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Amount)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Customers);
            this.groupBox1.Controls.Add(this.txt_Filter);
            this.groupBox1.Location = new System.Drawing.Point(5, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(264, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اشخاص";
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.AllowUserToAddRows = false;
            this.dgv_Customers.AllowUserToDeleteRows = false;
            this.dgv_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv_Customers.Location = new System.Drawing.Point(10, 76);
            this.dgv_Customers.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.ReadOnly = true;
            this.dgv_Customers.Size = new System.Drawing.Size(241, 304);
            this.dgv_Customers.TabIndex = 2;
            this.dgv_Customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customers_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FullName";
            this.Column1.HeaderText = "نام شخص";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txt_Filter
            // 
            this.txt_Filter.Location = new System.Drawing.Point(10, 32);
            this.txt_Filter.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Filter.Name = "txt_Filter";
            this.txt_Filter.Size = new System.Drawing.Size(241, 29);
            this.txt_Filter.TabIndex = 1;
            this.txt_Filter.TextChanged += new System.EventHandler(this.txt_Filter_TextChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Location = new System.Drawing.Point(281, 349);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(101, 30);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "ثبت تراکنش";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(281, 214);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(341, 114);
            this.txt_Description.TabIndex = 16;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(322, 135);
            this.txt_Amount.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(300, 29);
            this.txt_Amount.TabIndex = 15;
            // 
            // rb_Cost
            // 
            this.rb_Cost.AutoSize = true;
            this.rb_Cost.Location = new System.Drawing.Point(465, 77);
            this.rb_Cost.Name = "rb_Cost";
            this.rb_Cost.Size = new System.Drawing.Size(63, 25);
            this.rb_Cost.TabIndex = 14;
            this.rb_Cost.TabStop = true;
            this.rb_Cost.Text = "هزینه";
            this.rb_Cost.UseVisualStyleBackColor = true;
            // 
            // rb_Income
            // 
            this.rb_Income.AutoSize = true;
            this.rb_Income.Location = new System.Drawing.Point(371, 77);
            this.rb_Income.Name = "rb_Income";
            this.rb_Income.Size = new System.Drawing.Size(60, 25);
            this.rb_Income.TabIndex = 13;
            this.rb_Income.TabStop = true;
            this.rb_Income.Text = "درآمد";
            this.rb_Income.UseVisualStyleBackColor = true;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(367, 19);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(255, 29);
            this.txt_Name.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "توضیحات:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "مبلغ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "نوع تراکنش:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "طرف حساب:";
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
            this.statusStrip1.TabIndex = 18;
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
            // frm_NewAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.rb_Cost);
            this.Controls.Add(this.rb_Income);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_NewAccounting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.frm_NewAccounting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Amount)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Customers;
        private System.Windows.Forms.TextBox txt_Filter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.NumericUpDown txt_Amount;
        private System.Windows.Forms.RadioButton rb_Cost;
        private System.Windows.Forms.RadioButton rb_Income;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Date;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Time;
    }
}