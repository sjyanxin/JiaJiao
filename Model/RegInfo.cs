using System;
namespace JiaJiao.Model
{
	/// <summary>
	/// RegInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RegInfo
	{
		public RegInfo()
		{}
		#region Model
		private int _id;
		private int? _teacherid;
		private int? _dayid;
		private string _stuid;
		private DateTime? _createtime;
		private DateTime? _updatetime;
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
		public int? TeacherId
		{
			set{ _teacherid=value;}
			get{return _teacherid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DayId
		{
			set{ _dayid=value;}
			get{return _dayid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StuId
		{
			set{ _stuid=value;}
			get{return _stuid;}
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
		#endregion Model

	}
}

