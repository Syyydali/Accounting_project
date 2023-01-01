using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Context;
using Accounting.ViewModels.customers;
using Accounting.Utility.Convertor;

namespace Main.App
{
    public partial class frm_Report : Form
    {
        public int TypeID = 0;
        public frm_Report()
        {
            InitializeComponent();
        }

        private void frm_Report_Load(object sender, EventArgs e)
        {
            lbl_Date.Text = DateConvertor.ToShamsi(DateTime.Now);
            using (ControlContext DB = new ControlContext())
            {
                List<List_Customers_View_Model> List = new List<List_Customers_View_Model>();
                List.Add(new List_Customers_View_Model()
                {
                    CustomerID = 0,
                    FullName = "انتخاب کنید"
                });
                List.AddRange(DB.CustomerRepository.GetNameCustomers());
                cb_Customer.DataSource = List;
                cb_Customer.ValueMember = "FullName";
                cb_Customer.ValueMember = "CustomerID";
            }
            if (TypeID == 1)
            {
                this.Text = "گزارش درآمد ها";
            }
            else
            {
                this.Text = "گزارش هزینه ها";
            }
        }
        void Filter()
        {
            using (ControlContext DB = new ControlContext())
            {
                List<Accounting.DataLayer.Accounting> result = new List<Accounting.DataLayer.Accounting>();
                DateTime? StartDate;
                DateTime? EndDate;
                if ((int)cb_Customer.SelectedValue != 0)
                {
                    int CustomerID = int.Parse(cb_Customer.SelectedValue.ToString());
                    result.AddRange(DB.AccountingRepository.Get(a => a.TypeID == TypeID && a.CustomerID == CustomerID));
                }
                else
                {
                    result.AddRange(DB.AccountingRepository.Get(a => a.TypeID == TypeID));
                }

                if (txt_FromDate.Text != "    /  /")
                {
                    StartDate = Convert.ToDateTime(txt_FromDate.Text);
                    StartDate = DateConvertor.ToMiladi(StartDate.Value);
                    result = result.Where(r => r.DateTitle >= StartDate.Value).ToList();
                }
                if (txt_ToDate.Text != "    /  /")
                {
                    EndDate = Convert.ToDateTime(txt_ToDate.Text);
                    EndDate = DateConvertor.ToMiladi(EndDate.Value);
                    result = result.Where(r => r.DateTitle <= EndDate.Value).ToList();
                }

                dgv_Report.Rows.Clear();
                foreach (var accounting in result)
                {
                    string customerName = DB.CustomerRepository.GetCustomerNameByID(accounting.CustomerID);
                    dgv_Report.Rows.Add(accounting.ID, customerName, accounting.Amount, accounting.DateTitle.ToShamsi(),accounting.Description);
                }
            }
        }
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Report.CurrentRow != null)
            {
                int id = int.Parse(dgv_Report.CurrentRow.Cells[0].Value.ToString());
                if (MessageBox.Show("آیا از حذف مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (ControlContext DB = new ControlContext())
                    {
                        DB.AccountingRepository.Delete(id);
                        DB.Save();
                        Filter();
                    }
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Report.CurrentRow != null)
            {
                int id = int.Parse(dgv_Report.CurrentRow.Cells[0].Value.ToString());
                frm_NewAccounting FrmNew = new frm_NewAccounting();
                FrmNew.AccountID = id;
                if (FrmNew.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("CustomerID");
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Description");
            foreach (DataGridViewRow item in dgv_Report.Rows)
            {
                dtPrint.Rows.Add(
                    item.Cells[0].Value.ToString(),
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString()
                    );
            }
            sti_Print.Load(Application.StartupPath + "/Report.mrt");
            sti_Print.RegData("DT", dtPrint);
            sti_Print.Show();
        }

    }
}