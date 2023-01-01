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
using Accounting.Utility.Convertor;

namespace Main.App
{
    public partial class frm_NewAccounting : Form
    {
        ControlContext DB = new ControlContext();
        public int AccountID = 0;
        public frm_NewAccounting()
        {
            InitializeComponent();
        }

        private void frm_NewAccounting_Load(object sender, EventArgs e)
        {
            lbl_Date.Text = DateConvertor.ToShamsi(DateTime.Now);
            dgv_Customers.AutoGenerateColumns = false;
            dgv_Customers.DataSource = DB.CustomerRepository.GetNameCustomers();
            if (AccountID != 0)
            {
                var Account = DB.AccountingRepository.GetById(AccountID);
                txt_Amount.Text = Account.Amount.ToString();
                txt_Description.Text = Account.Description;
                txt_Name.Text = DB.CustomerRepository.GetCustomerNameByID(Account.CustomerID);
                if (Account.TypeID == 1)
                {
                    rb_Income.Checked = true;
                }
                else
                {
                    rb_Cost.Checked = true;
                }
                this.Text = "ویرایش";
                btn_Save.Text = "ویرایش";
            }
        }

        private void txt_Filter_TextChanged(object sender, EventArgs e)
        {
            dgv_Customers.AutoGenerateColumns = false;
            dgv_Customers.DataSource = DB.CustomerRepository.GetNameCustomers(txt_Filter.Text);
        }

        private void dgv_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Name.Text = dgv_Customers.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("لطفا یک شخص را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Amount.Value < 1)
            {
                MessageBox.Show("لطفا مبلغی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rb_Cost.Checked || rb_Income.Checked)
            {
                Accounting.DataLayer.Accounting accounting = new Accounting.DataLayer.Accounting()
                {
                    Amount = int.Parse(txt_Amount.Value.ToString()),
                    CustomerID = DB.CustomerRepository.GetCustomerIdByName(txt_Name.Text),
                    TypeID = (rb_Income.Checked) ? 1 : 2,
                    DateTitle = DateTime.Now,
                    Description = txt_Description.Text
                };
                if (AccountID == 0)
                {
                    DB.AccountingRepository.Insert(accounting);
                    DB.Save();
                }
                else
                {
                    using (ControlContext DB2 = new ControlContext())
                    {
                        accounting.ID = AccountID;
                        DB2.AccountingRepository.Update(accounting);
                        DB2.Save();
                    }
                }
               
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("لطفا نوع تراکنش را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
