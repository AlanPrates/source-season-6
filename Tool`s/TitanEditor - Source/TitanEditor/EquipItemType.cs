using System;
using System.Collections;

namespace TitanEditor
{
	// Token: 0x0200000C RID: 12
	public class EquipItemType
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00002DAC File Offset: 0x00000FAC
		public EquipItemType()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000B597 File Offset: 0x00009797
		public EquipItemType(byte typeId, string name)
		{
			this.typeId = typeId;
			this.name = name;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000B5AD File Offset: 0x000097AD
		public byte TypeId
		{
			get
			{
				return this.typeId;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000B5B5 File Offset: 0x000097B5
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000B5BD File Offset: 0x000097BD
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000B5C5 File Offset: 0x000097C5
		public IList ItemNames
		{
			get
			{
				return this.itemNames;
			}
			set
			{
				this.itemNames = value;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000B5B5 File Offset: 0x000097B5
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x0400009A RID: 154
		private byte typeId;

		// Token: 0x0400009B RID: 155
		private string name;

		// Token: 0x0400009C RID: 156
		private IList itemNames;
	}
}
