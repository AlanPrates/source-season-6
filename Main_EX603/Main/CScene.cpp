#include "stdafx.h"
#include "CScene.h"
#include "Offset.h"
#include "Util.h"
#include "Defines.h"
#include "LoginRemake.h"

// ---------------------------------------------------------------------------------------------
CSceneA gCSceneA;
// ---------------------------------------------------------------------------------------------

void CLoadBitmapA(char* Folder, int Code, int Arg3, int Arg4, int Arg5, int Arg6)
{
	LoadBitmapA("Logo\\Interface01.tga", 12, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\Interface02.tga", 13, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\Interface03.tga", 14, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\Interface04.tga", 15, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\Delete01.tga", 18, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\Delete02.jpg", 19, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\Ok01.tga", 22, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\Ok02.jpg", 21, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\New_Character201.tga", 16, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\New_Character202.jpg", 17, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\back1.jpg", 1741, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\back2.jpg", 1742, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\bkmoon.jpg", 1749, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\bkcloud.jpg", 1744, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\cloud.jpg", 1747, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Interface\\none.tga", 1748, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\New_Character01.tga", 23, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\New_Character02.tga", 24, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\New_Character001.jpg", 26, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\New_Character002.jpg", 27, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\New_Character_Cancel.jpg", 28, GL_NEAREST, GL_CLAMP, 1, 0);
	LoadBitmapA("Logo\\New_Character_Ok.jpg", 29, GL_NEAREST, GL_CLAMP, 1, 0);
}

int DrawFormat(DWORD Color, int PosX, int PosY, int Width, int Align, LPCSTR Text, ...)
{
	char Buff[2048];
	int BuffLen = sizeof(Buff) - 1;
	ZeroMemory(Buff, BuffLen);

	va_list args;
	va_start(args, Text);
	int Len = vsprintf_s(Buff, BuffLen, Text, args);
	va_end(args);

	int LineCount = 0;

	char* Line = strtok(Buff, "\n");

	while (Line != NULL)
	{
		pDrawColorText(Line, PosX, PosY, Width, 0, Color, 0, Align);
		PosY += 10;
		Line = strtok(NULL, "\n");
	}

	return PosY;
}

void CBackScreen99B()
{
	float red;
	float green;
	float v2;
	float v3;
	float v4;
	float v5;
	float v6;
	float v7;
	float v8;
	float v9;
	float v10;
	float v11;
	float v12;
	float v13;
	float v14;
	float v15;
	float v16;
	float v17;
	float v18;
	float v19;
	BeginBitmap();
	EnableAlphaTest(1);
	red = sin(WorldTime * 0.001) * 0.40000001 + 0.60000002;//flt_568C6BC
	glColor3f(1.0, 1.0, 1.0);
	RenderBitmap(1741, 0.0, 0.0, 320.0, 320.0, 0, 0, 1.0, 1.0, 1, 1, 0.0);
	RenderBitmap(1742, 320.0, 0.0, 320.0, 320.0, 0, 0, 1.0, 1.0, 1, 1, 0.0);
	EnableAlphaBlend();
	v2 = sin(WorldTime * 0.001) + 35.0;
	RenderBitmap(1749, 300.0, 90.0, 45.0, v2, 0, 0.546875, 0.703125, -0.546875, 1, 1, 0.0);
	glColor3f(red, red, red);
	RenderBitmap(1744, 220.0, 50.0, 206.0, 42.0, 0, 0, 0.8046875, 0.65625, 1, 1, 0.0);
	green = 1.0 - red;
	glColor3f(green, green, green);
	RenderBitmap(1747, 285.0, 155.0, 128.0, 61.0, 0, 0, 1.0, 0.953125, 1, 1, 0.0);
	red = cos(WorldTime * 0.001) * 0.1 + 0.5;
	glColor3f(red, red, red);
	RenderBitmap(1747, 200.0, 135.0, 256.0, 122.0, 0, 0, 1.0, 0.953125, 1, 1, 0.0);
	red = cos(WorldTime * 0.001) * 0.2 + 0.30000001;
	glColor3f(red, red, red);
	v3 = sin(WorldTime * 0.000099999997) * 5.0 + 190.0;
	RenderBitmap(1747, 200.0, v3, 256.0, 122.0, 0, 0, 1.0, 0.953125, 1, 1, 0.0);
	v4 = sin(WorldTime * 0.00019999999) * 10.0 + 220.0;
	RenderBitmap(1747, 140.0, v4, 256.0, 122.0, 1.0, 0, -1.0, 0.953125, 1, 1, 0.0);
	green = 0.5 - red;
	glColor3f(green, green, green);
	v5 = 250.0 - sin(WorldTime * 0.000099999997) * 7.0;
	RenderBitmap(1747, 80.0, v5, 256.0, 122.0, 1.0, 0, -1.0, 0.953125, 1, 1, 0.0);
	v6 = 210.0 - cos(WorldTime * 0.000099999997) * 7.0;
	RenderBitmap(1747, 70.0, v6, 256.0, 122.0, 1.0, 0, -1.0, 0.953125, 1, 1, 0.0);
	red = sin(WorldTime * 0.001) * 0.2 + 0.30000001;
	glColor3f(red, red, red);
	RenderBitmap(1747, 280.0, 220.0, 256.0, 122.0, 0, 0, 1.0, 0.953125, 1, 1, 0.0);
	v7 = 250.0 - sin(WorldTime * 0.000099999997) * 5.0;
	v8 = 340.0 - sin(WorldTime * 0.0000099999997) * 50.0;
	RenderBitmap(1747, v8, v7, 256.0, 122.0, 0, 0, 1.0, 0.953125, 1, 1, 0.0);
	green = 0.60000002 - red;
	glColor3f(green, green, green);
	v9 = sin(WorldTime * 0.000099999997) * 7.0 + 250.0;
	RenderBitmap(1747, 220.0, v9, 256.0, 122.0, 0, 0, 1.0, 0.953125, 1, 1, 0.0);
	red = sin(WorldTime * 0.0020000001) * 0.2 + 0.5;
	glColor3f(red, red, red);
	v10 = sin(WorldTime * 0.000099999997) * 5.0 + 190.0;
	RenderBitmap(1747, 200.0, v10, 256.0, 122.0, 0, 0, 1.0, 0.953125, 1, 1, 0.0);
	red = (sin(WorldTime * 0.0020000001) + 1.0) * 0.2;
	glColor3f(red, red, red);
	v11 = sin(WorldTime * 0.000099999997);
	v12 = v11 * 5.0 + 250.0;
	v13 = v11 * 200.0 + 100.0;
	RenderBitmap(1747, v13, v12, 256.0, 122.0, 0, 0, 1.0, 0.953125, 1, 1, 0.0);
	v14 = 270.0 - sin(WorldTime * 0.000099999997) * 5.0;
	v15 = 300.0 - sin(WorldTime * 0.000049999999) * 200.0;
	RenderBitmap(1747, v15, v14, 256.0, 122.0, 0, 0, 1.0, 0.953125, 1, 1, 0.0);
	glColor3f(0.30000001, 0.30000001, 0.30000001);
	v16 = 170.0 - sin(WorldTime * 0.00019999999) * 10.0;
	RenderBitmap(1747, 20.0, v16, 256.0, 122.0, 0, 0, 1.0, 0.953125, 1, 1, 0.0);
	v17 = sin(WorldTime * 0.00019999999) * 10.0 + 180.0;
	RenderBitmap(1747, 450.0, v17, 256.0, 122.0, 0, 0, 1.0, 0.953125, 1, 1, 0.0);
	v18 = 130.0 - sin(WorldTime * 0.000099999997) * 5.0;
	RenderBitmap(1747, 10.0, v18, 256.0, 122.0, 1.0, 0, -1.0, 0.953125, 1, 1, 0.0);
	v19 = sin(WorldTime * 0.000099999997) * 5.0 + 130.0;
	RenderBitmap(1747, 480.0, v19, 256.0, 122.0, 1.0, 0, -1.0, 0.953125, 1, 1, 0.0);
	DisableAlphaBlend();
	EndOpengl();
}

float CDelete = -132;
float COK = 580;
float CCCharacter = -148;
char AAA;
int cPage;
float cTestPos = -256.0;

void CCharacterView(int a1)
{
	CreateCharacterPointer((int)&CharacterView, a1 + 168, 0, 0, 0.0);
	byte_7BD0483 = a1;
	byte_7BD0790 = 0;
	SetAction((int)&unk_7BD0778, 1, 1);
}

void cCreateCharacter99b()
{
	if (*(DWORD*)(MAIN_SCREEN_STATE) == ObjState::SwitchCharacter)
	{
		if (*(BYTE*)((int)sub_482B70() + 33948))
		{
			cTestPos = cTestPos + 17; // tempo box character creation //default + 60 

			if (cTestPos >= 41)
			{
				cTestPos = 41;
			}

			RenderBitmap(23, 200.0, cTestPos, 240.0, 256.0, 0, 0, 0.9375, 1.0, 1, 1, 0.0);
			RenderBitmap(24, 200.0, cTestPos + 256, 240.0, 35.0, 0, 0, 0.9375, 0.546875, 1, 1, 0.0);

			if (SEASON3B_CheckMouseIn(262.0, cTestPos + 227, 19.0, 20.0))
			{
				if (IsPress(1))
				{
					if (cPage >= MAX_CREATE_CHARACTER && cPage <= (0 + 1) || cPage >= (0 + 1) && cPage <= MAX_CREATE_CHARACTER)
					{
						CCharacterView(cPage -= 1);
					}
					PlayBuffer(25, 0, 0);
					RenderBitmap(26, 262.0, cTestPos + 227, 19.0, 20.0, 0, 0, 0.59375, 0.625, 1, 1, 0.0);//<<
				}
			}
			if (SEASON3B_CheckMouseIn(359.0, cTestPos + 227, 19.0, 20.0))
			{
				if (IsPress(1))
				{
					if (cPage >= 0 && cPage <= (MAX_CREATE_CHARACTER - 1) || cPage >= (MAX_CREATE_CHARACTER - 1) && cPage <= 0)
					{
						CCharacterView(cPage += 1);
					}
					PlayBuffer(25, 0, 0);
					RenderBitmap(27, 359.0, cTestPos + 227, 19.0, 20.0, 0, 0, 0.59375, 0.625, 1, 1, 0.0);//>>
				}
			}

			switch (cPage)
			{
			case 0:
				EnableAlphaTest(true);
				glColor4f(0.0, 0.0, 0.0, 0.8);
				pDrawBarForm(262.0, cTestPos + 227, 19.0, 20.0, 0.0f, 0);
				EnableAlphaBlend();
				EnableAlphaTest(1);
				glColor4f(1.0, 1.0, 1.0, 1.0);
				DrawFormat(eWhite, 295, cTestPos + 232, 50, 3, pGetTextLine(pTextThis, (20)));
				break;
			case 1:
				DrawFormat(eWhite, 295, cTestPos + 232, 50, 3, pGetTextLine(pTextThis, (21)));
				break;
			case 2:
				DrawFormat(eWhite, 295, cTestPos + 232, 50, 3, pGetTextLine(pTextThis, (22)));
				break;
			case 3:
				DrawFormat(eWhite, 295, cTestPos + 232, 50, 3, pGetTextLine(pTextThis, (23)));
				break;
			case 4:
				DrawFormat(eWhite, 295, cTestPos + 232, 50, 3, pGetTextLine(pTextThis, (24)));
				break;
			case 5:
				DrawFormat(eWhite, 295, cTestPos + 232, 50, 3, pGetTextLine(pTextThis, (1687)));
				break;
			case 6:
				DrawFormat(eWhite, 295, cTestPos + 232, 50, 3, pGetTextLine(pTextThis, (3150)));
				break;
			}
			if (cPage == MAX_CREATE_CHARACTER)
			{
				EnableAlphaTest(true);
				glColor4f(0.0, 0.0, 0.0, 0.8);
				pDrawBarForm(359.0, cTestPos + 227, 19.0, 20.0, 0.0f, 0);
				EnableAlphaBlend();
				EnableAlphaTest(1);
				glColor4f(1.0, 1.0, 1.0, 1.0);
			}

			CUIControl_SetPosition(dword_E8C544, 290, cTestPos + 202);//Textos


			if (SEASON3B_CheckMouseIn(259.0, cTestPos + 253, 58.0, 23.0))
			{
				if (GetKeyState(1) & 0x8000)
				{
					int v47 = (int)sub_482B70() + 33936;
					sub_483B50((int)sub_482B70(), v47);//Cancel
					PlayBuffer(25, 0, 0);
				}
				RenderBitmap(28, 259.0, cTestPos + 253, 58.0, 23.0, 0, 0, 0.90625, 0.71875, 1, 1, 0.0);
			}
			if (SEASON3B_CheckMouseIn(323.0, cTestPos + 253, 58.0, 23.0))
			{
				if (GetKeyState(1) & 0x8000)
				{
					int v47 = (int)sub_482B70() + 33936;
					sub_403E00(v47);//Ok
					PlayBuffer(25, 0, 0);
				}
				RenderBitmap(29, 323.0, cTestPos + 253, 58.0, 23.0, 0, 0, 0.90625, 0.71875, 1, 1, 0.0);
			}

		}
		else
		{
			cTestPos = -256.0;
		}
		RenderBitmap(12, 448.0, 0.0, 192.0, 37.0, 0, 0, 0.75, 0.578125, 1, 1, 0.0);
		RenderBitmap(12, 0.0, 0.0, 192.0, 37.0, 0.75, 0, -0.75, 0.578125, 1, 1, 0.0);
		RenderBitmap(13, 534.0, 3.0, 106.0, 256.0, 0, 0, 0.828125, 1.0, 1, 1, 0.0);
		RenderBitmap(13, 0.0, 3.0, 106.0, 256.0, 0.828125, 0, -0.828125, 1.0, 1, 1, 0.0);
		RenderBitmap(14, 534.0, 259.0, 106.0, 222.0, 0, 0, 0.828125, 0.8671875, 1, 1, 0.0);
		RenderBitmap(14, 0.0, 259.0, 106.0, 222.0, 0.828125, 0, -0.828125, 0.8671875, 1, 1, 0.0);
		RenderBitmap(15, 192.0, 0.0, 256.0, 70.0, 0, 0, 1.0, 0.546875, 1, 1, 0.0);
	}
}

void CRenderCreateCharacter(GLint a1, int a2, GLsizei width, GLsizei height)
{
	BeginBitmap();
	EnableAlphaTest(1);
	glColor3f(1.0, 1.0, 1.0);
	cCreateCharacter99b();
	DisableAlphaBlend();
	if (*(BYTE*)((int)sub_482B70() + 33948))
	{
		cTestPos = cTestPos + 10; // position of picture character
		if (cTestPos >= 41)
		{
			cTestPos = 41;
		}
		BeginOpengl(283, cTestPos + 109, 74, 79);
	}
	else
	{
		cTestPos = -256.0;
	}
}

void cSelectCharacter99b()
{
	if (*(DWORD*)(MAIN_SCREEN_STATE) == ObjState::SwitchCharacter)
	{
		if (!*(BYTE*)((int)sub_482B70() + 33948))
		{
			if (SelectedHero >= 0 && SelectedHero <= 4)
			{
				if (CDelete >= -132 && CDelete <= 28)
				{
					CDelete = CDelete + 21.0; // tempo button delete
					PlayBuffer(27, 0, 0);
				}

				if (COK >= 440 && COK <= 580)
				{
					COK = COK - 21.0; // tempo button //default - 30.0;
				}
			}
			else
			{
				CDelete = -132;
				COK = 580;
			}

			if (!*(BYTE*)(GetCharacter(GetPreview(), 0) + 780) || !*(BYTE*)(GetCharacter(GetPreview(), 1) + 780)
				|| !*(BYTE*)(GetCharacter(GetPreview(), 2) + 780) || !*(BYTE*)(GetCharacter(GetPreview(), 3) + 780)
				|| !*(BYTE*)(GetCharacter(GetPreview(), 4) + 780))
			{
				if (CCCharacter >= -148 && CCCharacter <= 30)
				{
					PlayBuffer(27, 0, 0);
					CCCharacter = CCCharacter + 17.0; // tempo buton new creation character // default + 30.0;
				}
			}
			else
			{
				CCCharacter = -148;
			}
			RenderBitmap(16, 234.0, CCCharacter, 172.0, 148.0, 0, 0, 0.671875, 0.578125, 1, 1, 0.0);
			RenderBitmap(18, CDelete, 132.0, 179.0, 61.0, 0, 0, 0.69921875, 0.953125, 1, 1, 0.0);
			RenderBitmap(22, COK, 132.0, 179.0, 61.0, 0, 0, 0.69921875, 0.953125, 1, 1, 0.0);

			if (SEASON3B_CheckMouseIn(264.0, CCCharacter + 106, 112.0, 23.0))
			{
				if (GetKeyState(1) & 0x8000)
				{
					PlayBuffer(25, 0, 0);
					PlayBuffer(27, 0, 0);
					sub_483B20((int)sub_482B70(), (int)sub_482B70() + 33936);
				}
				RenderBitmap(17, 264.0, CCCharacter + 106, 112.0, 23.0, 0, 0, 0.875, 0.71875, 1, 1, 0.0);
			}

			if (SEASON3B_CheckMouseIn(COK + 16, 146.0, 60.0, 18.0))
			{
				SelectedCharacter = SelectedHero;
				if (GetKeyState(1) & 0x8000)
				{
					PlayBuffer(25, 0, 0);
					StartGame();
				}
				RenderBitmap(21, COK + 16, 146.0, 60.0, 18.0, 0, 0, 0.9375, 0.5625, 1, 1, 0.0);
			}

			if (SEASON3B_CheckMouseIn(CDelete + 103, 146.0, 60.0, 18.0))
			{
				SelectedCharacter = SelectedHero;
				if (GetKeyState(1) & 0x8000)
				{
					PlayBuffer(25, 0, 0);
					CCharSelMainWin_DeleteCharacter();
				}
				RenderBitmap(19, CDelete + 103, 146.0, 60.0, 18.0, 0, 0, 0.9375, 0.5625, 1, 1, 0.0);
			}
		}
		RenderBitmap(12, 448.0, 0.0, 192.0, 37.0, 0, 0, 0.75, 0.578125, 1, 1, 0.0);
		RenderBitmap(12, 0.0, 0.0, 192.0, 37.0, 0.75, 0, -0.75, 0.578125, 1, 1, 0.0);
		RenderBitmap(13, 534.0, 3.0, 106.0, 256.0, 0, 0, 0.828125, 1.0, 1, 1, 0.0);
		RenderBitmap(13, 0.0, 3.0, 106.0, 256.0, 0.828125, 0, -0.828125, 1.0, 1, 1, 0.0);
		RenderBitmap(14, 534.0, 259.0, 106.0, 222.0, 0, 0, 0.828125, 0.8671875, 1, 1, 0.0);
		RenderBitmap(14, 0.0, 259.0, 106.0, 222.0, 0.828125, 0, -0.828125, 0.8671875, 1, 1, 0.0);
		RenderBitmap(15, 192.0, 0.0, 256.0, 70.0, 0, 0, 1.0, 0.546875, 1, 1, 0.0);
	}
}

void CMoveMainCamera(int a1, DWORD* a2)
{
	if (*(int*)0xE609E8 == 4)
	{
		if (PointSY1 <= 220)
		{
			PointSY1 += 20;		
		}	

		CBackScreen99B();
		*(float*)0x87933D0 = -90.0;
		*(float*)0x87933D4 = 0.0;
		*(float*)0x87933D8 = -90.0;
		*(float*)0x87933DC = 9758.9297;
		*(float*)0x87933E0 = 18913.109;
		*(float*)0x87933E4 = 400.0;
		*(float*)0xE61E40 = 45.0;

		*(float*)(((GetCharacter(GetPreview(), 0)) + 776) + 252) = 8750;
		*(float*)(((GetCharacter(GetPreview(), 0)) + 776) + 256) = 18640;
		*(float*)(((GetCharacter(GetPreview(), 0)) + 776) + 272) = 75;

		*(float*)(((GetCharacter(GetPreview(), 1)) + 776) + 252) = 8770;
		*(float*)(((GetCharacter(GetPreview(), 1)) + 776) + 256) = 18790;
		*(float*)(((GetCharacter(GetPreview(), 1)) + 776) + 272) = 90;

		*(float*)(((GetCharacter(GetPreview(), 2)) + 776) + 252) = 8800;
		*(float*)(((GetCharacter(GetPreview(), 2)) + 776) + 256) = 18920;
		*(float*)(((GetCharacter(GetPreview(), 2)) + 776) + 272) = 100;

		*(float*)(((GetCharacter(GetPreview(), 3)) + 776) + 252) = 8770;
		*(float*)(((GetCharacter(GetPreview(), 3)) + 776) + 256) = 19050;
		*(float*)(((GetCharacter(GetPreview(), 3)) + 776) + 272) = 120;

		*(float*)(((GetCharacter(GetPreview(), 4)) + 776) + 252) = 8750;
		*(float*)(((GetCharacter(GetPreview(), 4)) + 776) + 256) = 19170;
		*(float*)(((GetCharacter(GetPreview(), 4)) + 776) + 272) = 135;
	}
}

void CSceneA::SelectChar()
{
	((int(*)())0x005977E0)();
	cSelectCharacter99b();
}

void CRenderCharacterCircle(int a1, int a2, int a3, int color, int a5, float a6, int a7)
{
	EnableAlphaBlend();
	float v66 = (double)(WorldTime % 3600);
	RenderCircle(32142, a2, 50.0, 70.0, 200.0, v66, 0.0, 0.0);
}

int CSprite_SetPositionV2(int a1, int a2, signed int a3, signed int a4, char a5)
{
	return CSprite_SetPosition(a1, a2, a3 + 5000, a4, a5);
}

int CSceneA::CCharMakeWin_SetPosition(int This, int a2, int a3)
{
	int v3; // edx@1
	int v4; // edx@7
	signed int v5; // eax@8
	int v6; // ST08_4@8
	signed int v7; // eax@8
	int v8; // eax@8
	int v10; // [sp+8h] [bp-14h]@1
	int v11; // [sp+Ch] [bp-10h]@1
	signed int v12; // [sp+10h] [bp-Ch]@1
	signed int i; // [sp+14h] [bp-8h]@1
	signed int v14; // [sp+18h] [bp-4h]@1

	v10 = This;

	(*(void(__thiscall**)(int, int, int))(*(DWORD*)(This + 60) + 8))(This + 60, a2, a3);
	v12 = a2 + 346;
	CSprite_SetPositionV2(v10 + 288, a2 + 346, a2 + 346, a3 + 2, 3);
	v11 = a3 + 105;
	v14 = CSprite_GetHeight(v10 + 624);
	for (i = 0; i < 3; ++i)
		CSprite_SetPositionV2(v10 + 224 * i + 624, v10, v12, v11 + v14 * i, 3);
	CSprite_SetPositionV2(v10 + 1744, v3, v12, v11 + 3 * v14, 3);
	float New = a3 + 220;
	CSprite_SetPositionV2(v10 + 1968, a3 + 246, v12, a3 + 246, 3);
	while (i <= 4)
	{
		CSprite_SetPositionV2(v10 + 224 * i + 624, 224 * i, v12, New + v14 * (i - 2), 3);
		++i;
	}
	CSprite_SetPositionV2(v10 + 1296, a3 + 325, v12, New + 0 * v14, 3);//MGFix
	CSprite_SetPositionV2(v10 + 2192, a2 + 400, a2 + 346, a3 + 325, 3);//OK
	CSprite_SetPositionV2(v10 + 2416, a2 + 400, a2 + 400, a3 + 325, 3);//Cancel
	CSprite_SetPositionV2(v10 + 120, v4, a2, a3 + 317, 3);
	return CSprite_SetPositionV2(v10 + 456, a3 + 355, a2, a3 + 355, 3);
}

void LoginScreen2(int a1, DWORD* a2)
{
	if (*(int*)0x0E61E18 == 100) //Select Server
	{
		SetFloat((0x005DB53F), -2.014084447E38);
		SetFloat((0x005DB55D), -2.70652875E38);
		*(float*)0xE61E3C = 33000.0;
		*(float*)0x87933D0 = -84.0;
		*(float*)0x87933D4 = 0.0;
		*(float*)0x87933D8 = -45.0;
		*(float*)0x87933DC = 24475.79687;
		*(float*)0x87933E0 = 7581.581055;
		*(float*)0x87933E4 = 1834.539917;
		*(float*)0xE61E40 = 35.0;
	}
}

#include <Mmsystem.h>
#pragma comment(lib,"Winmm.lib")
void RenderSSCObjectVisual2(int a1, int a2)
{
	//Select Server
	if (*(int*)0x0E61E18 == 100) //Select Server
	{
		switch (*(DWORD*)(a1 + 48))
		{
		case 1:
		{
			BeginRender(1.0);
			*(DWORD*)(a1 + 60) = -2;
			*(BYTE*)(a2 + 136) = 0;
			float v552 = 4000;
			float v551 = ((int)(v552 - timeGetTime() * 0.75f) % 4001) * 0.0002500000118743628;
			RenderMesh(a2,
				0,
				66,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				v551,
				-1);
			*(BYTE*)(a2 + 136) = -1;
			EndRender();
		}
		break;

		case 5:
		{
			BeginRender(1.0);
			*(BYTE*)(a2 + 136) = 0;
			*(float*)(a2 + 72) = 0.80000001;
			*(float*)(a2 + 76) = 0.69999999;
			*(float*)(a2 + 80) = 0.30000001;
			RenderMesh(a2,
				0,
				68,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				32042);
			RenderMesh(a2,
				23,
				66,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				-1);
			RenderMesh(a2,
				23,
				68,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				32042);
			RenderMesh(a2,
				24,
				66,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				-1);
			RenderMesh(a2,
				24,
				68,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				32042);
			RenderMesh(a2,
				25,
				66,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				-1);
			RenderMesh(a2,
				25,
				68,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				32042);
			RenderMesh(a2,
				26,
				66,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				-1);
			RenderMesh(a2,
				26,
				68,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				32042);
			RenderMesh(a2,
				27,
				66,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				-1);
			RenderMesh(a2,
				27,
				68,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				32042);
			RenderMesh(a2,
				28,
				66,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				-1);
			RenderMesh(a2,
				28,
				68,
				*(float*)(a1 + 152),
				*(DWORD*)(a1 + 68),
				*(float*)(a1 + 100),
				*(float*)(a1 + 104),
				*(float*)(a1 + 108),
				32042);
			*(BYTE*)(a2 + 136) = -1;
			EndRender();
		}
		break;
		}
	}
	RenderCryingWolf2ndObjectVisual(a1, a2);
}


void CSceneA::Load()
{
	SetCompleteHook(0xE8, 0x004D76FB, &LoginScreen2);//Select Server
	SetCompleteHook(0xE8, 0x004D79C3, &LoginScreen2);//Select Server
	SetDword(0x004D75F0, 100);//Select Server
	SetCompleteHook(0xE8, 0x005EDDA9, &RenderSSCObjectVisual2);//Select Server

	cPage = 1;

	SetCompleteHook(0xE8, 0x004032AB, &CMoveMainCamera);

	SetCompleteHook(0xE9, 0x00403320, this->CCharMakeWin_SetPosition);
	SetCompleteHook(0xE8, 0x0040464E, &CRenderCreateCharacter);

	SetCompleteHook(0xE8, 0x004D5EC3, this->SelectChar);
	SetCompleteHook(0xE8, 0x004D712A, &CMoveMainCamera);
	SetCompleteHook(0xE8, 0x0062DF68, &CLoadBitmapA);

	SetDword(0x004D6C26 + 6, -1);
	//SetDword(0x0048364A+2, 0xE5EBF8);//<Hide Button Select Server
	SetDword(0x00483945 + 2, 0xE5EBF8);

	SetCompleteHook(0xE8, 0x004D7568, &CRenderCharacterCircle);
	SetCompleteHook(0xE8, 0x004D7534, &CRenderCharacterCircle);

	SetDword(0x004D7179, 480);
	SetByte(0x004D7183, 0);

	//Select Server/Character
	SetFloat(0x00D41DCC, 8950);
	SetFloat(0x00D41DC8, 18680);

	SetFloat(0x00D41DC4, 8970);
	SetFloat(0x00D41DC0, 18800);

	SetFloat(0x00D41DBC, 9000);
	SetFloat(0x00D41DB8, 18910);

	SetFloat(0x00D41DB4, 8970);
	SetFloat(0x00D41DB0, 19020);

	SetFloat(0x00D41DAC, 8950);
	SetFloat(0x00D41DA8, 19140);

	SetDouble(0x00E5EBB8, 275);
	SetDword(0x00401E09 + 2, 0xE5EBB8);
	SetDword(0x00401D2F + 1, 1748);
}