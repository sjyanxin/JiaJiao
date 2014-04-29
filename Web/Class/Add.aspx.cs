using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace JiaJiao.Web.Class
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDay.Text.Trim().Length==0)
			{
				strErr+="Day不能为空！\\n";	
			}
			if(this.txtTime.Text.Trim().Length==0)
			{
				strErr+="Time不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Day=this.txtDay.Text;
			string Time=this.txtTime.Text;

			JiaJiao.Model.Class model=new JiaJiao.Model.Class();
			model.Day=Day;
			model.Time=Time;

			JiaJiao.BLL.Class bll=new JiaJiao.BLL.Class();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
