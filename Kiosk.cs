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
    public partial class kiosk : Form
    {
        public kiosk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           admin_log_in f = new admin_log_in();
            f.Show();
            this.Hide();
        }

        private void kiosk_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
