using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;

namespace Main.App
{
    public partial class frmLogin : Form
    {
        public bool IsEdit = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "" )
            {
                MessageBox.Show("نام کاربری خود را وارد کنید","توجه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("رمز ورود خود را وارد کنید","توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using(ControlContext DB = new ControlContext())
                {
                    if (IsEdit)
                    {
                        var login = DB.LoginRepository.Get().First();
                        login.UserName = txt_Name.Text;
                        login.Password = txt_Password.Text;
                        DB.LoginRepository.Update(login);
                        DB.Save();
                        Application.Restart();
                    }
                    else
                    {
                        if (DB.LoginRepository.Get(l => l.UserName == txt_Name.Text && l.Password == txt_Password.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("کاربری یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }       
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (IsEdit == true)
            {
                this.Text = "تنظیمات ورود به برنامه";
                btn_login.Text = "ذخیره تغیرات";
                using (ControlContext DB = new ControlContext())
                {
                    var login = DB.LoginRepository.Get().First();
                    txt_Name.Text = login.UserName;
                    txt_Password.Text = login.Password;
                }
            }
        }
    }
}
