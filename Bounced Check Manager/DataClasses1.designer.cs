﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bounced_Check_Manager
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BouncedCheckManager")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Bounced_Check_Manager.Properties.Settings.Default.BouncedCheckManagerConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account2")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AccID;
		
		private int _AccNo;
		
		private string _AccName;
		
		private string _AccAddress;
		
		private int _AccRoutNo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAccIDChanging(int value);
    partial void OnAccIDChanged();
    partial void OnAccNoChanging(int value);
    partial void OnAccNoChanged();
    partial void OnAccNameChanging(string value);
    partial void OnAccNameChanged();
    partial void OnAccAddressChanging(string value);
    partial void OnAccAddressChanged();
    partial void OnAccRoutNoChanging(int value);
    partial void OnAccRoutNoChanged();
    #endregion
		
		public Account()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AccID
		{
			get
			{
				return this._AccID;
			}
			set
			{
				if ((this._AccID != value))
				{
					this.OnAccIDChanging(value);
					this.SendPropertyChanging();
					this._AccID = value;
					this.SendPropertyChanged("AccID");
					this.OnAccIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccNo", DbType="Int NOT NULL")]
		public int AccNo
		{
			get
			{
				return this._AccNo;
			}
			set
			{
				if ((this._AccNo != value))
				{
					this.OnAccNoChanging(value);
					this.SendPropertyChanging();
					this._AccNo = value;
					this.SendPropertyChanged("AccNo");
					this.OnAccNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string AccName
		{
			get
			{
				return this._AccName;
			}
			set
			{
				if ((this._AccName != value))
				{
					this.OnAccNameChanging(value);
					this.SendPropertyChanging();
					this._AccName = value;
					this.SendPropertyChanged("AccName");
					this.OnAccNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccAddress", DbType="NVarChar(50)")]
		public string AccAddress
		{
			get
			{
				return this._AccAddress;
			}
			set
			{
				if ((this._AccAddress != value))
				{
					this.OnAccAddressChanging(value);
					this.SendPropertyChanging();
					this._AccAddress = value;
					this.SendPropertyChanged("AccAddress");
					this.OnAccAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccRoutNo", DbType="Int NOT NULL")]
		public int AccRoutNo
		{
			get
			{
				return this._AccRoutNo;
			}
			set
			{
				if ((this._AccRoutNo != value))
				{
					this.OnAccRoutNoChanging(value);
					this.SendPropertyChanging();
					this._AccRoutNo = value;
					this.SendPropertyChanged("AccRoutNo");
					this.OnAccRoutNoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
