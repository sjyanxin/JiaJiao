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
namespace JiaJiao.Web.Teacher
{
    public partial class Modify : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                JiaJiao.Data.Role role = new Data.Role();
                var ds = role.GetRoleList();
                DropDownList1.DataSource = ds.Tables["Roles"];
                DropDownList1.DataBind();
                DropDownList1.SelectedValue = Request.Params["id"];
                ShowInfo(int.Parse(Request.Params["id"]));
            }
        }

        private void ShowInfo(int ID)
        {
            JiaJiao.BLL.Teacher bll = new JiaJiao.BLL.Teacher();
            JiaJiao.Model.Teacher model = bll.GetModel(ID);
            this.lblID.Text = model.ID.ToString();
            this.txtTeacherName.Text = model.TeacherName;
            this.txtTeacherTel.Text = model.TeacherTel;
            this.txtTeacherEmail.Text = model.TeacherEmail;
            this.txtTeacherAddress.Text = model.TeacherAddress;
            this.txtTeacherDescribe.Text = model.TeacherDescribe;
     

        }

        public void btnSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            if (this.txtTeacherName.Text.Trim().Length == 0)
            {
                strErr += "TeacherName不能为空！\\n";
            }
            if (this.txtTeacherTel.Text.Trim().Length == 0)
            {
                strErr += "TeacherTel不能为空！\\n";
            }
           
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string fullFileName = this.fileUpLoad.PostedFile.FileName;
            string fileName = fullFileName.Substring(fullFileName.LastIndexOf(@"/") + 1);
            string typeName = (fullFileName.Substring(fullFileName.LastIndexOf(".") + 1)).ToLower();

            string file = DateTime.Now.ToString("yyyyMMddHHmmss") + "." + typeName;
            bool flag = false;
            if (!string.IsNullOrWhiteSpace(fileName))
            {
             
                if (typeName == "png" || typeName == "jpg" || typeName == "bmp" || typeName == "gif" || typeName == "jpeg")
                {

                    this.fileUpLoad.PostedFile.SaveAs(Server.MapPath("~/Images/") + file);
                    flag = true;
                }
                else
                {
                    MessageBox.Show(this, "你的图片格式错误");
                    return;
                }

            }
           

            int ID = int.Parse(this.lblID.Text);
            string TeacherName = this.txtTeacherName.Text;
            string TeacherTel = this.txtTeacherTel.Text;
            string TeacherEmail = this.txtTeacherEmail.Text;
            string TeacherAddress = this.txtTeacherAddress.Text;
            string TeacherDescribe = this.txtTeacherDescribe.Text;
            int RoleId = int.Parse(DropDownList1.SelectedValue);
            DateTime CreateTime = DateTime.Now;
            DateTime UpdateTime = DateTime.Now;


            JiaJiao.Model.Teacher model = new JiaJiao.Model.Teacher();
            model.ID = ID;
            model.TeacherName = TeacherName;
            model.TeacherTel = TeacherTel;
            model.TeacherEmail = TeacherEmail;
            model.TeacherAddress = TeacherAddress;
            model.TeacherDescribe = TeacherDescribe;
            model.RoleId = RoleId;
            model.CreateTime = CreateTime;
            model.UpdateTime = UpdateTime;
            JiaJiao.BLL.Teacher bll = new JiaJiao.BLL.Teacher();
            if (flag)
            {
                model.Image = "~/Images/" + file;
            }
            else
            {
              
                JiaJiao.Model.Teacher model1 = bll.GetModel(ID);
                model.Image = model1.Image;
               int id= int.Parse(Request.Params["id"]);
            }

         
            bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
