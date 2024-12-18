using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace resorthub
{
    public partial class CONTACT : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\arlan\\Downloads\\resortdatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public CONTACT()
        {
            InitializeComponent();
            textBox1.Text = "date start " + CalendarClass1.start;
            textBox2.Text = "date end " + CalendarClass1.end;
            textBox10.Text = "total days " + RoomsClass1.fday;
            textBox11.Text = " adult: " + RoomsClass1.fadult;
            textBox12.Text = "child: " + RoomsClass1.fchild;
            textBox13.Text = "total charge " + RoomsClass1.ftotal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CONTACT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Transaction_Table (First_Name, Last_Name, Date_start, Date_End, Adults, Child, NumberOfDays, Total_Payment, Time_Of_Arrival, Gender, Email, Contact_Num, Birthday)VALUES ('" + fname.Text + "', '" + lname.Text + "', '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox10.Text + "','" + textBox13.Text + "','" + time.Text + "','" + gender.Text + "','" + email.Text + "','" + num.Text + "','" + bday.Text + "');", sqlConnection);
                sqlCommand.ExecuteReader();
                sqlConnection.Close();
            CONFIRM n = new CONFIRM();
            n.Show();
            this.Hide();
          
            
            
           
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
