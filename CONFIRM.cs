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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace resorthub
{
    public partial class CONFIRM : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\arlan\\Downloads\\resortdatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public CONFIRM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void CONFIRM_Load(object sender, EventArgs e)
        {
            textBox2.Text = RoomsClass1.ftotal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                string query = "INSERT INTO Transaction_Table (Tracking_Number) VALUES (@TrackingNumber)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);          
                sqlCommand.Parameters.AddWithValue("@TrackingNumber", textBox1.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Success");
                OPTION M = new OPTION();
                M.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
