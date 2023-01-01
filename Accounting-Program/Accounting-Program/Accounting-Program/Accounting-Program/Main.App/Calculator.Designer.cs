namespace Main.App
{
    partial class frm_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Calculator));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_PI = new System.Windows.Forms.Button();
            this.btn_Logaritm = new System.Windows.Forms.Button();
            this.btn_DarSad = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_1DivisionX = new System.Windows.Forms.Button();
            this.lbl_Help = new System.Windows.Forms.Label();
            this.btn_click9 = new System.Windows.Forms.Button();
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_click8 = new System.Windows.Forms.Button();
            this.btn_click7 = new System.Windows.Forms.Button();
            this.btn_click4 = new System.Windows.Forms.Button();
            this.btn_click5 = new System.Windows.Forms.Button();
            this.btn_click6 = new System.Windows.Forms.Button();
            this.btn_click3 = new System.Windows.Forms.Button();
            this.btn_Tan = new System.Windows.Forms.Button();
            this.btn_Co = new System.Windows.Forms.Button();
            this.btn_Sin = new System.Windows.Forms.Button();
            this.btn_power2 = new System.Windows.Forms.Button();
            this.btn_Radical = new System.Windows.Forms.Button();
            this.btn_click1 = new System.Windows.Forms.Button();
            this.btn_click2 = new System.Windows.Forms.Button();
            this.btn_Absolutevalue = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_multiplied = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_Negative = new System.Windows.Forms.Button();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.btn_Equal = new System.Windows.Forms.Button();
            this.btn_Review = new System.Windows.Forms.Button();
            this.btn_click0 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Main.App.Properties.Resources._1625055113_38013_gif_url;
            this.pictureBox1.Location = new System.Drawing.Point(330, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.btn_PI);
            this.groupBox1.Controls.Add(this.btn_Logaritm);
            this.groupBox1.Controls.Add(this.btn_DarSad);
            this.groupBox1.Controls.Add(this.txt_Result);
            this.groupBox1.Controls.Add(this.btn_1DivisionX);
            this.groupBox1.Controls.Add(this.lbl_Help);
            this.groupBox1.Controls.Add(this.btn_click9);
            this.groupBox1.Controls.Add(this.btn_00);
            this.groupBox1.Controls.Add(this.btn_click8);
            this.groupBox1.Controls.Add(this.btn_click7);
            this.groupBox1.Controls.Add(this.btn_click4);
            this.groupBox1.Controls.Add(this.btn_click5);
            this.groupBox1.Controls.Add(this.btn_click6);
            this.groupBox1.Controls.Add(this.btn_click3);
            this.groupBox1.Controls.Add(this.btn_Tan);
            this.groupBox1.Controls.Add(this.btn_Co);
            this.groupBox1.Controls.Add(this.btn_Sin);
            this.groupBox1.Controls.Add(this.btn_power2);
            this.groupBox1.Controls.Add(this.btn_Radical);
            this.groupBox1.Controls.Add(this.btn_click1);
            this.groupBox1.Controls.Add(this.btn_click2);
            this.groupBox1.Controls.Add(this.btn_Absolutevalue);
            this.groupBox1.Controls.Add(this.btn_CE);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_multiplied);
            this.groupBox1.Controls.Add(this.btn_Division);
            this.groupBox1.Controls.Add(this.btn_Negative);
            this.groupBox1.Controls.Add(this.btn_Sum);
            this.groupBox1.Controls.Add(this.btn_Equal);
            this.groupBox1.Controls.Add(this.btn_Review);
            this.groupBox1.Controls.Add(this.btn_click0);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(23, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 349);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_PI
            // 
            this.btn_PI.Location = new System.Drawing.Point(7, 162);
            this.btn_PI.Name = "btn_PI";
            this.btn_PI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_PI.Size = new System.Drawing.Size(46, 40);
            this.btn_PI.TabIndex = 6;
            this.btn_PI.Text = "π";
            this.btn_PI.UseVisualStyleBackColor = true;
            this.btn_PI.Click += new System.EventHandler(this.btn_PI_Click);
            // 
            // btn_Logaritm
            // 
            this.btn_Logaritm.Location = new System.Drawing.Point(59, 73);
            this.btn_Logaritm.Name = "btn_Logaritm";
            this.btn_Logaritm.Size = new System.Drawing.Size(86, 37);
            this.btn_Logaritm.TabIndex = 5;
            this.btn_Logaritm.Text = "Log";
            this.btn_Logaritm.UseVisualStyleBackColor = true;
            this.btn_Logaritm.Click += new System.EventHandler(this.btn_Logaritm_Click);
            // 
            // btn_DarSad
            // 
            this.btn_DarSad.Location = new System.Drawing.Point(151, 116);
            this.btn_DarSad.Name = "btn_DarSad";
            this.btn_DarSad.Size = new System.Drawing.Size(40, 40);
            this.btn_DarSad.TabIndex = 4;
            this.btn_DarSad.Text = "%";
            this.btn_DarSad.UseVisualStyleBackColor = true;
            this.btn_DarSad.Click += new System.EventHandler(this.btn_DarSad_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Result.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Result.Location = new System.Drawing.Point(6, 39);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Result.Size = new System.Drawing.Size(272, 29);
            this.txt_Result.TabIndex = 0;
            this.txt_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_1DivisionX
            // 
            this.btn_1DivisionX.Location = new System.Drawing.Point(197, 73);
            this.btn_1DivisionX.Name = "btn_1DivisionX";
            this.btn_1DivisionX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_1DivisionX.Size = new System.Drawing.Size(82, 40);
            this.btn_1DivisionX.TabIndex = 3;
            this.btn_1DivisionX.Text = "1/X";
            this.btn_1DivisionX.UseVisualStyleBackColor = true;
            this.btn_1DivisionX.Click += new System.EventHandler(this.btn_1DivisionX_Click);
            // 
            // lbl_Help
            // 
            this.lbl_Help.AutoSize = true;
            this.lbl_Help.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Help.Location = new System.Drawing.Point(207, 15);
            this.lbl_Help.Name = "lbl_Help";
            this.lbl_Help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Help.Size = new System.Drawing.Size(0, 21);
            this.lbl_Help.TabIndex = 2;
            // 
            // btn_click9
            // 
            this.btn_click9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_click9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_click9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_click9.Location = new System.Drawing.Point(151, 162);
            this.btn_click9.Name = "btn_click9";
            this.btn_click9.Padding = new System.Windows.Forms.Padding(40);
            this.btn_click9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_click9.Size = new System.Drawing.Size(40, 40);
            this.btn_click9.TabIndex = 1;
            this.btn_click9.Text = "9";
            this.btn_click9.UseVisualStyleBackColor = true;
            this.btn_click9.Click += new System.EventHandler(this.btn_click0_Click);
            // 
            // btn_00
            // 
            this.btn_00.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_00.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_00.Location = new System.Drawing.Point(105, 116);
            this.btn_00.Name = "btn_00";
            this.btn_00.Padding = new System.Windows.Forms.Padding(40);
            this.btn_00.Size = new System.Drawing.Size(40, 40);
            this.btn_00.TabIndex = 1;
            this.btn_00.Text = "x^y";
            this.btn_00.UseVisualStyleBackColor = true;
            this.btn_00.Click += new System.EventHandler(this.btn_00_Click_1);
            // 
            // btn_click8
            // 
            this.btn_click8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_click8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_click8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_click8.Location = new System.Drawing.Point(105, 162);
            this.btn_click8.Name = "btn_click8";
            this.btn_click8.Padding = new System.Windows.Forms.Padding(40);
            this.btn_click8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_click8.Size = new System.Drawing.Size(40, 40);
            this.btn_click8.TabIndex = 1;
            this.btn_click8.Text = "8";
            this.btn_click8.UseVisualStyleBackColor = true;
            this.btn_click8.Click += new System.EventHandler(this.btn_click0_Click);
            // 
            // btn_click7
            // 
            this.btn_click7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_click7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_click7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_click7.Location = new System.Drawing.Point(59, 162);
            this.btn_click7.Name = "btn_click7";
            this.btn_click7.Padding = new System.Windows.Forms.Padding(40);
            this.btn_click7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_click7.Size = new System.Drawing.Size(40, 40);
            this.btn_click7.TabIndex = 1;
            this.btn_click7.Text = "7";
            this.btn_click7.UseVisualStyleBackColor = true;
            this.btn_click7.Click += new System.EventHandler(this.btn_click0_Click);
            // 
            // btn_click4
            // 
            this.btn_click4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_click4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_click4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_click4.Location = new System.Drawing.Point(59, 208);
            this.btn_click4.Name = "btn_click4";
            this.btn_click4.Padding = new System.Windows.Forms.Padding(40);
            this.btn_click4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_click4.Size = new System.Drawing.Size(40, 40);
            this.btn_click4.TabIndex = 1;
            this.btn_click4.Text = "4";
            this.btn_click4.UseVisualStyleBackColor = true;
            this.btn_click4.Click += new System.EventHandler(this.btn_click0_Click);
            // 
            // btn_click5
            // 
            this.btn_click5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_click5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_click5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_click5.Location = new System.Drawing.Point(105, 208);
            this.btn_click5.Name = "btn_click5";
            this.btn_click5.Padding = new System.Windows.Forms.Padding(40);
            this.btn_click5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_click5.Size = new System.Drawing.Size(40, 40);
            this.btn_click5.TabIndex = 1;
            this.btn_click5.Text = "5";
            this.btn_click5.UseVisualStyleBackColor = true;
            this.btn_click5.Click += new System.EventHandler(this.btn_click0_Click);
            // 
            // btn_click6
            // 
            this.btn_click6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_click6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_click6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_click6.Location = new System.Drawing.Point(151, 208);
            this.btn_click6.Name = "btn_click6";
            this.btn_click6.Padding = new System.Windows.Forms.Padding(40);
            this.btn_click6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_click6.Size = new System.Drawing.Size(40, 40);
            this.btn_click6.TabIndex = 1;
            this.btn_click6.Text = "6";
            this.btn_click6.UseVisualStyleBackColor = true;
            this.btn_click6.Click += new System.EventHandler(this.btn_click0_Click);
            // 
            // btn_click3
            // 
            this.btn_click3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_click3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_click3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_click3.Location = new System.Drawing.Point(151, 254);
            this.btn_click3.Name = "btn_click3";
            this.btn_click3.Padding = new System.Windows.Forms.Padding(40);
            this.btn_click3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_click3.Size = new System.Drawing.Size(40, 40);
            this.btn_click3.TabIndex = 1;
            this.btn_click3.Text = "3";
            this.btn_click3.UseVisualStyleBackColor = true;
            this.btn_click3.Click += new System.EventHandler(this.btn_click0_Click);
            // 
            // btn_Tan
            // 
            this.btn_Tan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Tan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Tan.Location = new System.Drawing.Point(7, 300);
            this.btn_Tan.Name = "btn_Tan";
            this.btn_Tan.Padding = new System.Windows.Forms.Padding(40);
            this.btn_Tan.Size = new System.Drawing.Size(46, 40);
            this.btn_Tan.TabIndex = 1;
            this.btn_Tan.Text = "Tan";
            this.btn_Tan.UseVisualStyleBackColor = true;
            this.btn_Tan.Click += new System.EventHandler(this.btn_Tan_Click);
            // 
            // btn_Co
            // 
            this.btn_Co.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Co.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Co.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Co.Location = new System.Drawing.Point(6, 254);
            this.btn_Co.Name = "btn_Co";
            this.btn_Co.Padding = new System.Windows.Forms.Padding(40);
            this.btn_Co.Size = new System.Drawing.Size(46, 40);
            this.btn_Co.TabIndex = 1;
            this.btn_Co.Text = "Co";
            this.btn_Co.UseVisualStyleBackColor = true;
            this.btn_Co.Click += new System.EventHandler(this.btn_Co_Click);
            // 
            // btn_Sin
            // 
            this.btn_Sin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Sin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Sin.Location = new System.Drawing.Point(7, 208);
            this.btn_Sin.Name = "btn_Sin";
            this.btn_Sin.Padding = new System.Windows.Forms.Padding(40);
            this.btn_Sin.Size = new System.Drawing.Size(46, 40);
            this.btn_Sin.TabIndex = 1;
            this.btn_Sin.Text = "Sin";
            this.btn_Sin.UseVisualStyleBackColor = true;
            this.btn_Sin.Click += new System.EventHandler(this.btn_Sin_Click);
            // 
            // btn_power2
            // 
            this.btn_power2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_power2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_power2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_power2.Location = new System.Drawing.Point(7, 116);
            this.btn_power2.Name = "btn_power2";
            this.btn_power2.Padding = new System.Windows.Forms.Padding(40);
            this.btn_power2.Size = new System.Drawing.Size(46, 40);
            this.btn_power2.TabIndex = 1;
            this.btn_power2.Text = "2^";
            this.btn_power2.UseVisualStyleBackColor = true;
            this.btn_power2.Click += new System.EventHandler(this.btn_power2_Click);
            // 
            // btn_Radical
            // 
            this.btn_Radical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Radical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Radical.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Radical.Location = new System.Drawing.Point(59, 116);
            this.btn_Radical.Name = "btn_Radical";
            this.btn_Radical.Padding = new System.Windows.Forms.Padding(40);
            this.btn_Radical.Size = new System.Drawing.Size(40, 40);
            this.btn_Radical.TabIndex = 1;
            this.btn_Radical.Text = "√";
            this.btn_Radical.UseVisualStyleBackColor = true;
            this.btn_Radical.Click += new System.EventHandler(this.btn_Radical_Click_1);
            // 
            // btn_click1
            // 
            this.btn_click1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_click1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_click1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_click1.Location = new System.Drawing.Point(59, 254);
            this.btn_click1.Name = "btn_click1";
            this.btn_click1.Padding = new System.Windows.Forms.Padding(40);
            this.btn_click1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_click1.Size = new System.Drawing.Size(40, 40);
            this.btn_click1.TabIndex = 1;
            this.btn_click1.Text = "1";
            this.btn_click1.UseVisualStyleBackColor = true;
            this.btn_click1.Click += new System.EventHandler(this.btn_click0_Click);
            // 
            // btn_click2
            // 
            this.btn_click2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_click2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_click2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_click2.Location = new System.Drawing.Point(105, 254);
            this.btn_click2.Name = "btn_click2";
            this.btn_click2.Padding = new System.Windows.Forms.Padding(40);
            this.btn_click2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_click2.Size = new System.Drawing.Size(40, 40);
            this.btn_click2.TabIndex = 1;
            this.btn_click2.Text = "2";
            this.btn_click2.UseVisualStyleBackColor = true;
            this.btn_click2.Click += new System.EventHandler(this.btn_click0_Click);
            // 
            // btn_Absolutevalue
            // 
            this.btn_Absolutevalue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Absolutevalue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Absolutevalue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Absolutevalue.Location = new System.Drawing.Point(59, 300);
            this.btn_Absolutevalue.Name = "btn_Absolutevalue";
            this.btn_Absolutevalue.Padding = new System.Windows.Forms.Padding(40);
            this.btn_Absolutevalue.Size = new System.Drawing.Size(40, 40);
            this.btn_Absolutevalue.TabIndex = 1;
            this.btn_Absolutevalue.Text = "-/+";
            this.btn_Absolutevalue.UseVisualStyleBackColor = true;
            this.btn_Absolutevalue.Click += new System.EventHandler(this.btn_Absolutevalue_Click_1);
            // 
            // btn_CE
            // 
            this.btn_CE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_CE.Location = new System.Drawing.Point(7, 73);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Padding = new System.Windows.Forms.Padding(40);
            this.btn_CE.Size = new System.Drawing.Size(46, 40);
            this.btn_CE.TabIndex = 1;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Clear.Location = new System.Drawing.Point(151, 73);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Padding = new System.Windows.Forms.Padding(40);
            this.btn_Clear.Size = new System.Drawing.Size(40, 40);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "C";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click_1);
            // 
            // btn_multiplied
            // 
            this.btn_multiplied.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_multiplied.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_multiplied.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_multiplied.Location = new System.Drawing.Point(197, 116);
            this.btn_multiplied.Name = "btn_multiplied";
            this.btn_multiplied.Padding = new System.Windows.Forms.Padding(40);
            this.btn_multiplied.Size = new System.Drawing.Size(82, 40);
            this.btn_multiplied.TabIndex = 1;
            this.btn_multiplied.Text = "*";
            this.btn_multiplied.UseVisualStyleBackColor = true;
            this.btn_multiplied.Click += new System.EventHandler(this.btn_multiplied_Click_1);
            // 
            // btn_Division
            // 
            this.btn_Division.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Division.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Division.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Division.Location = new System.Drawing.Point(197, 162);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Padding = new System.Windows.Forms.Padding(40);
            this.btn_Division.Size = new System.Drawing.Size(82, 40);
            this.btn_Division.TabIndex = 1;
            this.btn_Division.Text = "÷";
            this.btn_Division.UseVisualStyleBackColor = true;
            this.btn_Division.Click += new System.EventHandler(this.btn_Division_Click_1);
            // 
            // btn_Negative
            // 
            this.btn_Negative.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Negative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Negative.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Negative.Location = new System.Drawing.Point(197, 208);
            this.btn_Negative.Name = "btn_Negative";
            this.btn_Negative.Padding = new System.Windows.Forms.Padding(40);
            this.btn_Negative.Size = new System.Drawing.Size(82, 40);
            this.btn_Negative.TabIndex = 1;
            this.btn_Negative.Text = "-";
            this.btn_Negative.UseVisualStyleBackColor = true;
            this.btn_Negative.Click += new System.EventHandler(this.btn_Negative_Click_1);
            // 
            // btn_Sum
            // 
            this.btn_Sum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Sum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Sum.Location = new System.Drawing.Point(197, 254);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Padding = new System.Windows.Forms.Padding(40);
            this.btn_Sum.Size = new System.Drawing.Size(82, 40);
            this.btn_Sum.TabIndex = 1;
            this.btn_Sum.Text = "+";
            this.btn_Sum.UseVisualStyleBackColor = true;
            this.btn_Sum.Click += new System.EventHandler(this.btn_Sum_Click_1);
            // 
            // btn_Equal
            // 
            this.btn_Equal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Equal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Equal.Location = new System.Drawing.Point(197, 300);
            this.btn_Equal.Name = "btn_Equal";
            this.btn_Equal.Padding = new System.Windows.Forms.Padding(40);
            this.btn_Equal.Size = new System.Drawing.Size(82, 40);
            this.btn_Equal.TabIndex = 1;
            this.btn_Equal.Text = "=";
            this.btn_Equal.UseVisualStyleBackColor = true;
            this.btn_Equal.Click += new System.EventHandler(this.btn_Equal_Click_1);
            // 
            // btn_Review
            // 
            this.btn_Review.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Review.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Review.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Review.Location = new System.Drawing.Point(151, 300);
            this.btn_Review.Name = "btn_Review";
            this.btn_Review.Padding = new System.Windows.Forms.Padding(40);
            this.btn_Review.Size = new System.Drawing.Size(40, 40);
            this.btn_Review.TabIndex = 1;
            this.btn_Review.Text = ".";
            this.btn_Review.UseVisualStyleBackColor = true;
            this.btn_Review.Click += new System.EventHandler(this.btn_Review_Click_1);
            // 
            // btn_click0
            // 
            this.btn_click0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_click0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_click0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_click0.Location = new System.Drawing.Point(105, 300);
            this.btn_click0.Name = "btn_click0";
            this.btn_click0.Padding = new System.Windows.Forms.Padding(40);
            this.btn_click0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_click0.Size = new System.Drawing.Size(40, 40);
            this.btn_click0.TabIndex = 1;
            this.btn_click0.Text = "0";
            this.btn_click0.UseVisualStyleBackColor = true;
            this.btn_click0.Click += new System.EventHandler(this.btn_click0_Click);
            // 
            // frm_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Calculator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ماشین حساب";
            this.Load += new System.EventHandler(this.frm_Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Date;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_PI;
        private System.Windows.Forms.Button btn_Logaritm;
        private System.Windows.Forms.Button btn_DarSad;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button btn_1DivisionX;
        private System.Windows.Forms.Label lbl_Help;
        private System.Windows.Forms.Button btn_click9;
        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Button btn_click8;
        private System.Windows.Forms.Button btn_click7;
        private System.Windows.Forms.Button btn_click4;
        private System.Windows.Forms.Button btn_click5;
        private System.Windows.Forms.Button btn_click6;
        private System.Windows.Forms.Button btn_click3;
        private System.Windows.Forms.Button btn_Tan;
        private System.Windows.Forms.Button btn_Co;
        private System.Windows.Forms.Button btn_Sin;
        private System.Windows.Forms.Button btn_power2;
        private System.Windows.Forms.Button btn_Radical;
        private System.Windows.Forms.Button btn_click1;
        private System.Windows.Forms.Button btn_click2;
        private System.Windows.Forms.Button btn_Absolutevalue;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_multiplied;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_Negative;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.Button btn_Equal;
        private System.Windows.Forms.Button btn_Review;
        private System.Windows.Forms.Button btn_click0;
    }
}