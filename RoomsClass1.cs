using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resorthub
{
    internal class RoomsClass1 : CalendarClass1
    {
        public int BUNDLE1 = 5000;
        public int BUNDLE2 = 10000;

        public int firstbundle = 5000;
        public int secondbundle = 10000;
        public int numberofdays = 0;
        public int adults = 0;
        public int childs = 0;
        public static string fadult;
        public static string fchild;
        public static string fday;
        public static string  ftotal;




        public void B1(TextBox adult, TextBox child, TextBox days, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            
            if (int.TryParse(adult.Text, out adults) && int.TryParse(child.Text, out childs) && int.TryParse(days.Text, out numberofdays))
            {
                
                txt1.Text = adults.ToString();
                txt2.Text = childs.ToString();
                txt3.Text = numberofdays.ToString();

                int total = numberofdays * BUNDLE1;
                txt4.Text = total.ToString(); 
            }
            else
            {
               
                MessageBox.Show("Please enter valid numeric values in the textboxes.");
                txt4.Text = "0"; 
            }
        }

        public void B2(TextBox adult, TextBox child, TextBox days, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {

            if (int.TryParse(adult.Text, out adults) && int.TryParse(child.Text, out childs) && int.TryParse(days.Text, out numberofdays))
            {

                txt1.Text = adults.ToString();
                txt2.Text = childs.ToString();
                txt3.Text = numberofdays.ToString();

                int total = numberofdays * BUNDLE2;
                txt4.Text = total.ToString();
            }
            else
            {

                MessageBox.Show("Please enter valid numeric values in the textboxes.");
                txt4.Text = "0";
            }
        }


        public void final(TextBox a,TextBox b, TextBox c, TextBox d)
        {
            a.Text = fadult;
            b.Text = fchild;
            c.Text = fday;
            d.Text = ftotal;


        }




    } 
}
