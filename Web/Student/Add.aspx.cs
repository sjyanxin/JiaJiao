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
namespace JiaJiao.Web.Student
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtStuName.Text.Trim().Length==0)
			{
				strErr+="StuName不能为空！\\n";	
			}
			if(this.txtStuEmail.Text.Trim().Length==0)
			{
				strErr+="StuEmail不能为空！\\n";	
			}
			if(this.txtStuTel.Text.Trim().Length==0)
			{
				strErr+="StuTel不能为空！\\n";	
			}
			if(this.txtStuAddress.Text.Trim().Length==0)
			{
				strErr+="StuAddress不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtRoleId.Text))
			{
				strErr+="RoleId格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateTime.Text))
			{
				strErr+="CreateTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdteTime.Text))
			{
				strErr+="UpdteTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string StuName=this.txtStuName.Text;
			string StuEmail=this.txtStuEmail.Text;
			string StuTel=this.txtStuTel.Text;
			string StuAddress=this.txtStuAddress.Text;
			int RoleId=int.Parse(this.txtRoleId.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);
			DateTime UpdteTime=DateTime.Parse(this.txtUpdteTime.Text);

			JiaJiao.Model.Student model=new JiaJiao.Model.Student();
			model.StuName=StuName;
			model.StuEmail=StuEmail;
			model.StuTel=StuTel;
			model.StuAddress=StuAddress;
			model.RoleId=RoleId;
			model.CreateTime=CreateTime;
			model.UpdteTime=UpdteTime;

			JiaJiao.BLL.Student bll=new JiaJiao.BLL.Student();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
