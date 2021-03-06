﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSoiSo.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SoiSo")]
	public partial class CS3MDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public CS3MDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SoiSoConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CS3MDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CS3MDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CS3MDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CS3MDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CS_DangKyTaiKhoan")]
		public ISingleResult<CS_DangKyTaiKhoanResult> CS_DangKyTaiKhoan([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nickname", DbType="VarChar(20)")] string nickname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Number", DbType="VarChar(20)")] string number, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="VarChar(50)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(100)")] string email)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nickname, number, password, email);
			return ((ISingleResult<CS_DangKyTaiKhoanResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CS_DangNhap")]
		public ISingleResult<CS_DangNhapResult> CS_DangNhap([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nickname", DbType="VarChar(20)")] string nickname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="VarChar(50)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nickname, password);
			return ((ISingleResult<CS_DangNhapResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CS_GetKQXS")]
		public ISingleResult<CS_GetKQXSResult> CS_GetKQXS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Area", DbType="VarChar(20)")] string area, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NgayXo", DbType="DateTime")] System.Nullable<System.DateTime> ngayXo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), area, ngayXo);
			return ((ISingleResult<CS_GetKQXSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CS_AdminGetKQXS")]
		public ISingleResult<CS_AdminGetKQXSResult> CS_AdminGetKQXS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<CS_AdminGetKQXSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CS_AdminGetChiTietKQXS")]
		public ISingleResult<CS_AdminGetChiTietKQXSResult> CS_AdminGetChiTietKQXS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdKQXS", DbType="Int")] System.Nullable<int> idKQXS)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idKQXS);
			return ((ISingleResult<CS_AdminGetChiTietKQXSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CS_AdminInsertKQXS")]
		public ISingleResult<CS_AdminInsertKQXSResult> CS_AdminInsertKQXS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdArea", DbType="Int")] System.Nullable<int> idArea, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NgayXo", DbType="DateTime")] System.Nullable<System.DateTime> ngayXo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DateCreate", DbType="DateTime")] System.Nullable<System.DateTime> dateCreate, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserCreate", DbType="NVarChar(50)")] string userCreate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idArea, ngayXo, dateCreate, userCreate);
			return ((ISingleResult<CS_AdminInsertKQXSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CS_AdminGetAllArea")]
		public ISingleResult<CS_AdminGetAllAreaResult> CS_AdminGetAllArea()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<CS_AdminGetAllAreaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CS_AdminInsertChiTietKQXS")]
		public ISingleResult<CS_AdminInsertChiTietKQXSResult> CS_AdminInsertChiTietKQXS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdKQXS", DbType="Int")] System.Nullable<int> idKQXS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenGiai", DbType="VarChar(10)")] string tenGiai, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="So", DbType="VarChar(10)")] string so, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ViTriDoXanh", DbType="VarChar(10)")] string viTriDoXanh)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idKQXS, tenGiai, so, viTriDoXanh);
			return ((ISingleResult<CS_AdminInsertChiTietKQXSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CS_GetDauDuoi")]
		public ISingleResult<CS_GetDauDuoiResult> CS_GetDauDuoi([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Area", DbType="VarChar(20)")] string area, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NgayXo", DbType="DateTime")] System.Nullable<System.DateTime> ngayXo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), area, ngayXo);
			return ((ISingleResult<CS_GetDauDuoiResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CS_GetSoXuatHien")]
		public ISingleResult<CS_GetSoXuatHienResult> CS_GetSoXuatHien([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Area", DbType="VarChar(20)")] string area, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NgayXo", DbType="DateTime")] System.Nullable<System.DateTime> ngayXo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), area, ngayXo);
			return ((ISingleResult<CS_GetSoXuatHienResult>)(result.ReturnValue));
		}
	}
	
	public partial class CS_DangKyTaiKhoanResult
	{
		
		private int _Result;
		
		public CS_DangKyTaiKhoanResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Result", DbType="Int NOT NULL")]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				if ((this._Result != value))
				{
					this._Result = value;
				}
			}
		}
	}
	
	public partial class CS_DangNhapResult
	{
		
		private int _Result;
		
		public CS_DangNhapResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Result", DbType="Int NOT NULL")]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				if ((this._Result != value))
				{
					this._Result = value;
				}
			}
		}
	}
	
	public partial class CS_GetKQXSResult
	{
		
		private int _Id;
		
		private System.Nullable<System.DateTime> _NgayXo;
		
		private string _TenGiai;
		
		private string _So;
		
		private string _VitriDoXanh;
		
		private string _VitriXanh;
		
		public CS_GetKQXSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayXo", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayXo
		{
			get
			{
				return this._NgayXo;
			}
			set
			{
				if ((this._NgayXo != value))
				{
					this._NgayXo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenGiai", DbType="VarChar(10)")]
		public string TenGiai
		{
			get
			{
				return this._TenGiai;
			}
			set
			{
				if ((this._TenGiai != value))
				{
					this._TenGiai = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_So", DbType="VarChar(10)")]
		public string So
		{
			get
			{
				return this._So;
			}
			set
			{
				if ((this._So != value))
				{
					this._So = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VitriDoXanh", DbType="VarChar(10)")]
		public string VitriDoXanh
		{
			get
			{
				return this._VitriDoXanh;
			}
			set
			{
				if ((this._VitriDoXanh != value))
				{
					this._VitriDoXanh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VitriXanh", DbType="VarChar(10)")]
		public string VitriXanh
		{
			get
			{
				return this._VitriXanh;
			}
			set
			{
				if ((this._VitriXanh != value))
				{
					this._VitriXanh = value;
				}
			}
		}
	}
	
	public partial class CS_AdminGetKQXSResult
	{
		
		private int _Id;
		
		private System.Nullable<int> _IdArea;
		
		private System.Nullable<System.DateTime> _NgayXo;
		
		private System.Nullable<System.DateTime> _DateCreated;
		
		private string _UserCreated;
		
		private string _KhuVuc;
		
		private System.Nullable<int> _Added;
		
		public CS_AdminGetKQXSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdArea", DbType="Int")]
		public System.Nullable<int> IdArea
		{
			get
			{
				return this._IdArea;
			}
			set
			{
				if ((this._IdArea != value))
				{
					this._IdArea = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayXo", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayXo
		{
			get
			{
				return this._NgayXo;
			}
			set
			{
				if ((this._NgayXo != value))
				{
					this._NgayXo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this._DateCreated = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCreated", DbType="NVarChar(50)")]
		public string UserCreated
		{
			get
			{
				return this._UserCreated;
			}
			set
			{
				if ((this._UserCreated != value))
				{
					this._UserCreated = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KhuVuc", DbType="NVarChar(50)")]
		public string KhuVuc
		{
			get
			{
				return this._KhuVuc;
			}
			set
			{
				if ((this._KhuVuc != value))
				{
					this._KhuVuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Added", DbType="Int")]
		public System.Nullable<int> Added
		{
			get
			{
				return this._Added;
			}
			set
			{
				if ((this._Added != value))
				{
					this._Added = value;
				}
			}
		}
	}
	
	public partial class CS_AdminGetChiTietKQXSResult
	{
		
		private System.Nullable<int> _IdKQXS;
		
		private string _So;
		
		private string _TenGiai;
		
		private string _VitriDoXanh;
		
		public CS_AdminGetChiTietKQXSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdKQXS", DbType="Int")]
		public System.Nullable<int> IdKQXS
		{
			get
			{
				return this._IdKQXS;
			}
			set
			{
				if ((this._IdKQXS != value))
				{
					this._IdKQXS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_So", DbType="VarChar(10)")]
		public string So
		{
			get
			{
				return this._So;
			}
			set
			{
				if ((this._So != value))
				{
					this._So = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenGiai", DbType="VarChar(10)")]
		public string TenGiai
		{
			get
			{
				return this._TenGiai;
			}
			set
			{
				if ((this._TenGiai != value))
				{
					this._TenGiai = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VitriDoXanh", DbType="VarChar(10)")]
		public string VitriDoXanh
		{
			get
			{
				return this._VitriDoXanh;
			}
			set
			{
				if ((this._VitriDoXanh != value))
				{
					this._VitriDoXanh = value;
				}
			}
		}
	}
	
	public partial class CS_AdminInsertKQXSResult
	{
		
		private int _Result;
		
		public CS_AdminInsertKQXSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Result", DbType="Int NOT NULL")]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				if ((this._Result != value))
				{
					this._Result = value;
				}
			}
		}
	}
	
	public partial class CS_AdminGetAllAreaResult
	{
		
		private int _Id;
		
		private string _Area;
		
		public CS_AdminGetAllAreaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="NVarChar(50)")]
		public string Area
		{
			get
			{
				return this._Area;
			}
			set
			{
				if ((this._Area != value))
				{
					this._Area = value;
				}
			}
		}
	}
	
	public partial class CS_AdminInsertChiTietKQXSResult
	{
		
		private int _Result;
		
		public CS_AdminInsertChiTietKQXSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Result", DbType="Int NOT NULL")]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				if ((this._Result != value))
				{
					this._Result = value;
				}
			}
		}
	}
	
	public partial class CS_GetDauDuoiResult
	{
		
		private int _Id;
		
		private System.Nullable<int> _IdKQXS;
		
		private string _Dau0;
		
		private string _Dau1;
		
		private string _Dau2;
		
		private string _Dau3;
		
		private string _Dau4;
		
		private string _Dau5;
		
		private string _Dau6;
		
		private string _Dau7;
		
		private string _Dau8;
		
		private string _Dau9;
		
		private string _Duoi0;
		
		private string _Duoi1;
		
		private string _Duoi2;
		
		private string _Duoi3;
		
		private string _Duoi4;
		
		private string _Duoi5;
		
		private string _Duoi6;
		
		private string _Duoi7;
		
		private string _Duoi8;
		
		private string _Duoi9;
		
		private string _LoDo;
		
		public CS_GetDauDuoiResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdKQXS", DbType="Int")]
		public System.Nullable<int> IdKQXS
		{
			get
			{
				return this._IdKQXS;
			}
			set
			{
				if ((this._IdKQXS != value))
				{
					this._IdKQXS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dau0", DbType="VarChar(350)")]
		public string Dau0
		{
			get
			{
				return this._Dau0;
			}
			set
			{
				if ((this._Dau0 != value))
				{
					this._Dau0 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dau1", DbType="VarChar(350)")]
		public string Dau1
		{
			get
			{
				return this._Dau1;
			}
			set
			{
				if ((this._Dau1 != value))
				{
					this._Dau1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dau2", DbType="VarChar(350)")]
		public string Dau2
		{
			get
			{
				return this._Dau2;
			}
			set
			{
				if ((this._Dau2 != value))
				{
					this._Dau2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dau3", DbType="VarChar(350)")]
		public string Dau3
		{
			get
			{
				return this._Dau3;
			}
			set
			{
				if ((this._Dau3 != value))
				{
					this._Dau3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dau4", DbType="VarChar(350)")]
		public string Dau4
		{
			get
			{
				return this._Dau4;
			}
			set
			{
				if ((this._Dau4 != value))
				{
					this._Dau4 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dau5", DbType="VarChar(350)")]
		public string Dau5
		{
			get
			{
				return this._Dau5;
			}
			set
			{
				if ((this._Dau5 != value))
				{
					this._Dau5 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dau6", DbType="VarChar(350)")]
		public string Dau6
		{
			get
			{
				return this._Dau6;
			}
			set
			{
				if ((this._Dau6 != value))
				{
					this._Dau6 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dau7", DbType="VarChar(350)")]
		public string Dau7
		{
			get
			{
				return this._Dau7;
			}
			set
			{
				if ((this._Dau7 != value))
				{
					this._Dau7 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dau8", DbType="VarChar(350)")]
		public string Dau8
		{
			get
			{
				return this._Dau8;
			}
			set
			{
				if ((this._Dau8 != value))
				{
					this._Dau8 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dau9", DbType="VarChar(350)")]
		public string Dau9
		{
			get
			{
				return this._Dau9;
			}
			set
			{
				if ((this._Dau9 != value))
				{
					this._Dau9 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duoi0", DbType="VarChar(350)")]
		public string Duoi0
		{
			get
			{
				return this._Duoi0;
			}
			set
			{
				if ((this._Duoi0 != value))
				{
					this._Duoi0 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duoi1", DbType="VarChar(350)")]
		public string Duoi1
		{
			get
			{
				return this._Duoi1;
			}
			set
			{
				if ((this._Duoi1 != value))
				{
					this._Duoi1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duoi2", DbType="VarChar(350)")]
		public string Duoi2
		{
			get
			{
				return this._Duoi2;
			}
			set
			{
				if ((this._Duoi2 != value))
				{
					this._Duoi2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duoi3", DbType="VarChar(350)")]
		public string Duoi3
		{
			get
			{
				return this._Duoi3;
			}
			set
			{
				if ((this._Duoi3 != value))
				{
					this._Duoi3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duoi4", DbType="VarChar(350)")]
		public string Duoi4
		{
			get
			{
				return this._Duoi4;
			}
			set
			{
				if ((this._Duoi4 != value))
				{
					this._Duoi4 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duoi5", DbType="VarChar(350)")]
		public string Duoi5
		{
			get
			{
				return this._Duoi5;
			}
			set
			{
				if ((this._Duoi5 != value))
				{
					this._Duoi5 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duoi6", DbType="VarChar(350)")]
		public string Duoi6
		{
			get
			{
				return this._Duoi6;
			}
			set
			{
				if ((this._Duoi6 != value))
				{
					this._Duoi6 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duoi7", DbType="VarChar(350)")]
		public string Duoi7
		{
			get
			{
				return this._Duoi7;
			}
			set
			{
				if ((this._Duoi7 != value))
				{
					this._Duoi7 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duoi8", DbType="VarChar(350)")]
		public string Duoi8
		{
			get
			{
				return this._Duoi8;
			}
			set
			{
				if ((this._Duoi8 != value))
				{
					this._Duoi8 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duoi9", DbType="VarChar(350)")]
		public string Duoi9
		{
			get
			{
				return this._Duoi9;
			}
			set
			{
				if ((this._Duoi9 != value))
				{
					this._Duoi9 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoDo", DbType="VarChar(10)")]
		public string LoDo
		{
			get
			{
				return this._LoDo;
			}
			set
			{
				if ((this._LoDo != value))
				{
					this._LoDo = value;
				}
			}
		}
	}
	
	public partial class CS_GetSoXuatHienResult
	{
		
		private string _SoXuatHien;
		
		private System.Nullable<int> _SoLan;
		
		public CS_GetSoXuatHienResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoXuatHien", DbType="VarChar(50)")]
		public string SoXuatHien
		{
			get
			{
				return this._SoXuatHien;
			}
			set
			{
				if ((this._SoXuatHien != value))
				{
					this._SoXuatHien = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLan", DbType="Int")]
		public System.Nullable<int> SoLan
		{
			get
			{
				return this._SoLan;
			}
			set
			{
				if ((this._SoLan != value))
				{
					this._SoLan = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
