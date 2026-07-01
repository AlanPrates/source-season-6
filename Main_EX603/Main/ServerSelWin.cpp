#include "StdAfx.h"
#include "Util.h"
#include "ServerSelWin.h"

CServerSelWin g_ServerSelWin;

CServerSelWin::CServerSelWin()
{
}

CServerSelWin::~CServerSelWin()
{
}

void CServerSelWin::SelWin_SetSize(BYTE* pCWin, int nWidth, int nHeight, int eChangedPram)
{
	CWin_SetSize(pCWin, WindowWidth, nHeight, eChangedPram);
}

void CServerSelWin::SetPositionServerGroupA(BYTE* CButton, int cx, int cy, int eChangedPram)
{
	cx = (WindowWidth / 2) - 54;
	ServerSel_SpiriteSetPosition(CButton, cx, cy, eChangedPram);
}

void CServerSelWin::SetPositionServerGroupB(BYTE* CButton, int cx, int cy, int eChangedPram)
{
	cx = (WindowWidth / 2) - 54;
	ServerSel_SpiriteSetPosition(CButton, cx, cy, eChangedPram);
}

_declspec(naked) void SelectServerPosition()
{
	static DWORD ReturnAdress = 0x00413EFE;
	_asm
	{
		ADD EAX, 560 //510y //545
		PUSH EAX
		PUSH 150//150X
		MOV ECX, DWORD PTR SS : [EBP - 0xC4]
		JMP[ReturnAdress]
	}
}


void CServerSelWin::Init()
{
	SetCompleteHook(0xE8, 0x00413EFE, &CServerSelWin::SelWin_SetSize);
	SetCompleteHook(0xE8, 0x004140D9, &CServerSelWin::SetPositionServerGroupA);
	SetCompleteHook(0xE8, 0x0041412E, &CServerSelWin::SetPositionServerGroupB);

	SetCompleteHook(0xE9, 0x00413EED, &SelectServerPosition);
	SetByte((DWORD)(0x00414239), 0);

}