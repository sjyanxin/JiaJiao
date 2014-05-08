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
            if (this.txtTeacherName.Text.Trim().Length == 0)
            {
                strErr += "姓名不能为空！\\n";
            }
            if (this.txtTeacherTel.Text.Trim().Length == 0)
            {
                strErr += "电话不能为空！\\n";
            }
          
         
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string fullFileName = this.fileUpLoad.PostedFile.FileName;
            string fileName = fullFileName.Substring(fullFileName.LastIndexOf(@"/") + 1);
            string typeName = (fullFileName.Substring(fullFileName.LastIndexOf(".") + 1)).ToLower();

            if (string.IsNullOrWhiteSpace(fileName))
            {             
                MessageBox.Show(this, "请选择一张图片");
                return;
            }
            string file = DateTime.Now.ToString("yyyyMMddHHmmss") + "." + typeName;
            if (typeName == "png" || typeName == "jpg" || typeName == "bmp" || typeName == "gif" || typeName == "jpeg")
            {
              
                this.fileUpLoad.PostedFile.SaveAs(Server.MapPath("~/Images/") + file);

            }
            else
            {
                MessageBox.Show(this, "你的图片格式错误");
                return;
            }
            string TeacherName = this.txtTeacherName.Text;
            string TeacherTel = this.txtTeacherTel.Text;
            string TeacherEmail = this.txtTeacherEmail.Text;
            string TeacherAddress = this.txtTeacherAddress.Text;
            string TeacherDescribe = this.txtTeacherDescribe.Text;
            int RoleId = int.Parse(DropDownList1.SelectedValue);
            DateTime CreateTime = DateTime.Now;
            DateTime UpdateTime = DateTime.Now;

            JiaJiao.Model.Teacher model = new JiaJiao.Model.Teacher();
            model.TeacherName = TeacherName;
            model.TeacherTel = TeacherTel;
            model.TeacherEmail = TeacherEmail;
            model.TeacherAddress = TeacherAddress;
            model.TeacherDescribe = TeacherDescribe;
            model.RoleId = RoleId;
            model.CreateTime = CreateTime;
            model.UpdateTime = UpdateTime;
            model.Image = "~/Images/" + file;
          

            JiaJiao.BLL.Teacher bll = new JiaJiao.BLL.Teacher();
            bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "add.aspx");

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
     

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //获取文件在客户端计算机上的完全路径名(例如"D:/myfiles/lo.txt")
            string fullFileName = this.fileUpLoad.PostedFile.FileName;

            //获取文件的具体文件名（例如"lo.txt")
            string fileName = fullFileName.Substring(fullFileName.LastIndexOf(@"/") + 1);

            //获取文件的扩展名（例如"txt")
            string typeName = (fullFileName.Substring(fullFileName.LastIndexOf(".") + 1)).ToLower();

            if (typeName == "png" || typeName == "jpg" || typeName == "bmp" || typeName == "gif" || typeName == "jpeg")
            {

                this.fileUpLoad.PostedFile.SaveAs(Server.MapPath("~/Images/") + fileName);//+ @"/"
                
            }
            else
            {
                Response.Write("<script languge='javascript'>alert('你的图片格式错误!');</script>");
            }
        }

        //public void ValidateFileDimensions()
        //{

        //    Image1.ImageUrl ="~/Images/"+ this.fileUpLoad.PostedFile.FileName;

        //}

    }
}
