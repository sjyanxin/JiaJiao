/**  版本信息模板在安装目录下，可自行修改。
* Teacher.cs
*
* 功 能： N/A
* 类 名： Teacher
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/5/8 15:19:37   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace JiaJiao.Model
{
	/// <summary>
	/// Teacher:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Teacher
	{
		public Teacher()
		{}
		#region Model
		private int _id;
		private string _teachername;
		private string _teachertel;
		private string _teacheremail;
		private string _teacheraddress;
		private string _teacherdescribe;
		private int? _roleid;
		private DateTime? _createtime;
		private DateTime? _updatetime;
		private string _image;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TeacherName
		{
			set{ _teachername=value;}
			get{return _teachername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TeacherTel
		{
			set{ _teachertel=value;}
			get{return _teachertel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TeacherEmail
		{
			set{ _teacheremail=value;}
			get{return _teacheremail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TeacherAddress
		{
			set{ _teacheraddress=value;}
			get{return _teacheraddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TeacherDescribe
		{
			set{ _teacherdescribe=value;}
			get{return _teacherdescribe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Image
		{
			set{ _image=value;}
			get{return _image;}
		}
		#endregion Model

	}
}

