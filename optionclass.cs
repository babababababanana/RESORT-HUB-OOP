using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resorthub
{
    public class optionclass : admin_login
    {
        public static string label;

        public Label name(Label label)
        {
           username = label.Text;
            return label;
        }

       
        

    }
}
