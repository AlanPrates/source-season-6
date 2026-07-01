using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace TitanEditor
{
	// Token: 0x0200000A RID: 10
	public class EquipImageCache
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000A5E9 File Offset: 0x000087E9
		private EquipImageCache()
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000A5FC File Offset: 0x000087FC
		public static EquipImageCache Instance
		{
			get
			{
				return EquipImageCache.Nested.instance;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000A604 File Offset: 0x00008804
		public EquipItem getItem(string name)
		{
			EquipItem equipItem = null;
			if ((equipItem = (EquipItem)this.cache[name]) == null)
			{
				Hashtable obj = this.cache;
				lock (obj)
				{
					if ((equipItem = (EquipItem)this.cache[name]) == null)
					{
						string sql = string.Format("select UniQue, Name, Hand, Type, Wide, High, DW, DK, ELF, MG, DL, SU, RF, Pic from MuItem where Name = '{0}'", name);
						equipItem = this.getItemFromDb(sql);
						if (equipItem == null)
						{
							equipItem = EquipItem.UnknownItem;
						}
						this.cache[name] = equipItem;
						this.cache[equipItem.CodeType] = equipItem;
					}
				}
			}
			return equipItem;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000A6A0 File Offset: 0x000088A0
		public EquipItem getItemByCodeType(string codeType)
		{
			EquipItem equipItem = null;
			if ((equipItem = (EquipItem)this.cache[codeType]) == null)
			{
				Hashtable obj = this.cache;
				lock (obj)
				{
					if ((equipItem = (EquipItem)this.cache[codeType]) == null)
					{
						try
						{
							string sql = string.Format("select UniQue, Name, Hand, Type, Wide, High, DW, DK, ELF, MG, DL, SU, RF, Pic from MuItem where UniQue = {0} and Type = {1}", EquipItem.getItemCode(codeType), EquipItem.getItemType(codeType));
							equipItem = this.getItemFromDb(sql);
							if (equipItem == null)
							{
								equipItem = (equipItem = EquipItem.UnknownItem);
							}
							this.cache[codeType] = equipItem;
							this.cache[equipItem.Name] = equipItem;
						}
						catch (Exception)
						{
							MessageBox.Show(string.Concat(new object[]
							{
								"Item: [",
								EquipItem.getItemType(codeType),
								", ",
								EquipItem.getItemCode(codeType),
								"]. Doesnt exist in DB"
							}), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
				}
			}
			return equipItem;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000A7B8 File Offset: 0x000089B8
		protected EquipItem getItemFromDb(string sql)
		{
			EquipItem equipItem = null;
			try
			{
				DBLite.mdb.Read(sql);
				DBLite.mdb.Fetch();
				int profs = DBLite.mdb.GetAsInteger("DW") + DBLite.mdb.GetAsInteger("DK") << 1 + DBLite.mdb.GetAsInteger("ELF") << 2 + DBLite.mdb.GetAsInteger("MG") << 3 + DBLite.mdb.GetAsInteger("DL") << 4 + DBLite.mdb.GetAsInteger("SU") << 5 + DBLite.mdb.GetAsInteger("RF") << 6;
				equipItem = new EquipItem(DBLite.mdb.GetAsInteger("UniQue"), DBLite.mdb.GetAsString("Name"), DBLite.mdb.GetAsInteger("Hand"), DBLite.mdb.GetAsInteger("Type"), DBLite.mdb.GetAsInteger("Wide"), DBLite.mdb.GetAsInteger("High"), profs);
				if (File.Exists(string.Concat(new object[]
				{
					Application.StartupPath,
					"\\items\\",
					DBLite.mdb.GetAsInteger("Type"),
					"\\",
					DBLite.mdb.GetAsInteger("UniQue"),
					".jpg"
				})))
				{
					equipItem.Img = Image.FromFile(string.Concat(new object[]
					{
						Application.StartupPath,
						"\\items\\",
						DBLite.mdb.GetAsInteger("Type"),
						"\\",
						DBLite.mdb.GetAsInteger("UniQue"),
						".jpg"
					}));
				}
				else
				{
					ResourceManager resourceManager = new ResourceManager("TitanEditor.Properties.Resources", Assembly.GetExecutingAssembly());
					equipItem.Img = (Image)resourceManager.GetObject("unknownItem");
				}
				DBLite.mdb.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Concat(new string[]
				{
					"MDB Query:",
					sql,
					"\nError:",
					ex.Message,
					"\nSource:",
					ex.Source,
					"\nTrace:",
					ex.StackTrace
				}));
			}
			return equipItem;
		}

		// Token: 0x0400008F RID: 143
		private Hashtable cache = new Hashtable();

		// Token: 0x02000024 RID: 36
		private class Nested
		{
			// Token: 0x0400020B RID: 523
			internal static readonly EquipImageCache instance = new EquipImageCache();
		}
	}
}
