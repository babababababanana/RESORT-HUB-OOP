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
    public partial class ROOMS : Form
    {
        public ROOMS()
        {
            InitializeComponent();
            textBox1.Text = CalendarClass1.start;
            textBox2.Text = CalendarClass1.end;
        }

        private void ROOMS_Load(object sender, EventArgs e) 
        {
            
        }
    }
}
