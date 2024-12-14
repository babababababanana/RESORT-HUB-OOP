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
    public partial class admin_log_in : Form
    {
        public admin_log_in()
        {
            InitializeComponent();
        }

        private void admin_log_in_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kiosk f = new kiosk();
            f.Show();
            this.Hide();
        }
    }
}
