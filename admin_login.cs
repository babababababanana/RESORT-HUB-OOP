
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using MySql.Data.MySqlClient;

namespace resorthub
{
    public class admin_login
    {
        public string username { get; set; }
        public string password { get; set; }

      

        public TextBox log(TextBox user,TextBox pass)
        {
          username = user.Text;

                

            if (pass.Text == "admin")
            {
                password = pass.Text;
                MessageBox.Show("welcome");
                OPTION F = new OPTION();
                F.Show();
                return pass;
                
         
            
            }
            else
            {
                MessageBox.Show("wrong username or pass", "inavalid");
                return null;
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
