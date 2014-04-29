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
namespace JiaJiao.Web.ClassSetting
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
		JiaJiao.BLL.ClassSetting bll=new JiaJiao.BLL.ClassSetting();
		JiaJiao.Model.ClassSetting model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblTeacherId.Text=model.TeacherId.ToString();
		this.lblDayId.Text=model.DayId.ToString();
		this.lblTotal.Text=model.Total.ToString();
		this.lblCount.Text=model.Count.ToString();
		this.lblCreateTime.Text=model.CreateTime.ToString();
		this.lblUpdateTime.Text=model.UpdateTime.ToString();

	}


    }
}
