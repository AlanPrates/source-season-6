using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Text;

namespace TitanEditor
{
	// Token: 0x0200000B RID: 11
	public class EquipItem
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000AA34 File Offset: 0x00008C34
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000AA88 File Offset: 0x00008C88
		public long Serial
		{
			get
			{
				byte[] array = new byte[]
				{
					0,
					0,
					0,
					0,
					this.codes[3],
					this.codes[4],
					this.codes[5],
					this.codes[6]
				};
				if (BitConverter.IsLittleEndian)
				{
					Array.Reverse(array);
				}
				return BitConverter.ToInt64(array, 0);
			}
			set
			{
				byte[] bytes = BitConverter.GetBytes(value);
				if (BitConverter.IsLittleEndian)
				{
					Array.Reverse(bytes);
				}
				for (int i = 0; i < 4; i++)
				{
					this.codes[i + 3] = bytes[i + 4];
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000AAC4 File Offset: 0x00008CC4
		public long AutoSerialize()
		{
			long result;
			try
			{
				DBLite.dbMu.Read("EXEC WZ_GetItemSerial");
				DBLite.dbMu.Fetch();
				long asInteger = DBLite.dbMu.GetAsInteger64("");
				DBLite.dbMu.Close();
				result = asInteger;
			}
			catch (Exception)
			{
				result = 0L;
			}
			return result;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000AB20 File Offset: 0x00008D20
		public static EquipItem UnknownItem
		{
			get
			{
				return EquipItem.unknownItem;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000AB28 File Offset: 0x00008D28
		protected static EquipItem createUnknownItem()
		{
			EquipItem equipItem = new EquipItem();
			equipItem.Name = "unknownItem";
			equipItem.hand = 1;
			equipItem.profs = 255;
			ResourceManager resourceManager = new ResourceManager("TitanEditor.Properties.Resources", Assembly.GetExecutingAssembly());
			equipItem.Img = (Image)resourceManager.GetObject("unknownItem");
			return equipItem;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000AB7D File Offset: 0x00008D7D
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000AB85 File Offset: 0x00008D85
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (this.name != value)
				{
					this.name = value;
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000AB9C File Offset: 0x00008D9C
		public string CodeType
		{
			get
			{
				return EquipItem.getItemCodeType(this.codes);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000ABA9 File Offset: 0x00008DA9
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000ABB7 File Offset: 0x00008DB7
		public byte Type
		{
			get
			{
				return (byte)(this.codes[9] >> 4);
			}
			set
			{
				this.codes[9] = (byte) (this.codes[9] & 15);
				this.codes[9] = (byte)((int)this.codes[9] | (int)value << 4);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000ABE6 File Offset: 0x00008DE6
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		public byte Code
		{
			get
			{
				return this.codes[0];
			}
			set
			{
				if (this.codes[0] != value)
				{
					this.codes[0] = value;
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000AC06 File Offset: 0x00008E06
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0000AC0E File Offset: 0x00008E0E
		public Image Img
		{
			get
			{
				return this.img;
			}
			set
			{
				if (this.img != value)
				{
					this.img = value;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000AC20 File Offset: 0x00008E20
		public int Width
		{
			get
			{
				return this.xnum;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000AC28 File Offset: 0x00008E28
		public int Height
		{
			get
			{
				return this.ynum;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000AC30 File Offset: 0x00008E30
		public bool Hand
		{
			get
			{
				return this.hand == 1;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000AC3B File Offset: 0x00008E3B
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000AC4B File Offset: 0x00008E4B
		public byte Level
		{
			get
			{
				return (byte)((this.codes[1] & 120) >> 3);
			}
			set
			{
				this.modifyLevel((int)value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000AC54 File Offset: 0x00008E54
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000AC5F File Offset: 0x00008E5F
		public byte Harmony
		{
			get
			{
				return this.codes[10];
			}
			set
			{
				this.modifyHarmony((int)value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000AC68 File Offset: 0x00008E68
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000AC73 File Offset: 0x00008E73
		public byte Socket1
		{
			get
			{
				return this.codes[11];
			}
			set
			{
				this.modifySocket1((int)value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000AC7C File Offset: 0x00008E7C
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000AC87 File Offset: 0x00008E87
		public byte Socket2
		{
			get
			{
				return this.codes[12];
			}
			set
			{
				this.modifySocket2((int)value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000AC90 File Offset: 0x00008E90
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000AC9B File Offset: 0x00008E9B
		public byte Socket3
		{
			get
			{
				return this.codes[13];
			}
			set
			{
				this.modifySocket3((int)value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000ACAF File Offset: 0x00008EAF
		public byte Socket4
		{
			get
			{
				return this.codes[14];
			}
			set
			{
				this.modifySocket4((int)value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000ACB8 File Offset: 0x00008EB8
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000ACC3 File Offset: 0x00008EC3
		public byte Socket5
		{
			get
			{
				return this.codes[15];
			}
			set
			{
				this.modifySocket5((int)value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000ACCC File Offset: 0x00008ECC
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000ACE6 File Offset: 0x00008EE6
		public int Ext
		{
			get
			{
				return ((this.codes[7] & 64) >> 4) + (int)(this.codes[1] & 3);
			}
			set
			{
				this.modifyExt(value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000ACEF File Offset: 0x00008EEF
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000ACFE File Offset: 0x00008EFE
		public bool ZY1
		{
			get
			{
				return (this.codes[7] & 1) > 0;
			}
			set
			{
				this.modifyZY1(value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000AD07 File Offset: 0x00008F07
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000AD16 File Offset: 0x00008F16
		public bool ZY2
		{
			get
			{
				return (this.codes[7] & 2) > 0;
			}
			set
			{
				this.modifyZY2(value);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000AD1F File Offset: 0x00008F1F
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000AD2E File Offset: 0x00008F2E
		public bool ZY3
		{
			get
			{
				return (this.codes[7] & 4) > 0;
			}
			set
			{
				this.modifyZY3(value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000AD37 File Offset: 0x00008F37
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000AD46 File Offset: 0x00008F46
		public bool ZY4
		{
			get
			{
				return (this.codes[7] & 8) > 0;
			}
			set
			{
				this.modifyZY4(value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000AD4F File Offset: 0x00008F4F
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000AD5F File Offset: 0x00008F5F
		public bool ZY5
		{
			get
			{
				return (this.codes[7] & 16) > 0;
			}
			set
			{
				this.modifyZY5(value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000AD68 File Offset: 0x00008F68
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000AD78 File Offset: 0x00008F78
		public bool ZY6
		{
			get
			{
				return (this.codes[7] & 32) > 0;
			}
			set
			{
				this.modifyZY6(value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000AD81 File Offset: 0x00008F81
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000AD94 File Offset: 0x00008F94
		public bool JN
		{
			get
			{
				return (this.codes[1] & 128) > 0;
			}
			set
			{
				this.modifyJN(value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000AD9D File Offset: 0x00008F9D
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000ADAC File Offset: 0x00008FAC
		public bool XY
		{
			get
			{
				return (this.codes[1] & 4) > 0;
			}
			set
			{
				this.modifyXY(value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000ADB5 File Offset: 0x00008FB5
		public bool IsNoDurability
		{
			get
			{
				return this.codes[9] == 224;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000ADC7 File Offset: 0x00008FC7
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000ADD1 File Offset: 0x00008FD1
		public byte Durability
		{
			get
			{
				return this.codes[2];
			}
			set
			{
				this.codes[2] = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000ADDC File Offset: 0x00008FDC
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000AE13 File Offset: 0x00009013
		public byte Set
		{
			get
			{
				if (this.codes[8] <= 0)
				{
					return 0;
				}
				if (this.Type > 6)
				{
					return Convert.ToByte((int)(this.codes[8] % 4));
				}
				return Convert.ToByte((int)(this.codes[8] % 8));
			}
			set
			{
				if (value > 0)
				{
					this.codes[8] = value;
					if (this.Type > 6)
					{
						byte[] array = this.codes;
						int num = 8;
						array[num] |= 4;
						return;
					}
					byte[] array2 = this.codes;
					int num2 = 8;
					array2[num2] |= 8;
				}
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000AE50 File Offset: 0x00009050
		public EquipItem()
		{
			byte[] array = new byte[16];
			array[2] = byte.MaxValue;
            this.codes = array;
        }

		// Token: 0x060000AE RID: 174 RVA: 0x0000AE7C File Offset: 0x0000907C
		public EquipItem(EquipItem baseItem)
		{
			byte[] array = new byte[16];
			array[2] = byte.MaxValue;
            this.codes = array;
            this.xnum = baseItem.xnum;
			this.ynum = baseItem.ynum;
			this.name = baseItem.name;
			this.hand = baseItem.hand;
			this.profs = baseItem.profs;
			this.img = baseItem.img;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000AEFC File Offset: 0x000090FC
		public EquipItem(int code, string name, int hand, int type, int xnum, int ynum, int profs)
		{
			byte[] array = new byte[16];
			array[2] = byte.MaxValue;
			this.codes = array;
            this.Code = (byte)code;
			this.Type = (byte)type;
			this.name = name;
			this.hand = hand;
			this.xnum = xnum;
			this.ynum = ynum;
			this.profs = profs;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000AF6C File Offset: 0x0000916C
		public EquipItem(EquipItem baseItem, byte[] codes)
		{
			byte[] array = new byte[16];
			array[2] = byte.MaxValue;
			this.codes = array;
            this.xnum = baseItem.xnum;
			this.ynum = baseItem.ynum;
			this.name = baseItem.name;
			this.hand = baseItem.hand;
			this.profs = baseItem.profs;
			this.img = baseItem.img;
			codes.CopyTo(this.codes, 0);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000AFF8 File Offset: 0x000091F8
		public EquipItem(EquipItem baseItem, byte[] codes, int offset, int len)
		{
			byte[] array = new byte[16];
			array[2] = byte.MaxValue;
			this.codes = array;
            this.xnum = baseItem.xnum;
			this.ynum = baseItem.ynum;
			this.name = baseItem.name;
			this.hand = baseItem.hand;
			this.profs = baseItem.profs;
			this.img = baseItem.img;
			Array.Copy(codes, offset, this.codes, 0, len);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000B088 File Offset: 0x00009288
		public EquipItem assign(EquipItem other)
		{
			other.codes.CopyTo(this.codes, 0);
			this.xnum = other.xnum;
			this.ynum = other.ynum;
			this.name = other.name;
			this.hand = other.hand;
			this.profs = other.profs;
			this.img = other.img;
			return this;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000B0F0 File Offset: 0x000092F0
		public void modifyHarmony(int Value)
		{
			this.codes[10] = (byte)Value;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000B0FD File Offset: 0x000092FD
		public void modifySocket1(int Value)
		{
			this.codes[11] = (byte)Value;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000B10A File Offset: 0x0000930A
		public void modifySocket2(int Value)
		{
			this.codes[12] = (byte)Value;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000B117 File Offset: 0x00009317
		public void modifySocket3(int Value)
		{
			this.codes[13] = (byte)Value;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000B124 File Offset: 0x00009324
		public void modifySocket4(int Value)
		{
			this.codes[14] = (byte)Value;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000B131 File Offset: 0x00009331
		public void modifySocket5(int Value)
		{
			this.codes[15] = (byte)Value;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000B13E File Offset: 0x0000933E
		public void modifyLevel(int level)
		{
			this.codes[1] = (byte) (this.codes[1] & 135);
			this.codes[1] = (byte)((int)this.codes[1] | level << 3);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000B16C File Offset: 0x0000936C
		public void modifyExt(int ext)
		{
			this.codes[1] = (byte) (this.codes[1] & 252);
			this.codes[7] = (byte) (this.codes[7] & 191);
			byte b = (byte)(4 & ext);
			this.codes[7] = (byte)((int)this.codes[7] | (int)b << 4);
			ext = (3 & ext);
			this.codes[1] = (byte)((int)this.codes[1] | ext);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000B1D9 File Offset: 0x000093D9
		public void modifyZY1(bool flag)
		{
			if (flag)
			{
				this.codes[7] = (byte) (this.codes[7] | 1);
				return;
			}
			this.codes[7] = (byte) (this.codes[7] & 254);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000B209 File Offset: 0x00009409
		public void modifyZY2(bool flag)
		{
			if (flag)
			{
				this.codes[7] = (byte) (this.codes[7] | 2);
				return;
			}
			this.codes[7] = (byte) (this.codes[7] & 253);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000B239 File Offset: 0x00009439
		public void modifyZY3(bool flag)
		{
			if (flag)
			{
				this.codes[7] = (byte) (this.codes[7] | 4);
				return;
			}
			this.codes[7] = (byte) (this.codes[7] & 251);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000B269 File Offset: 0x00009469
		public void modifyZY4(bool flag)
		{
			if (flag)
			{
				this.codes[7] = (byte) (this.codes[7] | 8);
				return;
			}
			this.codes[7] = (byte) (this.codes[7] & 247);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000B299 File Offset: 0x00009499
		public void modifyZY5(bool flag)
		{
			if (flag)
			{
				this.codes[7] = (byte) (this.codes[7] | 16);
				return;
			}
			this.codes[7] = (byte) (this.codes[7] & 239);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000B2CA File Offset: 0x000094CA
		public void modifyZY6(bool flag)
		{
			if (flag)
			{
				this.codes[7] = (byte) (this.codes[7] | 32);
				return;
			}
			this.codes[7] = (byte) (this.codes[7] & 223);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000B2FB File Offset: 0x000094FB
		public void modifyXY(bool flag)
		{
			if (flag)
			{
				this.codes[1] = (byte) (this.codes[1] | 4);
				return;
			}
			this.codes[1] = (byte) (this.codes[1] & 251);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000B32B File Offset: 0x0000952B
		public void modifyJN(bool flag)
		{
			if (flag)
			{
				this.codes[1] = (byte) (this.codes[1] | 128);
				return;
			}
			this.codes[1] = (byte) (this.codes[1] & 127);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000B35C File Offset: 0x0000955C
		public byte[] getCodes()
		{
			return this.codes;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000B364 File Offset: 0x00009564
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < 16; i++)
			{
				stringBuilder.Append(this.codes[i].ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000B3A8 File Offset: 0x000095A8
		public static EquipItem createItem(string scodes)
		{
			if (scodes.Length != 32)
			{
				return null;
			}
			scodes = scodes.ToUpper();
			if (scodes.StartsWith("FF"))
			{
				return null;
			}
			byte[] array = new byte[16];
			try
			{
				for (int i = 0; i < 16; i++)
				{
					array[i] = Convert.ToByte(scodes.Substring(i * 2, 2), 16);
				}
			}
			catch (Exception)
			{
				return null;
			}
			return EquipItem.createItem(array);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000B420 File Offset: 0x00009620
		public static EquipItem createItem(byte[] codes)
		{
			return EquipItem.createItem(codes, 0, 16);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000B42C File Offset: 0x0000962C
		public static EquipItem createItem(byte[] codes, int offset, int len)
		{
			if (offset < 0 || len <= 0 || offset + len > codes.Length || codes[offset] == 255)
			{
				return null;
			}
			string itemCodeType = EquipItem.getItemCodeType(codes, offset, len);
			return new EquipItem(EquipImageCache.Instance.getItemByCodeType(itemCodeType), codes, offset, len);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000B474 File Offset: 0x00009674
		public static EquipItem createItem(byte code, byte type)
		{
			string itemCodeType = EquipItem.getItemCodeType(code, type);
			return new EquipItem(EquipImageCache.Instance.getItemByCodeType(itemCodeType));
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000B499 File Offset: 0x00009699
		public static string getItemCodeType(byte[] codes)
		{
			if (codes.Length < 16)
			{
				return null;
			}
			return string.Format("{0:X2}{1:X2}", codes[0], codes[9]);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000B4BF File Offset: 0x000096BF
		public static string getItemCodeType(byte[] codes, int offset, int len)
		{
			if (offset < 0 || len <= 0 || offset + len > codes.Length || len < 16)
			{
				return "unknownItem";
			}
			return string.Format("{0:X2}{1:X2}", codes[offset], codes[offset + 9] >> 4);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000B4FB File Offset: 0x000096FB
		public static string getItemCodeType(byte code, byte type)
		{
			return string.Format("{0:X2}{1:X2}", code, type);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000B513 File Offset: 0x00009713
		public static byte getItemCode(string codeType)
		{
			if (codeType == null || codeType == null)
			{
				return byte.MaxValue;
			}
			return Convert.ToByte(codeType.Substring(0, 2), 16);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000B530 File Offset: 0x00009730
		public static byte getItemType(string codeType)
		{
			if (codeType == null || codeType == null)
			{
				return 15;
			}
			return Convert.ToByte(codeType.Substring(2, 2), 16);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000B54C File Offset: 0x0000974C
		public static string toHex(byte[] codes, int offset, int len)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < len; i++)
			{
				stringBuilder.Append(codes[offset + i].ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000090 RID: 144
		public const string UNKNOW_ITEM = "unknownItem";

		// Token: 0x04000091 RID: 145
		public const int ITEM_SIZE = 16;

		// Token: 0x04000092 RID: 146
		private int xnum = 1;

		// Token: 0x04000093 RID: 147
		private int ynum = 1;

		// Token: 0x04000094 RID: 148
		private string name;

		// Token: 0x04000095 RID: 149
		private int hand;

		// Token: 0x04000096 RID: 150
		private int profs;

		// Token: 0x04000097 RID: 151
		private byte[] codes;

		// Token: 0x04000098 RID: 152
		private Image img;

		// Token: 0x04000099 RID: 153
		private static EquipItem unknownItem = EquipItem.createUnknownItem();
	}
}
