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
namespace JiaJiao.Web.Student
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                JiaJiao.Data.Role role = new Data.Role();
                var ds = role.GetRoleList();
                DropDownList1.DataSource = ds.Tables["Roles"];
                DropDownList1.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (this.txtStuName.Text.Trim().Length == 0)
            {
                strErr += "姓名不能为空！\\n";
            }

            if (this.txtStuTel.Text.Trim().Length == 0)
            {
                strErr += "电话不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string StuName = this.txtStuName.Text;
            string StuEmail = this.txtStuEmail.Text;
            string StuTel = this.txtStuTel.Text;
            string StuAddress = this.txtStuAddress.Text;
            int RoleId = int.Parse(this.DropDownList1.SelectedValue);
            DateTime CreateTime = DateTime.Now;
            DateTime UpdteTime = DateTime.Now;

            JiaJiao.Model.Student model = new JiaJiao.Model.Student();
            model.StuName = StuName;
            model.StuEmail = StuEmail;
            model.StuTel = StuTel;
            model.StuAddress = StuAddress;
            model.RoleId = RoleId;
            model.CreateTime = CreateTime;
            model.UpdteTime = UpdteTime;

            JiaJiao.BLL.Student bll = new JiaJiao.BLL.Student();
            bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "add.aspx");

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
