#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhoneManagerment_LINQtoSQL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PHONEDBMS")]
	public partial class QuanLyBanHangDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertPhone(Phone instance);
    partial void UpdatePhone(Phone instance);
    partial void DeletePhone(Phone instance);
    partial void InsertTransaction_Detail(Transaction_Detail instance);
    partial void UpdateTransaction_Detail(Transaction_Detail instance);
    partial void DeleteTransaction_Detail(Transaction_Detail instance);
    partial void InsertTransaction(Transaction instance);
    partial void UpdateTransaction(Transaction instance);
    partial void DeleteTransaction(Transaction instance);
    #endregion
		
		public QuanLyBanHangDataContext() : 
				base(global::PhoneManagerment_LINQtoSQL.Properties.Settings.Default.PHONEDBMSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyBanHangDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyBanHangDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyBanHangDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyBanHangDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
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
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Phone> Phones
		{
			get
			{
				return this.GetTable<Phone>();
			}
		}
		
		public System.Data.Linq.Table<Transaction_Detail> Transaction_Details
		{
			get
			{
				return this.GetTable<Transaction_Detail>();
			}
		}
		
		public System.Data.Linq.Table<Transaction> Transactions
		{
			get
			{
				return this.GetTable<Transaction>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Accounts")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _password;
		
		private EntitySet<Transaction> _Transactions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public Account()
		{
			this._Transactions = new EntitySet<Transaction>(new Action<Transaction>(this.attach_Transactions), new Action<Transaction>(this.detach_Transactions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Transaction", Storage="_Transactions", ThisKey="username", OtherKey="username")]
		public EntitySet<Transaction> Transactions
		{
			get
			{
				return this._Transactions;
			}
			set
			{
				this._Transactions.Assign(value);
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
		
		private void attach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Customer_Name;
		
		private string _PhoneNumber;
		
		private string _Address;
		
		private int _ID_customer;
		
		private string _Loyal_customer;
		
		private EntitySet<Transaction> _Transactions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomer_NameChanging(string value);
    partial void OnCustomer_NameChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnID_customerChanging(int value);
    partial void OnID_customerChanged();
    partial void OnLoyal_customerChanging(string value);
    partial void OnLoyal_customerChanged();
    #endregion
		
		public Customer()
		{
			this._Transactions = new EntitySet<Transaction>(new Action<Transaction>(this.attach_Transactions), new Action<Transaction>(this.detach_Transactions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Customer_Name
		{
			get
			{
				return this._Customer_Name;
			}
			set
			{
				if ((this._Customer_Name != value))
				{
					this.OnCustomer_NameChanging(value);
					this.SendPropertyChanging();
					this._Customer_Name = value;
					this.SendPropertyChanged("Customer_Name");
					this.OnCustomer_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_customer", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_customer
		{
			get
			{
				return this._ID_customer;
			}
			set
			{
				if ((this._ID_customer != value))
				{
					this.OnID_customerChanging(value);
					this.SendPropertyChanging();
					this._ID_customer = value;
					this.SendPropertyChanged("ID_customer");
					this.OnID_customerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Loyal_customer", DbType="VarChar(50)")]
		public string Loyal_customer
		{
			get
			{
				return this._Loyal_customer;
			}
			set
			{
				if ((this._Loyal_customer != value))
				{
					this.OnLoyal_customerChanging(value);
					this.SendPropertyChanging();
					this._Loyal_customer = value;
					this.SendPropertyChanged("Loyal_customer");
					this.OnLoyal_customerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Transaction", Storage="_Transactions", ThisKey="ID_customer", OtherKey="ID_customer")]
		public EntitySet<Transaction> Transactions
		{
			get
			{
				return this._Transactions;
			}
			set
			{
				this._Transactions.Assign(value);
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
		
		private void attach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Transactions(Transaction entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Phone")]
	public partial class Phone : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Model_Name;
		
		private string _ram;
		
		private string _Front_Camera;
		
		private string _Display;
		
		private string _Sim_Type;
		
		private string _Network_Type;
		
		private string _Price;
		
		private string _Finger;
		
		private string _istorage;
		
		private string _estorage;
		
		private string _Rear_Camera;
		
		private int _ID_phone;
		
		private EntitySet<Transaction_Detail> _Transaction_Details;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnModel_NameChanging(string value);
    partial void OnModel_NameChanged();
    partial void OnramChanging(string value);
    partial void OnramChanged();
    partial void OnFront_CameraChanging(string value);
    partial void OnFront_CameraChanged();
    partial void OnDisplayChanging(string value);
    partial void OnDisplayChanged();
    partial void OnSim_TypeChanging(string value);
    partial void OnSim_TypeChanged();
    partial void OnNetwork_TypeChanging(string value);
    partial void OnNetwork_TypeChanged();
    partial void OnPriceChanging(string value);
    partial void OnPriceChanged();
    partial void OnFingerChanging(string value);
    partial void OnFingerChanged();
    partial void OnistorageChanging(string value);
    partial void OnistorageChanged();
    partial void OnestorageChanging(string value);
    partial void OnestorageChanged();
    partial void OnRear_CameraChanging(string value);
    partial void OnRear_CameraChanged();
    partial void OnID_phoneChanging(int value);
    partial void OnID_phoneChanged();
    #endregion
		
		public Phone()
		{
			this._Transaction_Details = new EntitySet<Transaction_Detail>(new Action<Transaction_Detail>(this.attach_Transaction_Details), new Action<Transaction_Detail>(this.detach_Transaction_Details));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Model_Name
		{
			get
			{
				return this._Model_Name;
			}
			set
			{
				if ((this._Model_Name != value))
				{
					this.OnModel_NameChanging(value);
					this.SendPropertyChanging();
					this._Model_Name = value;
					this.SendPropertyChanged("Model_Name");
					this.OnModel_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ram", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ram
		{
			get
			{
				return this._ram;
			}
			set
			{
				if ((this._ram != value))
				{
					this.OnramChanging(value);
					this.SendPropertyChanging();
					this._ram = value;
					this.SendPropertyChanged("ram");
					this.OnramChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Front_Camera", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Front_Camera
		{
			get
			{
				return this._Front_Camera;
			}
			set
			{
				if ((this._Front_Camera != value))
				{
					this.OnFront_CameraChanging(value);
					this.SendPropertyChanging();
					this._Front_Camera = value;
					this.SendPropertyChanged("Front_Camera");
					this.OnFront_CameraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Display", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Display
		{
			get
			{
				return this._Display;
			}
			set
			{
				if ((this._Display != value))
				{
					this.OnDisplayChanging(value);
					this.SendPropertyChanging();
					this._Display = value;
					this.SendPropertyChanged("Display");
					this.OnDisplayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sim_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Sim_Type
		{
			get
			{
				return this._Sim_Type;
			}
			set
			{
				if ((this._Sim_Type != value))
				{
					this.OnSim_TypeChanging(value);
					this.SendPropertyChanging();
					this._Sim_Type = value;
					this.SendPropertyChanged("Sim_Type");
					this.OnSim_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Network_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Network_Type
		{
			get
			{
				return this._Network_Type;
			}
			set
			{
				if ((this._Network_Type != value))
				{
					this.OnNetwork_TypeChanging(value);
					this.SendPropertyChanging();
					this._Network_Type = value;
					this.SendPropertyChanged("Network_Type");
					this.OnNetwork_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Finger", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Finger
		{
			get
			{
				return this._Finger;
			}
			set
			{
				if ((this._Finger != value))
				{
					this.OnFingerChanging(value);
					this.SendPropertyChanging();
					this._Finger = value;
					this.SendPropertyChanged("Finger");
					this.OnFingerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_istorage", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string istorage
		{
			get
			{
				return this._istorage;
			}
			set
			{
				if ((this._istorage != value))
				{
					this.OnistorageChanging(value);
					this.SendPropertyChanging();
					this._istorage = value;
					this.SendPropertyChanged("istorage");
					this.OnistorageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estorage", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string estorage
		{
			get
			{
				return this._estorage;
			}
			set
			{
				if ((this._estorage != value))
				{
					this.OnestorageChanging(value);
					this.SendPropertyChanging();
					this._estorage = value;
					this.SendPropertyChanged("estorage");
					this.OnestorageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rear_Camera", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Rear_Camera
		{
			get
			{
				return this._Rear_Camera;
			}
			set
			{
				if ((this._Rear_Camera != value))
				{
					this.OnRear_CameraChanging(value);
					this.SendPropertyChanging();
					this._Rear_Camera = value;
					this.SendPropertyChanged("Rear_Camera");
					this.OnRear_CameraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_phone", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_phone
		{
			get
			{
				return this._ID_phone;
			}
			set
			{
				if ((this._ID_phone != value))
				{
					this.OnID_phoneChanging(value);
					this.SendPropertyChanging();
					this._ID_phone = value;
					this.SendPropertyChanged("ID_phone");
					this.OnID_phoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phone_Transaction_Detail", Storage="_Transaction_Details", ThisKey="ID_phone", OtherKey="ID_phone")]
		public EntitySet<Transaction_Detail> Transaction_Details
		{
			get
			{
				return this._Transaction_Details;
			}
			set
			{
				this._Transaction_Details.Assign(value);
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
		
		private void attach_Transaction_Details(Transaction_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Phone = this;
		}
		
		private void detach_Transaction_Details(Transaction_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Phone = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Transaction_Details")]
	public partial class Transaction_Detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _quantity;
		
		private int _ID_transaction;
		
		private int _ID_phone;
		
		private EntityRef<Phone> _Phone;
		
		private EntityRef<Transaction> _Transaction;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    partial void OnID_transactionChanging(int value);
    partial void OnID_transactionChanged();
    partial void OnID_phoneChanging(int value);
    partial void OnID_phoneChanged();
    #endregion
		
		public Transaction_Detail()
		{
			this._Phone = default(EntityRef<Phone>);
			this._Transaction = default(EntityRef<Transaction>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int")]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_transaction", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_transaction
		{
			get
			{
				return this._ID_transaction;
			}
			set
			{
				if ((this._ID_transaction != value))
				{
					if (this._Transaction.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_transactionChanging(value);
					this.SendPropertyChanging();
					this._ID_transaction = value;
					this.SendPropertyChanged("ID_transaction");
					this.OnID_transactionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_phone", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_phone
		{
			get
			{
				return this._ID_phone;
			}
			set
			{
				if ((this._ID_phone != value))
				{
					if (this._Phone.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_phoneChanging(value);
					this.SendPropertyChanging();
					this._ID_phone = value;
					this.SendPropertyChanged("ID_phone");
					this.OnID_phoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phone_Transaction_Detail", Storage="_Phone", ThisKey="ID_phone", OtherKey="ID_phone", IsForeignKey=true)]
		public Phone Phone
		{
			get
			{
				return this._Phone.Entity;
			}
			set
			{
				Phone previousValue = this._Phone.Entity;
				if (((previousValue != value) 
							|| (this._Phone.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Phone.Entity = null;
						previousValue.Transaction_Details.Remove(this);
					}
					this._Phone.Entity = value;
					if ((value != null))
					{
						value.Transaction_Details.Add(this);
						this._ID_phone = value.ID_phone;
					}
					else
					{
						this._ID_phone = default(int);
					}
					this.SendPropertyChanged("Phone");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transaction_Transaction_Detail", Storage="_Transaction", ThisKey="ID_transaction", OtherKey="ID_transaction", IsForeignKey=true)]
		public Transaction Transaction
		{
			get
			{
				return this._Transaction.Entity;
			}
			set
			{
				Transaction previousValue = this._Transaction.Entity;
				if (((previousValue != value) 
							|| (this._Transaction.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Transaction.Entity = null;
						previousValue.Transaction_Details.Remove(this);
					}
					this._Transaction.Entity = value;
					if ((value != null))
					{
						value.Transaction_Details.Add(this);
						this._ID_transaction = value.ID_transaction;
					}
					else
					{
						this._ID_transaction = default(int);
					}
					this.SendPropertyChanged("Transaction");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Transactions")]
	public partial class Transaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_transaction;
		
		private int _Total_price;
		
		private System.Nullable<System.DateTime> _Date;
		
		private int _ID_customer;
		
		private string _username;
		
		private EntitySet<Transaction_Detail> _Transaction_Details;
		
		private EntityRef<Customer> _Customer;
		
		private EntityRef<Account> _Account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_transactionChanging(int value);
    partial void OnID_transactionChanged();
    partial void OnTotal_priceChanging(int value);
    partial void OnTotal_priceChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    partial void OnID_customerChanging(int value);
    partial void OnID_customerChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    #endregion
		
		public Transaction()
		{
			this._Transaction_Details = new EntitySet<Transaction_Detail>(new Action<Transaction_Detail>(this.attach_Transaction_Details), new Action<Transaction_Detail>(this.detach_Transaction_Details));
			this._Customer = default(EntityRef<Customer>);
			this._Account = default(EntityRef<Account>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_transaction", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_transaction
		{
			get
			{
				return this._ID_transaction;
			}
			set
			{
				if ((this._ID_transaction != value))
				{
					this.OnID_transactionChanging(value);
					this.SendPropertyChanging();
					this._ID_transaction = value;
					this.SendPropertyChanged("ID_transaction");
					this.OnID_transactionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_price", DbType="Int NOT NULL")]
		public int Total_price
		{
			get
			{
				return this._Total_price;
			}
			set
			{
				if ((this._Total_price != value))
				{
					this.OnTotal_priceChanging(value);
					this.SendPropertyChanging();
					this._Total_price = value;
					this.SendPropertyChanged("Total_price");
					this.OnTotal_priceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_customer", DbType="Int NOT NULL")]
		public int ID_customer
		{
			get
			{
				return this._ID_customer;
			}
			set
			{
				if ((this._ID_customer != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_customerChanging(value);
					this.SendPropertyChanging();
					this._ID_customer = value;
					this.SendPropertyChanged("ID_customer");
					this.OnID_customerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					if (this._Account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transaction_Transaction_Detail", Storage="_Transaction_Details", ThisKey="ID_transaction", OtherKey="ID_transaction")]
		public EntitySet<Transaction_Detail> Transaction_Details
		{
			get
			{
				return this._Transaction_Details;
			}
			set
			{
				this._Transaction_Details.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Transaction", Storage="_Customer", ThisKey="ID_customer", OtherKey="ID_customer", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Transactions.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Transactions.Add(this);
						this._ID_customer = value.ID_customer;
					}
					else
					{
						this._ID_customer = default(int);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Transaction", Storage="_Account", ThisKey="username", OtherKey="username", IsForeignKey=true)]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.Transactions.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.Transactions.Add(this);
						this._username = value.username;
					}
					else
					{
						this._username = default(string);
					}
					this.SendPropertyChanged("Account");
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
		
		private void attach_Transaction_Details(Transaction_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Transaction = this;
		}
		
		private void detach_Transaction_Details(Transaction_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Transaction = null;
		}
	}
}
#pragma warning restore 1591
