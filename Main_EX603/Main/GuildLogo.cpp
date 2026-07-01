#include "stdafx.h"
#include "GuildLogo.h"
#include "Util.h"
#include "User.h"

// ----------------------------------------------------------------------------------------------

int valor = 0;

// ----------------------------------------------------------------------------------------------


void GensLogoPlayer(int a1, float a2, float a3, float a4, float a5, float a6, float a7, float a8, float a9, char a10, char a11, float a12)
{
	gObjUser.Refresh();
	RenderBitmap(a1, a2 - valor, a3 + 5, 35.0, 35.0, a6, a7, a8, a9, a10, a11, a12);
}

void PlayerGuildLogo(int x, int y, DWORD c) // ok
{
	gObjUser.Refresh();

	DWORD character = *(DWORD*)(c + 668); //Get Character Struct

	if (*(BYTE*)(character + 800) == 1) //Check Character Type
	{
		if (*(short*)(character + 124) != -1) //Check Character Guild
		{
			valor = 15.0;

			((void(__cdecl*)(int nMarkIndex, bool blend)) 0x005D30F0)(*(WORD*)(character + 124), true); //CreateGuildMark
			RenderBitmap(31740, x - 20, y - 1, 20.0, 20.0, 0.0, 0.0, 1.0, 1.0, 1, 1, 0.0);
		}
		else
		{
			valor = 0.0;
		}
	}

	((void(__cdecl*)(int x, int y, DWORD c)) 0x005985F0)(x, y, c); //RenderBoolean
}

void InitGuildIcon()
{
	SetCompleteHook(0xE8, 0x005BAFAB, &PlayerGuildLogo);

	SetCompleteHook(0xE8, 0x007C5DB0, &GensLogoPlayer);
}