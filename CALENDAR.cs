using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace resorthub
{
    public partial class CALENDAR : Form
    {
        private CalendarClass1 calendarManager;
        public CALENDAR()
        {
            InitializeComponent();
            calendarManager = new CalendarClass1();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void CALENDAR_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            calendarManager.updatesstart(monthCalendar1.SelectionStart);

            // Display the selected date in the TextBox
           CalendarClass1.start = calendarManager.selectdatestart.ToShortDateString();
            textBox2.Text = CalendarClass1.start;

        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = DateTime.Today;
            monthCalendar2.SelectionEnd = DateTime.Today;
            textBox2.Clear();  
            textBox3.Clear();
        }

        private void CONFIRMBTN_Click(object sender, EventArgs e)
        {
            ROOMS n = new ROOMS();
            n.Show();
            this.Hide();
        }

        private void monthCalendar2_DateChanged_1(object sender, DateRangeEventArgs e)
        {

            calendarManager.updateend(monthCalendar2.SelectionStart);

            // Display the selected date in the TextBox
            CalendarClass1.end =  calendarManager.selectdatend.ToShortDateString();
            textBox3.Text = CalendarClass1.end;
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
