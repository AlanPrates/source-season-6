#pragma once
#define BeginBitmap										((void(*)()) 0x637770)
#define EndOpengl										((void(*)()) 0x6366F0)
#define EnableAlphaTest									((void(__cdecl*)(char a1)) 0x00635FD0)
#define RenderBitmap									((void(__cdecl*)(int a1, float a2, float a3, float a4, float a5, float a6, float a7, float a8, float a9, char a10, char a11, float a12)) 0x00637C60)
#define LoadBitmapA										((int(__cdecl*)(char * Folder, int Code, int Arg3, int Arg4, int Arg5, int Arg6)) 0x00772330)
#define BeginRender										((void(__thiscall*)(float a2)) 0x00546860)
#define EndRender										((void(__cdecl*)()) 0x00546880)
#define RenderMesh              						((int(__thiscall*)(int This, signed int a2, int a3, float a4, signed int a5, float a6, float a7, float a8, int a9)) 0x005468A0)
#define GetPreview										((int(*)())0x402BC0)
#define GetCharacter									((int(__thiscall*)(int This, signed int a2)) 0x96A4C0)
#define CreateCharacterPointer              			((int(__cdecl*)(int a1, int a2, char a3, char a4, float a5)) 0x0057DD40)
#define EnableAlphaBlend								((void(__cdecl*)()) 0x00636070)
#define WorldTime										*(int*)0x5EF5A1C
#define DisableAlphaBlend								((void(__cdecl*)()) 0x635F50)
#define pLoadModel										((void(__cdecl*)(int ResourceID, char * Path, char * File, int Arg4)) 0x614D10)
#define pLoadTexture									((void(__cdecl*)(int TextureID, char * Folder, int GLREPEAT, int GLNEAREST, int GLTRUE)) 0x614710)
#define sub_482B70										((int(*)()) 0x00482B70)
#define SelectedHero									*(int*)0xE60B4C
#define SelectedCharacter								*(int*)0xE61730
#define StartGame										((void(*)()) 0x004D6A60)
#define PlayBuffer										((signed int(__cdecl*)(int a1, int a2, int a3)) 0x006D6C20)
#define SEASON3B_CheckMouseIn							((bool(__cdecl*)(int a1, int a2, int a3, int a4)) 0x00790B10)
#define sub_483B20										((int(__thiscall*)(int a1,int a2)) 0x00483B20)
#define CInstance										((int(*)()) 0x00407B20)
#define CCharSelMainWin_DeleteCharacter					((int(__thiscall*)()) 0x00405B10)
#define RenderCircle									((void(__cdecl*)(int a1, int a2, float a3, float a4, float a5, float a6, float a7, float a8)) 0x00749250)
#define Hero											*(int*)0x007BC4F04
#define CharacterView									*(char*)0x7BD0470
#define byte_7BD0483									*(BYTE*)0x7BD0483
#define byte_7BD0790									*(BYTE*)0x7BD0790
#define unk_7BD0778										*(int*)0x7BD0778
#define SetAction										((__int16(__cdecl*)(int a1, int a2, char a3)) 0x00542310)
#define BeginOpengl										((int(__cdecl*)(GLint a1, int a2, GLsizei width, GLsizei height)) 0x00636480)
#define pDrawBarForm									((void(__cdecl*)(float PosX, float PosY, float Width, float Height, float Arg5, int Arg6)) 0x6378A0)
#define IsPress											((int(__cdecl*)(int VKBUTTON)) 0x00791070)
#define CSprite_SetPosition								((int(__fastcall*)(int a1, int a2, signed int a3, signed int a4, char a5)) 0x00416640)
#define CSprite_GetHeight								((int(__thiscall*)(DWORD)) 0x00401C80)
#define CSprite_GetYPos									((signed int(__thiscall*)(int This)) 0x00401C40)
#define CSprite_GetXPos									((signed int(__thiscall*)(int This)) 0x00401C20)
#define CWin_GetXPos									((signed int(__thiscall*)(int This)) 0x009CEBF0)
#define CInput_GetScreenHeight							((signed int(__stdcall*)(double a1))0x009CEBF0)
#define dword_E60960									*(int*)0xE60960
#define dword_E8C544									*(int*)0xE8C544
#define CUIControl_SetPosition							((int(__thiscall*)(int This, int a2, int a3)) 0x00417EC0)
#define sub_483B50										((char *(__thiscall*)(int This, int a2)) 0x00483B50)
#define pDrawColorText									((int(__cdecl*)(LPCTSTR Text, int PosX, int PosY, int Width, int Arg5, int Color, int Arg7, int Align)) 0x7D04D0)
#define sub_403E00										((int(__thiscall*)(int This)) 0x00403E00)
#define pGetTextLine									((char*(__thiscall*)(LPVOID This, int LineNumber)) 0x402320)
#define pTextThis										((LPVOID(*)()) 0x0041FE10)
#define RenderCryingWolf2ndObjectVisual					((void(__cdecl*)(int a1, int a2)) 0x008D1C00)

#define MAX_CREATE_CHARACTER							5

class CSceneA
{
public:
	void Load();

	static int __thiscall CCharMakeWin_SetPosition(int This, int a2, int a3);

	static void SelectChar();
private:

};
extern CSceneA gCSceneA;