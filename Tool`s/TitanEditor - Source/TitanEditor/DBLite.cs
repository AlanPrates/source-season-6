using System;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace TitanEditor
{
	// Token: 0x02000002 RID: 2
	public class DBLite
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public DBLite(byte ConnectionType)
		{
			if (ConnectionType == 1)
			{
				this.OdbcCon = new OdbcConnection();
				this.ConType = 1;
				return;
			}
			if (ConnectionType == 3)
			{
				this.SqlCon = new SqlConnection();
				this.ConType = 3;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002085 File Offset: 0x00000285
		public DBLite(string path, string password)
		{
			this.Path = path;
			this.OdbcCon = new OdbcConnection();
			this.Password = password;
			this.ConType = 2;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020B0 File Offset: 0x000002B0
		public bool Connect()
		{
			try
			{
				this.ExError = new Exception();
				if (this.Password == "")
				{
					this.ConFormat = "Driver={Microsoft Access Driver (*.mdb)};DBQ=" + this.Path + ";";
				}
				else
				{
					this.ConFormat = string.Format("Provider=MSDASQL;Driver={Microsoft Access Driver (*.mdb)};Dbq={0};Jet OLEDB:Database Password={1}", this.Path, this.Password);
				}
				this.OdbcCon.ConnectionString = this.ConFormat;
				this.OdbcCon.Open();
				this.OdbcCon.Close();
			}
			catch (Exception exError)
			{
				this.ExError = exError;
				return false;
			}
			finally
			{
				if (this.OdbcCon.State != ConnectionState.Closed)
				{
					this.OdbcCon.Close();
				}
			}
			return true;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002180 File Offset: 0x00000380
		public bool Connect(string Server, string DataBase, string User, string Password)
		{
			bool result;
			try
			{
				this.ExError = new Exception();
				string connectionString = string.Concat(new string[]
				{
					"Data Source=",
					Server,
					";Initial Catalog=",
					DataBase,
					";User Id=",
					User,
					";Password=",
					Password,
					";"
				});
				this.SqlCon.ConnectionString = connectionString;
				this.SqlCon.Open();
				this.SqlCon.Close();
				result = true;
			}
			catch (Exception exError)
			{
				this.ExError = exError;
				result = false;
			}
			finally
			{
				if (this.SqlCon.State != ConnectionState.Closed)
				{
					this.SqlCon.Close();
				}
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002248 File Offset: 0x00000448
		public bool Connect(string DNS, string Login, string Password)
		{
			bool result;
			try
			{
				this.ExError = new Exception();
				string connectionString = string.Concat(new string[]
				{
					"DSN=",
					DNS,
					";UID=",
					Login,
					";PWD=",
					Password,
					";"
				});
				this.OdbcCon.ConnectionString = connectionString;
				this.OdbcCon.Open();
				this.OdbcCon.Close();
				result = true;
			}
			catch (Exception exError)
			{
				this.ExError = exError;
				result = false;
			}
			finally
			{
				if (this.OdbcCon.State != ConnectionState.Closed)
				{
					this.OdbcCon.Close();
				}
			}
			return result;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002300 File Offset: 0x00000500
		public void Close()
		{
			switch (this.ConType)
			{
			case 1:
				if (this.OdbcCon.State != ConnectionState.Closed)
				{
					this.OdbcCon.Close();
				}
				if (this.Odbcdr != null && !this.Odbcdr.IsClosed)
				{
					this.Odbcdr.Close();
					return;
				}
				break;
			case 2:
				if (this.OdbcCon.State != ConnectionState.Closed)
				{
					this.OdbcCon.Close();
				}
				if (this.OdbcCon != null && !this.Odbcdr.IsClosed)
				{
					this.Odbcdr.Close();
					return;
				}
				break;
			case 3:
				if (this.SqlCon.State != ConnectionState.Closed)
				{
					this.SqlCon.Close();
				}
				if (this.Sqldr != null && !this.Sqldr.IsClosed)
				{
					this.Sqldr.Close();
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000023D8 File Offset: 0x000005D8
		public bool Exec(string Query)
		{
			bool result;
			try
			{
				this.ExError = new Exception();
				switch (this.ConType)
				{
				case 1:
					this.OdbcCon.Open();
					new OdbcCommand(Query, this.OdbcCon).ExecuteNonQuery();
					break;
				case 2:
					this.OdbcCon.Open();
					new OdbcCommand(Query, this.OdbcCon).ExecuteNonQuery();
					break;
				case 3:
					this.SqlCon.Open();
					new SqlCommand(Query, this.SqlCon).ExecuteNonQuery();
					break;
				}
				result = true;
			}
			catch (Exception exError)
			{
				this.ExError = exError;
				result = false;
			}
			return result;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000248C File Offset: 0x0000068C
		public bool Read(string Query)
		{
			bool result;
			try
			{
				this.ExError = new Exception();
				switch (this.ConType)
				{
				case 1:
				{
					this.Odbcdr = null;
					OdbcCommand odbcCommand = new OdbcCommand(Query, this.OdbcCon);
					this.OdbcCon.Open();
					this.Odbcdr = odbcCommand.ExecuteReader();
					break;
				}
				case 2:
				{
					this.Odbcdr = null;
					OdbcCommand odbcCommand2 = new OdbcCommand(Query, this.OdbcCon);
					this.OdbcCon.Open();
					this.Odbcdr = odbcCommand2.ExecuteReader();
					break;
				}
				case 3:
				{
					this.Sqldr = null;
					SqlCommand sqlCommand = new SqlCommand(Query, this.SqlCon);
					this.SqlCon.Open();
					this.Sqldr = sqlCommand.ExecuteReader();
					break;
				}
				}
				result = true;
			}
			catch (Exception exError)
			{
				this.ExError = exError;
				result = false;
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002578 File Offset: 0x00000778
		public bool Fetch()
		{
			bool result;
			try
			{
				this.ExError = new Exception();
				switch (this.ConType)
				{
				case 1:
					if (this.Odbcdr != null)
					{
						return this.Odbcdr.Read();
					}
					break;
				case 2:
					if (this.Odbcdr != null)
					{
						return this.Odbcdr.Read();
					}
					break;
				case 3:
					if (this.Sqldr != null)
					{
						return this.Sqldr.Read();
					}
					break;
				}
				result = false;
			}
			catch (Exception exError)
			{
				this.ExError = exError;
				result = false;
			}
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002610 File Offset: 0x00000810
		public string GetAsString(string Row)
		{
			string result;
			try
			{
				this.ExError = new Exception();
				switch (this.ConType)
				{
				case 1:
					if (!this.Odbcdr.IsClosed)
					{
						for (int i = 0; i < this.Odbcdr.FieldCount; i++)
						{
							if (this.Odbcdr.GetName(i).ToUpper() == Row.ToUpper())
							{
								return this.Odbcdr[i].ToString();
							}
						}
					}
					break;
				case 2:
					if (!this.Odbcdr.IsClosed)
					{
						for (int j = 0; j < this.Odbcdr.FieldCount; j++)
						{
							if (this.Odbcdr.GetName(j).ToUpper() == Row.ToUpper())
							{
								return this.Odbcdr[j].ToString();
							}
						}
					}
					break;
				case 3:
					if (!this.Sqldr.IsClosed)
					{
						for (int k = 0; k < this.Sqldr.FieldCount; k++)
						{
							if (this.Sqldr.GetName(k).ToUpper() == Row.ToUpper())
							{
								return this.Sqldr[k].ToString();
							}
						}
					}
					break;
				}
				result = null;
			}
			catch (Exception exError)
			{
				this.ExError = exError;
				result = null;
			}
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002790 File Offset: 0x00000990
		public int GetAsInteger(string Row)
		{
			int result;
			try
			{
				this.ExError = new Exception();
				switch (this.ConType)
				{
				case 1:
					if (!this.Odbcdr.IsClosed)
					{
						for (int i = 0; i < this.Odbcdr.FieldCount; i++)
						{
							if (this.Odbcdr.GetName(i).ToUpper() == Row.ToUpper())
							{
								return Convert.ToInt32(this.Odbcdr[i]);
							}
						}
					}
					break;
				case 2:
					if (!this.Odbcdr.IsClosed)
					{
						for (int j = 0; j < this.Odbcdr.FieldCount; j++)
						{
							if (this.Odbcdr.GetName(j).ToUpper() == Row.ToUpper())
							{
								return Convert.ToInt32(this.Odbcdr[j]);
							}
						}
					}
					break;
				case 3:
					if (!this.Sqldr.IsClosed)
					{
						for (int k = 0; k < this.Sqldr.FieldCount; k++)
						{
							if (this.Sqldr.GetName(k).ToUpper() == Row.ToUpper())
							{
								return Convert.ToInt32(this.Sqldr[k]);
							}
						}
					}
					break;
				}
				result = 0;
			}
			catch (Exception exError)
			{
				this.ExError = exError;
				result = 0;
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002910 File Offset: 0x00000B10
		public long GetAsInteger64(string Row)
		{
			long result;
			try
			{
				this.ExError = new Exception();
				switch (this.ConType)
				{
				case 1:
					if (!this.Odbcdr.IsClosed)
					{
						for (int i = 0; i < this.Odbcdr.FieldCount; i++)
						{
							if (this.Odbcdr.GetName(i).ToUpper() == Row.ToUpper())
							{
								return Convert.ToInt64(this.Odbcdr[i]);
							}
						}
					}
					break;
				case 2:
					if (!this.Odbcdr.IsClosed)
					{
						for (int j = 0; j < this.Odbcdr.FieldCount; j++)
						{
							if (this.Odbcdr.GetName(j).ToUpper() == Row.ToUpper())
							{
								return Convert.ToInt64(this.Odbcdr[j]);
							}
						}
					}
					break;
				case 3:
					if (!this.Sqldr.IsClosed)
					{
						for (int k = 0; k < this.Sqldr.FieldCount; k++)
						{
							if (this.Sqldr.GetName(k).ToUpper() == Row.ToUpper())
							{
								return Convert.ToInt64(this.Sqldr[k]);
							}
						}
					}
					break;
				}
				result = 0L;
			}
			catch (Exception exError)
			{
				this.ExError = exError;
				result = 0L;
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002A94 File Offset: 0x00000C94
		public float GetAsFloat(string Row)
		{
			float result;
			try
			{
				this.ExError = new Exception();
				switch (this.ConType)
				{
				case 1:
					if (!this.Odbcdr.IsClosed)
					{
						for (int i = 0; i < this.Odbcdr.FieldCount; i++)
						{
							if (this.Odbcdr.GetName(i).ToUpper() == Row.ToUpper())
							{
								return float.Parse(this.Odbcdr[i].ToString());
							}
						}
					}
					break;
				case 2:
					if (!this.Odbcdr.IsClosed)
					{
						for (int j = 0; j < this.Odbcdr.FieldCount; j++)
						{
							if (this.Odbcdr.GetName(j).ToUpper() == Row.ToUpper())
							{
								return float.Parse(this.Odbcdr[j].ToString());
							}
						}
					}
					break;
				case 3:
					if (!this.Sqldr.IsClosed)
					{
						for (int k = 0; k < this.Sqldr.FieldCount; k++)
						{
							if (this.Sqldr.GetName(k).ToUpper() == Row.ToUpper())
							{
								return float.Parse(this.Sqldr[k].ToString());
							}
						}
					}
					break;
				}
				result = 0f;
			}
			catch (Exception exError)
			{
				this.ExError = exError;
				result = 0f;
			}
			return result;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002C2C File Offset: 0x00000E2C
		public byte[] GetAsBinary(string Row)
		{
			byte[] result;
			try
			{
				this.ExError = new Exception();
				switch (this.ConType)
				{
				case 1:
					if (!this.Odbcdr.IsClosed)
					{
						for (int i = 0; i < this.Odbcdr.FieldCount; i++)
						{
							if (this.Odbcdr.GetName(i).ToUpper() == Row.ToUpper())
							{
								return (byte[])this.Odbcdr[i];
							}
						}
					}
					break;
				case 2:
					if (!this.Odbcdr.IsClosed)
					{
						for (int j = 0; j < this.Odbcdr.FieldCount; j++)
						{
							if (this.Odbcdr.GetName(j).ToUpper() == Row.ToUpper())
							{
								return (byte[])this.Odbcdr[j];
							}
						}
					}
					break;
				case 3:
					if (!this.Sqldr.IsClosed)
					{
						for (int k = 0; k < this.Sqldr.FieldCount; k++)
						{
							if (this.Sqldr.GetName(k).ToUpper() == Row.ToUpper())
							{
								return (byte[])this.Sqldr[k];
							}
						}
					}
					break;
				}
				result = null;
			}
			catch (Exception exError)
			{
				this.ExError = exError;
				result = null;
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		public OdbcConnection OdbcCon;

		// Token: 0x04000002 RID: 2
		private OdbcDataReader Odbcdr;

		// Token: 0x04000003 RID: 3
		public SqlConnection SqlCon;

		// Token: 0x04000004 RID: 4
		private SqlDataReader Sqldr;

		// Token: 0x04000005 RID: 5
		public Exception ExError;

		// Token: 0x04000006 RID: 6
		private byte ConType;

		// Token: 0x04000007 RID: 7
		private string Path;

		// Token: 0x04000008 RID: 8
		private string Password;

		// Token: 0x04000009 RID: 9
		private string ConFormat;

		// Token: 0x0400000A RID: 10
		public static DBLite dbMu;

		// Token: 0x0400000B RID: 11
		public static DBLite dbMe;

		// Token: 0x0400000C RID: 12
		public static DBLite mdb;
	}
}
