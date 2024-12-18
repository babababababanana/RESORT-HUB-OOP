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
    }
}
