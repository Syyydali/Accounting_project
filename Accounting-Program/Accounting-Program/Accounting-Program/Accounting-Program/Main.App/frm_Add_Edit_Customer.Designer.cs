namespace Main.App
{
    partial class frm_Add_Edit_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Edit_Customer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Mobile = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbx_CustomerPicture = new System.Windows.Forms.PictureBox();
            this.btn_ChosePicture = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CustomerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_Mobile);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات شخص";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(19, 133);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(276, 82);
            this.txt_Address.TabIndex = 7;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(19, 98);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(276, 29);
            this.txt_Email.TabIndex = 6;
            // 
            // txt_Mobile
            // 
            this.txt_Mobile.Location = new System.Drawing.Point(19, 62);
            this.txt_Mobile.Name = "txt_Mobile";
            this.txt_Mobile.Size = new System.Drawing.Size(276, 29);
            this.txt_Mobile.TabIndex = 5;
            this.txt_Mobile.TextChanged += new System.EventHandler(this.txt_Mobile_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(19, 25);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(276, 29);
            this.txt_Name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "آدرس:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "ایمیل:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "موبایل:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbx_CustomerPicture);
            this.groupBox2.Controls.Add(this.btn_ChosePicture);
            this.groupBox2.Location = new System.Drawing.Point(372, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 224);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصویر شخص";
            // 
            // pbx_CustomerPicture
            // 
            this.pbx_CustomerPicture.ErrorImage = global::Main.App.Properties.Resources.close;
            this.pbx_CustomerPicture.Image = global::Main.App.Properties.Resources.images;
            this.pbx_CustomerPicture.Location = new System.Drawing.Point(6, 28);
            this.pbx_CustomerPicture.Name = "pbx_CustomerPicture";
            this.pbx_CustomerPicture.Size = new System.Drawing.Size(138, 138);
            this.pbx_CustomerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_CustomerPicture.TabIndex = 2;
            this.pbx_CustomerPicture.TabStop = false;
            // 
            // btn_ChosePicture
            // 
            this.btn_ChosePicture.Location = new System.Drawing.Point(16, 180);
            this.btn_ChosePicture.Name = "btn_ChosePicture";
            this.btn_ChosePicture.Size = new System.Drawing.Size(117, 30);
            this.btn_ChosePicture.TabIndex = 1;
            this.btn_ChosePicture.Text = "انتخاب تصویر";
            this.btn_ChosePicture.UseVisualStyleBackColor = true;
            this.btn_ChosePicture.Click += new System.EventHandler(this.btn_ChosePicture_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(24, 256);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(111, 29);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "ثبت اطلاعات";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Edit_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Add_Edit_Customer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت کاربر جدید";
            this.Load += new System.EventHandler(this.frm_Add_Edit_Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CustomerPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Mobile;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ChosePicture;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.PictureBox pbx_CustomerPicture;
    }
}