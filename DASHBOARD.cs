﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resorthub
{
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OPTION n = new OPTION();
            n.Show();
            this.Hide();
        }
    }
}
