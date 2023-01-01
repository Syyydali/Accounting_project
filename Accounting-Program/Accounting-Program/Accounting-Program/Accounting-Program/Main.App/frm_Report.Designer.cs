namespace Main.App
{
    partial class frm_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Report));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.btn_Print = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ToDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FromDate = new System.Windows.Forms.MaskedTextBox();
            this.cb_Customer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Report = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.sti_Print = new Stimulsoft.Report.StiReport();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Edit,
            this.btn_Delete,
            this.btn_Refresh,
            this.btn_Print});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 70);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Image = global::Main.App.Properties.Resources.doc_edit;
            this.btn_Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(52, 67);
            this.btn_Edit.Text = "ویرایش";
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::Main.App.Properties.Resources.doc_remove;
            this.btn_Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(52, 67);
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = global::Main.App.Properties.Resources.refresh;
            this.btn_Refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(60, 67);
            this.btn_Refresh.Text = "بروزرسانی";
            this.btn_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Image = global::Main.App.Properties.Resources.printer;
            this.btn_Print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(52, 67);
            this.btn_Print.Text = "چاپ";
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Filter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ToDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_FromDate);
            this.groupBox1.Controls.Add(this.cb_Customer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جست و جو";
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Filter.Location = new System.Drawing.Point(509, 57);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(101, 30);
            this.btn_Filter.TabIndex = 2;
            this.btn_Filter.Text = "انجام";
            this.btn_Filter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "تا تاریخ:";
            // 
            // txt_ToDate
            // 
            this.txt_ToDate.Location = new System.Drawing.Point(6, 25);
            this.txt_ToDate.Mask = "0000/00/00";
            this.txt_ToDate.Name = "txt_ToDate";
            this.txt_ToDate.Size = new System.Drawing.Size(121, 29);
            this.txt_ToDate.TabIndex = 9;
            this.txt_ToDate.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "طرف حساب:";
            // 
            // txt_FromDate
            // 
            this.txt_FromDate.Location = new System.Drawing.Point(200, 25);
            this.txt_FromDate.Mask = "0000/00/00";
            this.txt_FromDate.Name = "txt_FromDate";
            this.txt_FromDate.Size = new System.Drawing.Size(121, 29);
            this.txt_FromDate.TabIndex = 10;
            this.txt_FromDate.ValidatingType = typeof(System.DateTime);
            // 
            // cb_Customer
            // 
            this.cb_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Customer.FormattingEnabled = true;
            this.cb_Customer.Location = new System.Drawing.Point(393, 25);
            this.cb_Customer.Name = "cb_Customer";
            this.cb_Customer.Size = new System.Drawing.Size(121, 29);
            this.cb_Customer.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "از تاریخ:";
            // 
            // dgv_Report
            // 
            this.dgv_Report.AllowUserToAddRows = false;
            this.dgv_Report.AllowUserToDeleteRows = false;
            this.dgv_Report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_Report.Location = new System.Drawing.Point(12, 180);
            this.dgv_Report.Name = "dgv_Report";
            this.dgv_Report.ReadOnly = true;
            this.dgv_Report.Size = new System.Drawing.Size(610, 227);
            this.dgv_Report.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerID";
            this.Column2.HeaderText = "طرف حساب";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Amount";
            this.Column3.HeaderText = "مبلغ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DateTitle";
            this.Column4.HeaderText = "تاریخ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Description";
            this.Column5.HeaderText = "توضیحات";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            // sti_Print
            // 
            this.sti_Print.CookieContainer = null;
            this.sti_Print.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.sti_Print.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.sti_Print.ReportAlias = "Report";
            this.sti_Print.ReportGuid = "b211e910de5b4ccdb4ce5aaeae9b2728";
            this.sti_Print.ReportName = "Report";
            this.sti_Print.ReportSource = null;
            this.sti_Print.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.sti_Print.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.sti_Print.UseProgressInThread = false;
            // 
            // frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgv_Report);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش هزینه ها";
            this.Load += new System.EventHandler(this.frm_Report_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Edit;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.ToolStripButton btn_Refresh;
        private System.Windows.Forms.ToolStripButton btn_Print;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Customer;
        private System.Windows.Forms.MaskedTextBox txt_ToDate;
        private System.Windows.Forms.MaskedTextBox txt_FromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.DataGridView dgv_Report;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Date;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Time;
        private Stimulsoft.Report.StiReport sti_Print;
    }
}