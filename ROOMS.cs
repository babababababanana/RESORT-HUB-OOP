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

        private void button3_Click(object sender, EventArgs e)
        {
            B1TXTA.Enabled = true;
            B1TXTC.Enabled = true;
            B1TXTD.Enabled = true;
            button2.Enabled = false;
            B2TXTA.Clear();
            B2TXTC.Clear();
            B2TXTD.Clear();


            RoomsClass1 n = new RoomsClass1();
            n.B1(B1TXTA, B1TXTC, B1TXTD, A, B, C, D);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            B2TXTA.Enabled=true;
            B2TXTC.Enabled = true;
            B2TXTD.Enabled = true;
            button3.Enabled = false;
            B1TXTA.Clear();
            B1TXTC.Clear();
            B1TXTD.Clear();

            RoomsClass1 n = new RoomsClass1();
            n.B2(B2TXTA, B2TXTC, B2TXTD, A, B, C, D);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3.Enabled=true;
            button2.Enabled=true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CALENDAR n = new CALENDAR();
            n.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomsClass1.fadult = A.Text;
            RoomsClass1.fchild = B.Text;
            RoomsClass1.fday = C.Text;
            RoomsClass1.ftotal = D.Text;
            CONTACT N = new CONTACT();  
            N.Show();
            this.Hide();
            
        }
    }
}
