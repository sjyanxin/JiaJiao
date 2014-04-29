using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiaJiao.Web.Teacher
{
    public partial class TeacherClass : System.Web.UI.Page
    {


        JiaJiao.BLL.Teacher bll = new JiaJiao.BLL.Teacher();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gridView.BorderColor = ColorTranslator.FromHtml(Application[Session["Style"].ToString() + "xtable_bordercolorlight"].ToString());
                gridView.HeaderStyle.BackColor = ColorTranslator.FromHtml(Application[Session["Style"].ToString() + "xtable_titlebgcolor"].ToString());

                BindData();
            }
        }



        #region gridView



        public void BindData()
        {

            List<JiaJiao.Model.ClassInfo> list = new List<JiaJiao.Model.ClassInfo>();
            JiaJiao.BLL.Teacher bllTeacher = new JiaJiao.BLL.Teacher();
            JiaJiao.BLL.ClassSetting classSetting = new BLL.ClassSetting();
            JiaJiao.BLL.Class Classbll = new JiaJiao.BLL.Class();

            var classlist = Classbll.GetModelList("").GroupBy(key => key.Day);
            foreach (var item in classlist)
            {
                list.Add(new JiaJiao.Model.ClassInfo() { Day = item.Key, KeyValues = new Dictionary<int, Model.ClassSetting>() });
            }


            var teacherlist = bllTeacher.GetModelList("");
            var teacher = teacherlist.Where(t => t.ID.ToString() == Request.QueryString["id"]).FirstOrDefault();
            if (teacher != null)
            {
                Label1.Text = teacher.TeacherName;
                Label2.Text = teacher.TeacherDescribe;
            }

            var clsSetting = classSetting.GetModelList("teacherid=" + Request.QueryString["id"]).GroupBy(key => key.DayId);
            int index = 0;

            foreach (var item in classlist)
            {
                int index1 = 0;
                foreach (var item0 in item)
                {
                    var templist = clsSetting.Where(key => key.Key == item0.ID);
                    if (templist.Count() > 0)
                    {
                        foreach (var item1 in templist.FirstOrDefault())
                        {
                            switch (index1)
                            {
                                case 0:
                                    list[index].Time1 += item1.Count + "/" + item1.Total;
                                    break;
                                case 1:
                                    list[index].Time2 += item1.Count + "/" + item1.Total;
                                    break;
                                case 2:
                                    list[index].Time3 += item1.Count + "/" + item1.Total;
                                    break;
                                case 3:
                                    list[index].Time4 += item1.Count + "/" + item1.Total;
                                    break;
                                case 4:
                                    list[index].Time5 += item1.Count + "/" + item1.Total;
                                    break;
                                case 5:
                                    list[index].Time6 += item1.Count + "/" + item1.Total;
                                    break;
                                case 6:
                                    list[index].Time7 += item1.Count + "/" + item1.Total;
                                    break;
                            }
                            list[index].KeyValues.Add(index1, item1);
                        }
                    }
                    else
                    {
                        list[index].KeyValues.Add(index1, null);
                    }
                    index1++;
                }
                index++;
            }

            gridView.DataSource = list;
            gridView.DataBind();
        }



        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridView.PageIndex = e.NewPageIndex;
            BindData();
        }
        protected void gridView_OnRowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //e.Row.Cells[0].Text = "<input id='Checkbox2' type='checkbox' onclick='CheckAll()'/><label></label>";
            }
        }
        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Attributes.Add("style", "background:#FFF");
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                GridViewRow row = e.Row as GridViewRow;
               var ClassInfo=  row.DataItem as JiaJiao.Model.ClassInfo;
               int index = 1;
               foreach (var item in ClassInfo.KeyValues)
               {
                   if (item.Value != null && item.Value.Count == item.Value.Total)
                   {
                       e.Row.Cells[index].Text = "<label>" + item.Value.Count + "/" + item.Value.Total + "</label>";
                       e.Row.Cells[index].BackColor = Color.Red;
                   }
                   else if(item.Value != null)
                   {
                       e.Row.Cells[index].Text = "<a href=StudentReg.aspx?classid=" + item.Value.ID+ ">" + item.Value.Count + "/" + item.Value.Total + "</label>";
                      
                       e.Row.Cells[index].BackColor = Color.Green;
                   }
                   index++;
               }
             
            }
        }

        protected void gridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //#warning 代码生成警告：请检查确认真实主键的名称和类型是否正确
            //int ID = (int)gridView.DataKeys[e.RowIndex].Value;
            //bll.Delete(ID);
            //gridView.OnBind();
        }

        private string GetSelIDlist()
        {
            string idlist = "";
            bool BxsChkd = false;
            for (int i = 0; i < gridView.Rows.Count; i++)
            {
                CheckBox ChkBxItem = (CheckBox)gridView.Rows[i].FindControl("DeleteThis");
                if (ChkBxItem != null && ChkBxItem.Checked)
                {
                    BxsChkd = true;
                    //#warning 代码生成警告：请检查确认Cells的列索引是否正确
                    if (gridView.DataKeys[i].Value != null)
                    {
                        idlist += gridView.DataKeys[i].Value.ToString() + ",";
                    }
                }
            }
            if (BxsChkd)
            {
                idlist = idlist.Substring(0, idlist.LastIndexOf(","));
            }
            return idlist;
        }

        #endregion




    }
}