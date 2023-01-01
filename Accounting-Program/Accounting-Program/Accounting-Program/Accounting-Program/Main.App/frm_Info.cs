using Accounting.Utility.Convertor;
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
    public partial class frm_Info : Form
    {
        public frm_Info()
        {
            InitializeComponent();
        }

        private void frm_Info_Load(object sender, EventArgs e)
        {
            lbl_Date.Text = DateConvertor.ToShamsi(DateTime.Now);
            txt_Info.Text = "ما دو دانشجو هستیم که یک برنامه حسابداری شخصی طراحی کرده ایم، سعی کردیم ظاهر کاربرپسند برنامه را حفظ کرده و از کمترین کد ممکن و با کمترین تکرار کد برنامه خود را بنویسیم، ممنون که از برنامه ی ما استفاده میکنید و اميدوارم بتواند به شما در مدیریت دخل و خرج کمک کند";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
