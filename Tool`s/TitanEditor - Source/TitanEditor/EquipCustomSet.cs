using System;
using System.Collections;

namespace TitanEditor
{
	// Token: 0x0200000D RID: 13
	public class EquipCustomSet
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000B5CE File Offset: 0x000097CE
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000B5D6 File Offset: 0x000097D6
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000B5DF File Offset: 0x000097DF
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000B5E7 File Offset: 0x000097E7
		public byte ClassType
		{
			get
			{
				return this.classType;
			}
			set
			{
				this.classType = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000B5F0 File Offset: 0x000097F0
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000B5F8 File Offset: 0x000097F8
		public byte MembLvl
		{
			get
			{
				return this.membLvl;
			}
			set
			{
				this.membLvl = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000B601 File Offset: 0x00009801
		public EquipItem[] Items
		{
			get
			{
				return this.items;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000B61E File Offset: 0x0000981E
		public bool setItem(int pos, string scodes)
		{
			if (pos < 0 || pos >= 13)
			{
				return false;
			}
			this.items[pos] = EquipItem.createItem(scodes);
			return this.items[pos] != null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000B644 File Offset: 0x00009844
		public bool setItems(IList items)
		{
			for (int i = 0; i < items.Count; i++)
			{
				this.items[i] = (EquipItem)items[i];
			}
			return true;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000B678 File Offset: 0x00009878
		public string[] getItemsCodes()
		{
			string[] array = new string[13];
			for (int i = 0; i < 13; i++)
			{
				if (this.items[i] == null)
				{
					array[i] = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
				}
				else
				{
					array[i] = this.items[i].ToString();
				}
			}
			return array;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000B5CE File Offset: 0x000097CE
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x0400009D RID: 157
		public const int MAX_ITEM_NUM = 13;

		// Token: 0x0400009E RID: 158
		private string name;

		// Token: 0x0400009F RID: 159
		private byte classType;

		// Token: 0x040000A0 RID: 160
		private byte membLvl;

		// Token: 0x040000A1 RID: 161
		private EquipItem[] items = new EquipItem[13];
	}
}
