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
using Accounting.Utility.Convertor;

namespace Main.App
{
    public partial class frm_Customers : Form
    {
        public frm_Customers()
        {
            InitializeComponent();
        }

        private void frm_Customers_Load(object sender, EventArgs e)
        {
            lbl_Date.Text = DateConvertor.ToShamsi(DateTime.Now);
            BindGrid();
        }

        void BindGrid()
        {
            using (ControlContext DB = new ControlContext())
            {
                dgv_Customers.AutoGenerateColumns = false;
                dgv_Customers.DataSource = DB.CustomerRepository.GetAllCustomers();
            }
        }

        private void btn_RefreshCustomer_Click(object sender, EventArgs e)
        {
            txt_Filter.Text = null;
            BindGrid();
        }

        private void txt_Filter_TextChanged(object sender, EventArgs e)
        {
            using(ControlContext DB = new ControlContext())
            {
                dgv_Customers.DataSource = DB.CustomerRepository.GetCustomersByFilter(txt_Filter.Text);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgv_Customers.CurrentRow != null)
            {
                using (ControlContext DB = new ControlContext())
                {
                    string Name = dgv_Customers.CurrentRow.Cells[1].Value.ToString();
                    if (MessageBox.Show($"آیا از حذف {Name} مطمعن هستید؟","توجه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                    {
                        int customerID = int.Parse(dgv_Customers.CurrentRow.Cells[0].Value.ToString());
                        DB.CustomerRepository.DeleteCustomer(customerID);
                        DB.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا یک شخص را انتخاب کنید");
            }
        }
        private void btn_AddNewCustomer_Click(object sender, EventArgs e)
        {
            frm_Add_Edit_Customer frmAdd = new frm_Add_Edit_Customer();
            if(frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btn_EditCustomer_Click(object sender, EventArgs e)
        {
            if (dgv_Customers.CurrentRow != null)
            {
                int customerId = int.Parse(dgv_Customers.CurrentRow.Cells[0].Value.ToString());
                frm_Add_Edit_Customer frmAddorEdit = new frm_Add_Edit_Customer();
                frmAddorEdit.customerID = customerId;
                if (frmAddorEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
