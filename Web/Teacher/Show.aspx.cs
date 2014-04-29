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
namespace JiaJiao.Web.Teacher
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		JiaJiao.BLL.Teacher bll=new JiaJiao.BLL.Teacher();
		JiaJiao.Model.Teacher model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblTeacherName.Text=model.TeacherName;
		this.lblTeacherTel.Text=model.TeacherTel;
		this.lblTeacherEmail.Text=model.TeacherEmail;
		this.lblTeacherAddress.Text=model.TeacherAddress;
		this.lblTeacherDescribe.Text=model.TeacherDescribe;
		this.lblRoleId.Text=model.RoleId.ToString();
		this.lblCreateTime.Text=model.CreateTime.ToString();
		this.lblUpdateTime.Text=model.UpdateTime.ToString();

	}


    }
}
