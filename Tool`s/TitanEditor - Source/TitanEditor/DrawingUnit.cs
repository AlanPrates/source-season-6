using System;

namespace TitanEditor
{
	// Token: 0x0200000F RID: 15
	public class DrawingUnit
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000CB5F File Offset: 0x0000AD5F
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000CB67 File Offset: 0x0000AD67
		public int Status
		{
			get
			{
				return this.status;
			}
			set
			{
				this.status = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000CB70 File Offset: 0x0000AD70
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000CB78 File Offset: 0x0000AD78
		public EquipItem Item
		{
			get
			{
				return this.item;
			}
			set
			{
				this.item = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000CB81 File Offset: 0x0000AD81
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000CB89 File Offset: 0x0000AD89
		public int X
		{
			get
			{
				return this.x;
			}
			set
			{
				this.x = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000CB92 File Offset: 0x0000AD92
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000CB9A File Offset: 0x0000AD9A
		public int Y
		{
			get
			{
				return this.y;
			}
			set
			{
				this.y = value;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002DAC File Offset: 0x00000FAC
		public DrawingUnit()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000CBA3 File Offset: 0x0000ADA3
		public DrawingUnit(EquipItem item)
		{
			this.item = item;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000CBB2 File Offset: 0x0000ADB2
		public DrawingUnit(EquipItem item, int x, int y)
		{
			this.item = item;
			this.x = x;
			this.y = y;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000CBCF File Offset: 0x0000ADCF
		public void assign(DrawingUnit unit)
		{
			this.x = unit.X;
			this.y = unit.Y;
			this.item = unit.Item;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000CBF5 File Offset: 0x0000ADF5
		public bool contains(int xx, int yy)
		{
			return this.x <= xx && this.y <= yy && this.x + this.item.Width > xx && this.y + this.item.Height > yy;
		}

		// Token: 0x040000B5 RID: 181
		public const int STATUS_DOWN = 0;

		// Token: 0x040000B6 RID: 182
		public const int STATUS_COVER = 1;

		// Token: 0x040000B7 RID: 183
		public const int STATUS_HOVER = 2;

		// Token: 0x040000B8 RID: 184
		private EquipItem item;

		// Token: 0x040000B9 RID: 185
		private int x;

		// Token: 0x040000BA RID: 186
		private int y;

		// Token: 0x040000BB RID: 187
		private int status;
	}
}
