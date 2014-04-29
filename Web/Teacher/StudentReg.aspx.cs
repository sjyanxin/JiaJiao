using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiaJiao.Web.Teacher
{
    public partial class StudentReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Button1.Attributes.Add("onclick", "return confirm(\"报名成功！\")");
              
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}