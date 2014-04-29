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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		JiaJiao.BLL.Student bll=new JiaJiao.BLL.Student();
		JiaJiao.Model.Student model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtStuName.Text=model.StuName;
		this.txtStuEmail.Text=model.StuEmail;
		this.txtStuTel.Text=model.StuTel;
		this.txtStuAddress.Text=model.StuAddress;
		this.txtRoleId.Text=model.RoleId.ToString();
		this.txtCreateTime.Text=model.CreateTime.ToString();
		this.txtUpdteTime.Text=model.UpdteTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int ID=int.Parse(this.lblID.Text);
			string StuName=this.txtStuName.Text;
			string StuEmail=this.txtStuEmail.Text;
			string StuTel=this.txtStuTel.Text;
			string StuAddress=this.txtStuAddress.Text;
			int RoleId=int.Parse(this.txtRoleId.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);
			DateTime UpdteTime=DateTime.Parse(this.txtUpdteTime.Text);


			JiaJiao.Model.Student model=new JiaJiao.Model.Student();
			model.ID=ID;
			model.StuName=StuName;
			model.StuEmail=StuEmail;
			model.StuTel=StuTel;
			model.StuAddress=StuAddress;
			model.RoleId=RoleId;
			model.CreateTime=CreateTime;
			model.UpdteTime=UpdteTime;

			JiaJiao.BLL.Student bll=new JiaJiao.BLL.Student();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
