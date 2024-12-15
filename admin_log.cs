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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            


            admin_login admin = new admin_login();
           if(admin.validate_textbox(textBox1,textBox2))
            {
               admin.log(textBox1, textBox2);

            }
            
        }  
    }
}
