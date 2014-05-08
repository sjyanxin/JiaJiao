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
using System.Linq;
using System.Collections.Generic;

namespace JiaJiao.Web.ClassSetting
{
    public partial class Add : Page
    {

        List<JiaJiao.Model.Class> clist;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtCount.Text = "0";
                JiaJiao.BLL.Teacher t = new BLL.Teacher();
                var ds = t.GetAllList();
                this.ddlTeacher.DataSource = ds.Tables[0];
                this.ddlTeacher.DataBind();

                JiaJiao.BLL.Class c = new BLL.Class();
                clist= c.GetModelList("");
               this.ddlDay.DataSource = clist.GroupBy(d => d.Day).Select(g => g.Key) ;              
               this.ddlDay.DataBind();
               this.ddlTime.DataSource = clist.Where(d => d.Day == "周一");
               this.ddlTime.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (!PageValidate.IsNumber(this.ddlTeacher.SelectedValue))
            {
                strErr += "请选择一个老师！\\n";
            }
         
            if (string.IsNullOrWhiteSpace(this.ddlTime.SelectedValue))
            {
                strErr += "请选择时间！\\n";
            }
            if (!PageValidate.IsNumber(txtTotal.Text))
            {
                strErr += "开班人数格式错误！\\n";
            }
            if (!PageValidate.IsNumber(txtCount.Text))
            {
                strErr += "报名人数人数格式错误！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            int TeacherId = int.Parse(this.ddlTeacher.SelectedValue);
            int DayId = int.Parse(this.ddlTime.SelectedValue);
            int Total = int.Parse(this.txtTotal.Text);
            int Count = int.Parse(this.txtCount.Text);
            DateTime CreateTime = DateTime.Now;
            DateTime UpdateTime = DateTime.Now;

            JiaJiao.Model.ClassSetting model = new JiaJiao.Model.ClassSetting();
            model.TeacherId = TeacherId;
            model.DayId = DayId;
            model.Total = Total;
            model.Count = Count;
            model.CreateTime = CreateTime;
            model.UpdateTime = UpdateTime;

            JiaJiao.BLL.ClassSetting bll = new JiaJiao.BLL.ClassSetting();
            bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "add.aspx");

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }

        protected void ddlDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            JiaJiao.BLL.Class c = new BLL.Class();
            clist = c.GetModelList("");
            this.ddlTime.DataSource = clist.Where(d => d.Day==ddlDay.SelectedValue) ;
            this.ddlTime.DataBind();
        }
    }
}
