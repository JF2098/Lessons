using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        string sign = "";
        double val1 = 0;
        double val2 = 0;
        int trackkeypoint = 0;


        public Calculator()
        {
            InitializeComponent();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd1.Text;
        }
        private void cmd2_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd2.Text;
        }
        private void cmd3_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd3.Text;
        }
        private void cmd4_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd4.Text;
        }
        private void cmd5_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd5.Text;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd6.Text;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd7.Text;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd8.Text;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd9.Text;
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd0.Text;
        }

        private void cmdCle_Click(object sender, EventArgs e)
        {
            sign = "";
            txtBox.Text = "";
            val1 = 0;
            val2 = 0;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdSub_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdMul_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdDiv_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void cmdEqu_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(txtBox.Text);
            double result;

            if (sign == "+")
            {
                result = val1 + val2;
                txtBox.Text = result.ToString();
            }
            else if (sign == "-")
            {
                result = val1 - val2;
                txtBox.Text = result.ToString();
            }
            else if (sign == "*")
            {
                result = val1 * val2;
                txtBox.Text = result.ToString();
            }
            else if (sign == "/")
            {
                result = val1 / val2;
                txtBox.Text = result.ToString();
            }
            else
            {
                txtBox.Text = "Invalid input!";
            }
        }

        private void cmdCos_Click(object sender, EventArgs e)
        {
            txtBox.Text = Math.Cos(double.Parse(txtBox.Text)).ToString();
        }

        private void cmdSin_Click(object sender, EventArgs e)
        {
            txtBox.Text = Math.Sin(double.Parse(txtBox.Text)).ToString();
        }

        private void cmdTan_Click(object sender, EventArgs e)
        {
            txtBox.Text = Math.Tan(double.Parse(txtBox.Text)).ToString();
        }

        private void cmdSqrt_Click(object sender, EventArgs e)
        {
            txtBox.Text = Math.Sqrt(double.Parse(txtBox.Text)).ToString();
        }

        private void cmdSquare_Click(object sender, EventArgs e)
        {
            txtBox.Text = Math.Pow(double.Parse(txtBox.Text), 2).ToString();
        }

        private void txtbox_KeyPress(object sender, KeyPressEventArgs e)

        {

            int keycode;

            keycode = e.KeyChar;

            //accept only number from key 0 to key 9, key back, and key dot

            if (keycode >= 48 && keycode <= 57 || keycode == 8 || keycode == 32 || keycode == 46)

            {

                //key dot allowed only one time

                if (keycode == 46) ++trackkeypoint;

                if (trackkeypoint > 1) { e.Handled = true; --trackkeypoint; }

            }

            else e.Handled = true;

        }
        private void txtbox_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtbox_TextChanged(object sender, EventArgs e)

        {
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
