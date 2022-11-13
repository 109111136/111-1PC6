using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC6
{
    public partial class test : System.Web.UI.Page
    {
        string[] school = new string[3] { "台科", "北科", "亞東" };
        protected void Page_Load(object sender, EventArgs e)
        {
                for (int i = 0; i < school.Length; i++)
                {
                    ListItem C = new ListItem();
                    C.Text = school[i];
                    ddl_Test.Items.Add(C);

                }
        }
    }
}