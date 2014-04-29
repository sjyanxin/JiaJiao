﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JiaJiao.Web.Class
{
    public partial class Class : System.Web.UI.Page
    {


        JiaJiao.BLL.Class bll = new JiaJiao.BLL.Class();
        public List<Model.Teacher> teachers;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gridView.BorderColor = ColorTranslator.FromHtml(Application[Session["Style"].ToString() + "xtable_bordercolorlight"].ToString());
                gridView.HeaderStyle.BackColor = ColorTranslator.FromHtml(Application[Session["Style"].ToString() + "xtable_titlebgcolor"].ToString());
                BindData();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string idlist = GetSelIDlist();
            if (idlist.Trim().Length == 0)
                return;
            bll.DeleteList(idlist);
            BindData();
        }

        #region gridView

     

        public void BindData()
        {
            List<JiaJiao.Model.ClassInfo> list = new List<JiaJiao.Model.ClassInfo>();
            JiaJiao.BLL.Teacher bllTeacher = new JiaJiao.BLL.Teacher();
            JiaJiao.BLL.ClassSetting classSetting=new BLL.ClassSetting();

            var classlist = bll.GetModelList("").GroupBy(key => key.Day);
            foreach (var item in classlist)
            {
                list.Add(new JiaJiao.Model.ClassInfo() { Day = item.Key });
            }
           

           var teacherlist = bllTeacher.GetModelList("");
           teachers = teacherlist;
           var clsSetting = classSetting.GetModelList("").GroupBy(key => key.DayId);
           int index = 0;
           
           foreach (var item in classlist)
           {
               int index1 = 0;
               foreach (var item0 in item)
               {
                  var templist =clsSetting.Where(key => key.Key == item0.ID);
                  if (templist.Count() > 0)
                  {
                      foreach (var item1 in templist.FirstOrDefault())
                      {
                         var teacher=  teacherlist.Where(t => t.ID == item1.TeacherId).FirstOrDefault();
                         if (teacher != null)
                         {
                             switch (index1)
                             {
                                 case 0:
                                     list[index].Time1 += teacher.TeacherName+" ";
                                     break;
                                 case 1:
                                     list[index].Time2 += teacher.TeacherName + " ";
                                     break;
                                 case 2:
                                     list[index].Time3 += teacher.TeacherName + " ";
                                     break;
                                 case 3:
                                     list[index].Time4 += teacher.TeacherName + " ";
                                     break;
                                 case 4:
                                     list[index].Time5 += teacher.TeacherName + " ";
                                     break;
                                 case 5:
                                     list[index].Time6 += teacher.TeacherName + " ";
                                     break;
                                 case 6:
                                     list[index].Time7 += teacher.TeacherName + " ";
                                     break;
                             }  

                         }
                      }
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
                LinkButton linkbtnDel = (LinkButton)e.Row.FindControl("LinkButton1");
                linkbtnDel.Attributes.Add("onclick", "return confirm(\"你确认要删除吗\")");

                //object obj1 = DataBinder.Eval(e.Row.DataItem, "Levels");
                //if ((obj1 != null) && ((obj1.ToString() != "")))
                //{
                //    e.Row.Cells[1].Text = obj1.ToString();
                //}

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