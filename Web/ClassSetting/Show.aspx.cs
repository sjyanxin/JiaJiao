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
        public string strid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    strid = Request.Params["id"];
                    int ID = (Convert.ToInt32(strid));
                    ShowInfo(ID);
                }
            }
        }

        private void ShowInfo(int ID)
        {
            JiaJiao.BLL.ClassSetting bll = new JiaJiao.BLL.ClassSetting();
            JiaJiao.Model.ClassSetting model = bll.GetModel(ID);
            this.lblID.Text = model.ID.ToString();
            this.lblTotal.Text = model.Total.ToString();
            this.lblCount.Text = model.Count.ToString();

            JiaJiao.BLL.Class bll1 = new BLL.Class();
            var model1 = bll1.GetModel(model.DayId.Value);
            JiaJiao.BLL.Teacher bll2 = new BLL.Teacher();
            var model2 = bll2.GetModel(model.TeacherId);
            this.lblDayId.Text = model1.Day + " " + model1.Time
                ;
            this.lblTeacherId.Text = model2.TeacherName;


        }


    }
}
