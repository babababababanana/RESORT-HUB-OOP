using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace resorthub
{
    public class admin_login
    {
        public string username { get; set; }
        public string password { get; set; }

      

        public void log(TextBox user,TextBox pass)
        {
          username = user.Text;
                

            if (pass.Text == "admin")
            {
                password = pass.Text;
                MessageBox.Show("WELCOME");
                kiosk F = new kiosk();
                F.Show();
         
            
            }
            else
            {
                MessageBox.Show("wrong username or pass", "inavalid");
            }    

        }

        public bool validate_textbox(TextBox textBox1,TextBox textBox2)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("no empty space please try again");
                return false;
            }
            else
            {
              
                return true;
            }
            
        }
    }
}
