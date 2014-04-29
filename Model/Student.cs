using System;
namespace JiaJiao.Model
{
	/// <summary>
	/// Student:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Student
	{
		public Student()
		{}
		#region Model
		private int _id;
		private string _stuname;
		private string _stuemail;
		private string _stutel;
		private string _stuaddress;
		private int? _roleid;
		private DateTime? _createtime;
		private DateTime? _updtetime;
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
		public string StuName
		{
			set{ _stuname=value;}
			get{return _stuname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StuEmail
		{
			set{ _stuemail=value;}
			get{return _stuemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StuTel
		{
			set{ _stutel=value;}
			get{return _stutel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StuAddress
		{
			set{ _stuaddress=value;}
			get{return _stuaddress;}
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
		public DateTime? UpdteTime
		{
			set{ _updtetime=value;}
			get{return _updtetime;}
		}
		#endregion Model

	}
}

