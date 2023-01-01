using Accounting.Utility.Convertor;
using Main.App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            frm_Customers frmCustomers = new frm_Customers();
            frmCustomers.ShowDialog();
        }

        private void btn_NewAccounting_Click(object sender, EventArgs e)
        {
            frm_NewAccounting frm_NewAccounting = new frm_NewAccounting();
            frm_NewAccounting.ShowDialog();
        }

        private void btn_ReportCost_Click(object sender, EventArgs e)
        {
            frm_Report frmReport = new frm_Report();
            frmReport.TypeID = 2;
            frmReport.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("از خروج از برنامه مطمعن هستید", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_ReportIncom_Click(object sender, EventArgs e)
        {
            frm_Report frmReport = new frm_Report();
            frmReport.TypeID = 1;
            frmReport.ShowDialog();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            frm_Info frmInfo = new frm_Info();
            frmInfo.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Date.Text = DateConvertor.ToShamsi(DateTime.Now);
        }

        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            frm_Calculator frmCalculator = new frm_Calculator();
            frmCalculator.ShowDialog();
        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            if(frmLogin.ShowDialog()==DialogResult.OK)
            {
                lbl_Date.Text = DateConvertor.ToShamsi(DateTime.Now);
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btn_EditLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.IsEdit = true;
            frmLogin.ShowDialog();
        }

        private void تماصلیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.BackColor = Color.DarkCyan;
            toolStrip2.BackColor = Color.DarkCyan;
            this.BackColor = Color.DarkCyan;
            this.ForeColor = Color.White;
            pictureBox1.Image = Resources.Accounting_Software_gif;
        }

        private void تماشکالسهبعدیهندسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.BackColor = Color.Black;
            toolStrip2.BackColor = Color.Black;
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            pictureBox1.Image = Resources._62865b92ede0499c979f108f61201902;
        }

        private void تمکامپیوتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.BackColor = Color.DarkGray;
            toolStrip2.BackColor = Color.DarkGray;
            this.BackColor = Color.DarkGray;
            this.ForeColor = Color.White;
            pictureBox1.Image = Resources.video_and_chat_in_computer_gif_by_dibakar_jana_on_dribbble;
        }

        private void مشکیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.BackColor = Color.DarkGray;
            toolStrip2.BackColor = Color.DarkGray;
            this.BackColor = Color.DarkGray;
            this.ForeColor = Color.White;
            pictureBox1.Image = Resources.a177dfc84703c31afa0d501ccf43fe4f;
        }

        private void سفیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.BackColor = Color.White;
            toolStrip2.BackColor = Color.White;
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            pictureBox1.Image = Resources._2220ca03bc1fdd8b412db3e448911302;
        }
    }
}
