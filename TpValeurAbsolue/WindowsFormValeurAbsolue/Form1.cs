﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormValeurAbsolue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntCalculer_Click(object sender, EventArgs e)
        {
            this.txtResult.Text =""+ Math.Abs(int.Parse(this.boxSaisie.Text));
        }
    }
}