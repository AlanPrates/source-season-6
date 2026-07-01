#pragma once
#define WindowWidth									*(GLsizei*)0x00E61E58
#define CWin_SetSize								((void(__thiscall*)(BYTE * pCWin, int nWidth, int nHeight, int eChangedPram)) 0x004AC0B0)
#define ServerSel_SpiriteSetPosition				((void(__thiscall*)(BYTE * CButton, int cx, int cy, int eChangedPram)) 0x00416640)

class CServerSelWin
{
public:
	CServerSelWin();
	virtual ~CServerSelWin();
	void Init();
	static void __thiscall SelWin_SetSize(BYTE* pCWin, int nWidth, int nHeight, int eChangedPram);
	static void __thiscall SetPositionServerGroupA(BYTE* CButton, int cx, int cy, int eChangedPram);
	static void __thiscall SetPositionServerGroupB(BYTE* CButton, int cx, int cy, int eChangedPram);
};

extern CServerSelWin g_ServerSelWin;

