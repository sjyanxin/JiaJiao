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
using JiaJiao.Bus;
namespace JiaJiao.Web.ErrorLog
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtErrorTime.Text))
			{
				strErr+="ErrorTime格式错误！\\n";	
			}
			if(this.txtErrorMessage.Text.Trim().Length==0)
			{
				strErr+="ErrorMessage不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			DateTime ErrorTime=DateTime.Parse(this.txtErrorTime.Text);
			string ErrorMessage=this.txtErrorMessage.Text;

			JiaJiao.Model.ErrorLog model=new JiaJiao.Model.ErrorLog();
			model.ErrorTime=ErrorTime;
			model.ErrorMessage=ErrorMessage;

			JiaJiao.BLL.ErrorLog bll=new JiaJiao.BLL.ErrorLog();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
