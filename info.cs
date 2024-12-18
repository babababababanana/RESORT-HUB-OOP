using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace resorthub
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\arlan\\Downloads\\resortdatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private void info_Load(object sender, EventArgs e)
        {
             sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Transaction_Table", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OPTION a =new OPTION();
            a.Show();
            this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Transaction_Table where [Last_Name] like '%" + textBox1.Text + "%'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{


                int rowindex = Convert.ToInt32(e.RowIndex);

                textBox2.Text = dataGridView1.Rows[rowindex].Cells[12].Value.ToString();
                textBox4.Text = dataGridView1.Rows[rowindex].Cells[10].Value.ToString();
                textBox3.Text = dataGridView1.Rows[rowindex].Cells[13].Value.ToString();
                textBox5.Text = dataGridView1.Rows[rowindex].Cells[8].Value.ToString();


            }
            catch { }
           
        }
    }
}
