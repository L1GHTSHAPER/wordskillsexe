﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show(); 
            Hide();
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            check check = new check();
            check.Show();
            Hide();
        }
    }
}
