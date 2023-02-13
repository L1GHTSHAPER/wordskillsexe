using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class regsiter2 : Form
    {
        int sum = 0;
        public regsiter2()
        {
            InitializeComponent();
            Total.Text= "0";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {sum += 145; Total.Text = sum+""; }
            else { sum -= 145; Total.Text = sum + ""; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { sum += 75; Total.Text = sum + ""; }
            else { sum -= 75; Total.Text = sum + ""; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { sum += 20; Total.Text = sum + ""; }
            else { sum -= 20; Total.Text = sum + ""; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked) { sum += 0; Total.Text = sum + ""; }
            else { sum -= 0; Total.Text = sum + ""; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked) { sum += 20; Total.Text = sum + ""; }
            else { sum -= 20; Total.Text = sum + ""; }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked) { sum += 45; Total.Text = sum + ""; }
            else { sum -= 45; Total.Text = sum + ""; }
        }
    }
}
