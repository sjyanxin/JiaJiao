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

namespace JiaJiao.Web.ClassSetting
{
    public partial class Modify : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    int ID = (Convert.ToInt32(Request.Params["id"]));
                    ShowInfo(ID);


                }
            }
        }

        private void ShowInfo(int ID)
        {
            JiaJiao.BLL.ClassSetting bll = new JiaJiao.BLL.ClassSetting();
            JiaJiao.Model.ClassSetting model = bll.GetModel(ID);
            this.lblID.Text = model.ID.ToString();

            this.txtTotal.Text = model.Total.ToString();
            this.txtCount.Text = model.Count.ToString();


            JiaJiao.BLL.Class bll1 = new BLL.Class();
            var classModel1 = bll1.GetModel(model.DayId.Value);
            JiaJiao.BLL.Teacher bll2 = new BLL.Teacher();
            var teacherModel2 = bll2.GetModel(model.TeacherId);

            JiaJiao.BLL.Teacher t = new BLL.Teacher();
            var ds = t.GetAllList();
            this.ddlTeacher.DataSource = ds.Tables[0];
            this.ddlTeacher.DataBind();
            ddlTeacher.SelectedValue = model.TeacherId.ToString();


            JiaJiao.BLL.Class c = new BLL.Class();
            var clist = c.GetModelList("");
            this.ddlDay.DataSource = clist.GroupBy(d => d.Day).Select(g => g.Key);
            this.ddlDay.DataBind();
            ddlDay.SelectedValue = classModel1.Day;

            this.ddlTime.DataSource = clist.Where(d => d.Day == classModel1.Day);
            this.ddlTime.DataBind();

        }

        public void btnSave_Click(object sender, EventArgs e)
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
                strErr += "报名人数格式错误！\\n";
            }


            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            int ID = int.Parse(this.lblID.Text);
            int TeacherId = int.Parse(this.ddlTeacher.SelectedValue);
            int DayId = int.Parse(this.ddlTime.SelectedValue);
            int Total = int.Parse(this.txtTotal.Text);
            int Count = int.Parse(this.txtCount.Text);
            DateTime CreateTime = DateTime.Now;
            DateTime UpdateTime = DateTime.Now;


            JiaJiao.Model.ClassSetting model = new JiaJiao.Model.ClassSetting();
            model.ID = ID;
            model.TeacherId = TeacherId;
            model.DayId = DayId;
            model.Total = Total;
            model.Count = Count;
            model.CreateTime = CreateTime;
            model.UpdateTime = UpdateTime;

            JiaJiao.BLL.ClassSetting bll = new JiaJiao.BLL.ClassSetting();
            bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");

        }
        protected void ddlDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            JiaJiao.BLL.Class c = new BLL.Class();
            var clist = c.GetModelList("");
            this.ddlTime.DataSource = clist.Where(d => d.Day == ddlDay.SelectedValue);
            this.ddlTime.DataBind();
        }

        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
