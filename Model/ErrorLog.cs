using System;
namespace JiaJiao.Model
{
	/// <summary>
	/// ErrorLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ErrorLog
	{
		public ErrorLog()
		{}
		#region Model
		private int _id;
		private DateTime? _errortime;
		private string _errormessage;
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
		public DateTime? ErrorTime
		{
			set{ _errortime=value;}
			get{return _errortime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ErrorMessage
		{
			set{ _errormessage=value;}
			get{return _errormessage;}
		}
		#endregion Model

	}
}

