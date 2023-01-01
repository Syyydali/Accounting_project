using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Context;
using Accounting.DataLayer;
using System.IO;

namespace Main.App
{
    public partial class frm_Add_Edit_Customer : Form
    {
        public int customerID = 0;
        public frm_Add_Edit_Customer()
        {
            InitializeComponent();
        }
        private void btn_ChosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                pbx_CustomerPicture.ImageLocation = OpenFile.FileName;
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Mobile.Text != "")
            {
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(pbx_CustomerPicture.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pbx_CustomerPicture.Image.Save(path+ImageName);
                using (ControlContext DB = new ControlContext())
                {
                    Customers customers = new Customers()
                    {
                        Address = txt_Address.Text,
                        Mobile = txt_Mobile.Text,
                        Email = txt_Email.Text,
                        FullName = txt_Name.Text,
                        CustomerImage = ImageName
                    };
                    if (customerID == 0)
                    {
                        DB.CustomerRepository.InsertCustomer(customers);
                    }
                    else
                    {
                        customers.CustomerID = customerID;
                        DB.CustomerRepository.UpdateCustomer(customers);
                    }
                    DB.Save();
                    DialogResult = DialogResult.OK;
                }
            }
            else if (txt_Name.Text == "")
            {
                MessageBox.Show("لطفا نام را وارد کنید", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("لطفا موبایل را وارد کنید", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void frm_Add_Edit_Customer_Load(object sender, EventArgs e)
        {
            if (customerID != 0)
            {
                this.Text = "ویرایش کاربر";
                string path = Application.StartupPath + "/Images/doc_edit.ico";
                Icon tempIcon = Icon.ExtractAssociatedIcon(path);
                this.Icon = tempIcon;
                btn_Save.Text = "ویرایش";
                using (ControlContext DB = new ControlContext())
                {
                    var customer = DB.CustomerRepository.GetCustomerByID(customerID);
                    txt_Email.Text = customer.Email;
                    txt_Address.Text = customer.Address;
                    txt_Mobile.Text = customer.Mobile;
                    txt_Name.Text = customer.FullName;
                    pbx_CustomerPicture.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
                }
            }

        }

        private void txt_Mobile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
