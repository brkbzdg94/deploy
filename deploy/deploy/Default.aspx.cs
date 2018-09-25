using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deploy
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int target = -5;
            int num = 3;

            target = -num;  // Noncompliant; target = -3. Is that really what's meant?
            target = +num; // Noncompliant; target = 3


            int a;

            

            var s = "foo";
            var t = "fee fie foe " + s.ToString();  // Noncompliant
            var someObject = new object();
            var u = "" + someObject.ToString(); // Noncompliant
            var v = string.Format("{0}", someObject.ToString()); // Noncompliant

        }
        
          
       
    }
}