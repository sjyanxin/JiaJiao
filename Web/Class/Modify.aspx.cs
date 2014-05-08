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
namespace JiaJiao.Web.Class
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
		JiaJiao.BLL.Class bll=new JiaJiao.BLL.Class();
		JiaJiao.Model.Class model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtDay.Text=model.Day;
		this.txtTime.Text=model.Time;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int ID=int.Parse(this.lblID.Text);
			string Day=this.txtDay.Text;
			string Time=this.txtTime.Text;


			JiaJiao.Model.Class model=new JiaJiao.Model.Class();
			model.ID=ID;
			model.Day=Day;
			model.Time=Time;

			JiaJiao.BLL.Class bll=new JiaJiao.BLL.Class();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
