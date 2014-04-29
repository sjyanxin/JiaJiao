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
namespace JiaJiao.Web.Teacher
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
		JiaJiao.BLL.Teacher bll=new JiaJiao.BLL.Teacher();
		JiaJiao.Model.Teacher model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtTeacherName.Text=model.TeacherName;
		this.txtTeacherTel.Text=model.TeacherTel;
		this.txtTeacherEmail.Text=model.TeacherEmail;
		this.txtTeacherAddress.Text=model.TeacherAddress;
		this.txtTeacherDescribe.Text=model.TeacherDescribe;
		this.txtRoleId.Text=model.RoleId.ToString();
		this.txtCreateTime.Text=model.CreateTime.ToString();
		this.txtUpdateTime.Text=model.UpdateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtTeacherName.Text.Trim().Length==0)
			{
				strErr+="TeacherName不能为空！\\n";	
			}
			if(this.txtTeacherTel.Text.Trim().Length==0)
			{
				strErr+="TeacherTel不能为空！\\n";	
			}
			if(this.txtTeacherEmail.Text.Trim().Length==0)
			{
				strErr+="TeacherEmail不能为空！\\n";	
			}
			if(this.txtTeacherAddress.Text.Trim().Length==0)
			{
				strErr+="TeacherAddress不能为空！\\n";	
			}
			if(this.txtTeacherDescribe.Text.Trim().Length==0)
			{
				strErr+="TeacherDescribe不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtRoleId.Text))
			{
				strErr+="RoleId格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateTime.Text))
			{
				strErr+="CreateTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="UpdateTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string TeacherName=this.txtTeacherName.Text;
			string TeacherTel=this.txtTeacherTel.Text;
			string TeacherEmail=this.txtTeacherEmail.Text;
			string TeacherAddress=this.txtTeacherAddress.Text;
			string TeacherDescribe=this.txtTeacherDescribe.Text;
			int RoleId=int.Parse(this.txtRoleId.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);


			JiaJiao.Model.Teacher model=new JiaJiao.Model.Teacher();
			model.ID=ID;
			model.TeacherName=TeacherName;
			model.TeacherTel=TeacherTel;
			model.TeacherEmail=TeacherEmail;
			model.TeacherAddress=TeacherAddress;
			model.TeacherDescribe=TeacherDescribe;
			model.RoleId=RoleId;
			model.CreateTime=CreateTime;
			model.UpdateTime=UpdateTime;

			JiaJiao.BLL.Teacher bll=new JiaJiao.BLL.Teacher();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
