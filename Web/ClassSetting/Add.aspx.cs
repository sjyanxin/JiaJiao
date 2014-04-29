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
namespace JiaJiao.Web.ClassSetting
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtTeacherId.Text))
			{
				strErr+="TeacherId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDayId.Text))
			{
				strErr+="DayId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTotal.Text))
			{
				strErr+="Total格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCount.Text))
			{
				strErr+="Count格式错误！\\n";	
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
			int TeacherId=int.Parse(this.txtTeacherId.Text);
			int DayId=int.Parse(this.txtDayId.Text);
			int Total=int.Parse(this.txtTotal.Text);
			int Count=int.Parse(this.txtCount.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);

			JiaJiao.Model.ClassSetting model=new JiaJiao.Model.ClassSetting();
			model.TeacherId=TeacherId;
			model.DayId=DayId;
			model.Total=Total;
			model.Count=Count;
			model.CreateTime=CreateTime;
			model.UpdateTime=UpdateTime;

			JiaJiao.BLL.ClassSetting bll=new JiaJiao.BLL.ClassSetting();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
