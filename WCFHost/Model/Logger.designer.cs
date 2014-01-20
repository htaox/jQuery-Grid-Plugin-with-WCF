﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogServiceHost
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="DWH2008")]
	public partial class LoggerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public LoggerDataContext() : 	
            base(global::EZTier.LogServiceHost.Properties.Settings.Default.DWH2008ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LoggerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoggerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoggerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoggerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LOGGER> LOGGERs
		{
			get
			{
				return this.GetTable<LOGGER>();
			}
		}
	}
	
	[Table(Name="dbo.LOGGER")]
	public partial class LOGGER
	{
		
		private long _UID;
		
		private string _COMPANY;
		
		private int _COB_DATE;
		
		private System.Nullable<int> _PROCESS_ID;
		
		private string _FILE_NAME;
		
		private System.Nullable<System.DateTime> _DATE_AND_TIME;
		
		private string _ENTRY_TYPE;
		
		private string _MESSAGE;
		
		private string _RECORD_COUNT_SOURCE;
		
		private System.Nullable<int> _COUNT;
		
		public LOGGER()
		{
		}
		
		[Column(Storage="_UID", AutoSync=AutoSync.Always, DbType="BigInt NOT NULL IDENTITY", IsDbGenerated=true)]
		public long UID
		{
			get
			{
				return this._UID;
			}
			set
			{
				if ((this._UID != value))
				{
					this._UID = value;
				}
			}
		}
		
		[Column(Storage="_COMPANY", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string COMPANY
		{
			get
			{
				return this._COMPANY;
			}
			set
			{
				if ((this._COMPANY != value))
				{
					this._COMPANY = value;
				}
			}
		}
		
		[Column(Storage="_COB_DATE", DbType="Int NOT NULL")]
		public int COB_DATE
		{
			get
			{
				return this._COB_DATE;
			}
			set
			{
				if ((this._COB_DATE != value))
				{
					this._COB_DATE = value;
				}
			}
		}
		
		[Column(Storage="_PROCESS_ID", DbType="Int")]
		public System.Nullable<int> PROCESS_ID
		{
			get
			{
				return this._PROCESS_ID;
			}
			set
			{
				if ((this._PROCESS_ID != value))
				{
					this._PROCESS_ID = value;
				}
			}
		}
		
		[Column(Storage="_FILE_NAME", DbType="VarChar(50)")]
		public string FILE_NAME
		{
			get
			{
				return this._FILE_NAME;
			}
			set
			{
				if ((this._FILE_NAME != value))
				{
					this._FILE_NAME = value;
				}
			}
		}
		
		[Column(Storage="_DATE_AND_TIME", DbType="DateTime")]
		public System.Nullable<System.DateTime> DATE_AND_TIME
		{
			get
			{
				return this._DATE_AND_TIME;
			}
			set
			{
				if ((this._DATE_AND_TIME != value))
				{
					this._DATE_AND_TIME = value;
				}
			}
		}
		
		[Column(Storage="_ENTRY_TYPE", DbType="VarChar(5)")]
		public string ENTRY_TYPE
		{
			get
			{
				return this._ENTRY_TYPE;
			}
			set
			{
				if ((this._ENTRY_TYPE != value))
				{
					this._ENTRY_TYPE = value;
				}
			}
		}
		
		[Column(Storage="_MESSAGE", DbType="VarChar(4000)")]
		public string MESSAGE
		{
			get
			{
				return this._MESSAGE;
			}
			set
			{
				if ((this._MESSAGE != value))
				{
					this._MESSAGE = value;
				}
			}
		}
		
		[Column(Storage="_RECORD_COUNT_SOURCE", DbType="VarChar(15)")]
		public string RECORD_COUNT_SOURCE
		{
			get
			{
				return this._RECORD_COUNT_SOURCE;
			}
			set
			{
				if ((this._RECORD_COUNT_SOURCE != value))
				{
					this._RECORD_COUNT_SOURCE = value;
				}
			}
		}
		
		[Column(Storage="_COUNT", DbType="Int")]
		public System.Nullable<int> COUNT
		{
			get
			{
				return this._COUNT;
			}
			set
			{
				if ((this._COUNT != value))
				{
					this._COUNT = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
