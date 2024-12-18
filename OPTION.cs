using System;
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
    public partial class OPTION : Form
    {
        public OPTION()
        {
            InitializeComponent();


            label1.Text = optionclass.label;
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void OPTION_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CALENDAR a = new CALENDAR();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DASHBOARD a = new DASHBOARD();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("are you sure you want to log out?", "EXIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
               this.Close();
               admin_log_in a = new admin_log_in();
                a.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            info m = new info();
            m.Show();
            this.Hide();
        }
    }
}
