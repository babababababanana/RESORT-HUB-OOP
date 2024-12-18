using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace resorthub
{
    public class CalendarClass1
    {
        public static string start;
        public static string end;
        public DateTime selectdatestart;
        public DateTime selectdatend;
      

        public void updatesstart(DateTime newdate)
        {
            selectdatestart = newdate;
        }

        public void updateend(DateTime newdate)
        {
            selectdatend = newdate;
        }

        
      

    }
}
