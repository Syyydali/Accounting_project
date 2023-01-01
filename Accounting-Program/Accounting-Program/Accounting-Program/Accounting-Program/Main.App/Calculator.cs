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
    public partial class frm_Calculator : Form
    {
        float Number1, Number2, Number3;
        string Amalgar;
        bool lblce = false;
        bool num1Ornum2 = false;

        public frm_Calculator()
        {
            InitializeComponent();
        }
        private void btn_Sum_Click(object sender, EventArgs e)
        {
            lbl_Help.Text = txt_Result.Text;
            Number1 = float.Parse(txt_Result.Text);
            lbl_Help.Text += "+";
            txt_Result.Text = "";
            Amalgar = "+";
        }
        private void btn_Negative_Click(object sender, EventArgs e)
        {
            lbl_Help.Text = txt_Result.Text;
            Number1 = float.Parse(txt_Result.Text);
            lbl_Help.Text += "-";
            txt_Result.Text = "";
            Amalgar = "-";
        }
        private void btn_Division_Click(object sender, EventArgs e)
        {
            lbl_Help.Text = txt_Result.Text;
            Number1 = float.Parse(txt_Result.Text);
            lbl_Help.Text += "÷";
            txt_Result.Text = "";
            Amalgar = "/";
        }
        private void btn_multiplied_Click(object sender, EventArgs e)
        {
            lbl_Help.Text = txt_Result.Text;
            Number1 = float.Parse(txt_Result.Text);
            lbl_Help.Text += "*";
            txt_Result.Text = "";
            Amalgar = "*";
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_Help.Text = "";
            txt_Result.Text = "";
        }
        private void btn_00_Click(object sender, EventArgs e)
        {
            lbl_Help.Text = txt_Result.Text;
            Number1 = float.Parse(txt_Result.Text);
            lbl_Help.Text += "^";
            txt_Result.Text = "";
            Amalgar = "^";

        }
        private void btn_Radical_Click(object sender, EventArgs e)
        {
            double number;
            Number1 = float.Parse(txt_Result.Text);
            number = Number1;
            Number1 = (float)Math.Sqrt(number);
            lblce = true;
            lbl_Help.Text += "√" + txt_Result.Text + "=";
            txt_Result.Text = Number1.ToString();
        }
        private void frm_Calculator_Load(object sender, EventArgs e)
        {
            lbl_Date.Text = DateConvertor.ToShamsi(DateTime.Now);
        }

        private void btn_Equal_Click_1(object sender, EventArgs e)
        {
            Number2 = float.Parse(txt_Result.Text);
            switch (Amalgar)
            {
                case "+":
                    Number3 = Number1 + Number2;
                    break;
                case "-":
                    Number3 = Number1 - Number2;
                    break;
                case "*":
                    Number3 = Number1 * Number2;
                    break;
                case "/":
                    Number3 = Number1 / Number2;
                    break;
                case "^":
                    Number3 = (float)Math.Pow(Number1, Number2);
                    break;
            }
            lblce = true;
            lbl_Help.Text += txt_Result.Text + "=";
            txt_Result.Text = Number3.ToString();
        }

        private void btn_Sum_Click_1(object sender, EventArgs e)
        {
            lbl_Help.Text = txt_Result.Text;
            Number1 = float.Parse(txt_Result.Text);
            lbl_Help.Text += "+";
            txt_Result.Text = "";
            Amalgar = "+";
        }

        private void btn_Negative_Click_1(object sender, EventArgs e)
        {
            lbl_Help.Text = txt_Result.Text;
            Number1 = float.Parse(txt_Result.Text);
            lbl_Help.Text += "-";
            txt_Result.Text = "";
            Amalgar = "-";
        }

        private void btn_Division_Click_1(object sender, EventArgs e)
        {
            lbl_Help.Text = txt_Result.Text;
            Number1 = float.Parse(txt_Result.Text);
            lbl_Help.Text += "÷";
            txt_Result.Text = "";
            Amalgar = "/";
        }

        private void btn_multiplied_Click_1(object sender, EventArgs e)
        {
            lbl_Help.Text = txt_Result.Text;
            Number1 = float.Parse(txt_Result.Text);
            lbl_Help.Text += "*";
            txt_Result.Text = "";
            Amalgar = "*";
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            lbl_Help.Text = "";
            txt_Result.Text = "";
        }

        private void btn_00_Click_1(object sender, EventArgs e)
        {
            lbl_Help.Text = txt_Result.Text;
            Number1 = float.Parse(txt_Result.Text);
            lbl_Help.Text += "^";
            txt_Result.Text = "";
            Amalgar = "^";
        }

        private void btn_Radical_Click_1(object sender, EventArgs e)
        {
            double number;
            Number1 = float.Parse(txt_Result.Text);
            number = Number1;
            Number1 = (float)Math.Sqrt(number);
            lblce = true;
            lbl_Help.Text += "√" + txt_Result.Text + "=";
            txt_Result.Text = Number1.ToString();
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            if (lblce)
            {
                lbl_Help.Text = "";
                txt_Result.Text = "";
            }
            else
            {
                txt_Result.Text = "";
            }
        }

        private void btn_Sin_Click(object sender, EventArgs e)
        {
            Number1 = float.Parse(txt_Result.Text);
            Number2 = (float)Math.Sin(Number1);
            lblce = true;
            lbl_Help.Text += "Sin(" + txt_Result.Text + ")=";
            txt_Result.Text = Number2.ToString();
        }

        private void btn_1DivisionX_Click(object sender, EventArgs e)
        {
            Number1 = float.Parse(txt_Result.Text);
            Number2 = 1 / Number1;
            lblce = true;
            lbl_Help.Text += "1/(" + txt_Result.Text + ")=";
            txt_Result.Text = Number2.ToString();
        }

        private void btn_Co_Click(object sender, EventArgs e)
        {
            Number1 = float.Parse(txt_Result.Text);
            Number2 = (float)Math.Cos(Number1);
            lblce = true;
            lbl_Help.Text += "Cos(" + txt_Result.Text + ")=";
            txt_Result.Text = Number2.ToString();
        }

        private void btn_Tan_Click(object sender, EventArgs e)
        {
            Number1 = float.Parse(txt_Result.Text);
            Number2 = (float)Math.Tan(Number1);
            lblce = true;
            lbl_Help.Text += "Tan(" + txt_Result.Text + ")=";
            txt_Result.Text = Number2.ToString();
        }

        private void btn_DarSad_Click(object sender, EventArgs e)
        {
            Number1 = float.Parse(txt_Result.Text);
            Number2 = Number1 / 100;
            lblce = true;
            lbl_Help.Text += txt_Result.Text + "/ 100=";
            txt_Result.Text = Number2.ToString();
        }

        private void btn_Logaritm_Click(object sender, EventArgs e)
        {
            Number1 = float.Parse(txt_Result.Text);
            Number2 = (float)Math.Log10(Number1);
            lblce = true;
            lbl_Help.Text += "Log(" + txt_Result.Text + ")=";
            txt_Result.Text = Number2.ToString();
        }

        private void btn_PI_Click(object sender, EventArgs e)
        {
            lblce = true;
            if (lblce)
            {
                lbl_Help.Text = "";
                txt_Result.Text = 3.14.ToString();
                lblce = false;
            }
        }

        private void btn_power2_Click(object sender, EventArgs e)
        {
            Number1 = float.Parse(txt_Result.Text);
            Number1 = Number1 * Number1;
            lblce = true;
            lbl_Help.Text += "sqr(" + txt_Result.Text + ")=";
            txt_Result.Text = Number1.ToString();
        }

        private void btn_Absolutevalue_Click_1(object sender, EventArgs e)
        {
            Number1 = float.Parse(txt_Result.Text);
            Number1 = Number1 * -1;
            txt_Result.Text = Number1.ToString();
        }

        private void btn_Review_Click_1(object sender, EventArgs e)
        {
            if (num1Ornum2 == false)
            {
                Number1 = float.Parse(txt_Result.Text);
                txt_Result.Text = Number1 + "/";
                num1Ornum2 = true;
            }
            else
            {
                Number2 = float.Parse(txt_Result.Text);
                txt_Result.Text = Number2 + "/";
                num1Ornum2 = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void btn_click0_Click(object sender, EventArgs e)
        {
            Button GiveSender = (Button)sender;
            txt_Result.Text += GiveSender.Text;
            if (lblce)
            {
                //lbl_Help.Text = "";
                txt_Result.Text = GiveSender.Text;
                lblce = false;
            }
        }

       
       
    }
}
