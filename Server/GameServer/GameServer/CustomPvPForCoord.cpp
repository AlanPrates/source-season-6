#include "stdafx.h"
#include "CustomPvPForCoord.h"
#include "DefaultClassInfo.h"
#include "Map.h"
#include "Move.h"
#include "MemScript.h"
#include "Util.h"
#include "GensSystem.h"
#include "DSProtocol.h"
#include "ObjectManager.h"
#include "Notice.h"
#include "Message.h"

cCCoord gPvPCoord;
//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

cCCoord::cCCoord() // OK
{
	this->m_PvPCoordInfo.clear();
}

cCCoord::~cCCoord() // OK
{

}

void cCCoord::Load(char* path) // OK
{
	CMemScript* lpMemScript = new CMemScript;

	if (lpMemScript == 0)
	{
		ErrorMessageBox(MEM_SCRIPT_ALLOC_ERROR, path);
		return;
	}

	if (lpMemScript->SetBuffer(path) == 0)
	{
		ErrorMessageBox(lpMemScript->GetLastError());
		delete lpMemScript;
		return;
	}

	this->m_PvPCoordInfo.clear();

	try
	{
		while (true)
		{
			if (lpMemScript->GetToken() == TOKEN_END)
			{
				break;
			}

			if (strcmp("end", lpMemScript->GetString()) == 0)
			{
				break;
			}

			MOVE_PVPCOORD_INFO info;

			info.Map = lpMemScript->GetNumber();

			info.X = lpMemScript->GetAsNumber();

			info.Y = lpMemScript->GetAsNumber();

			info.TX = lpMemScript->GetAsNumber();

			info.TY = lpMemScript->GetAsNumber();

			info.Mode = lpMemScript->GetAsNumber();

			info.MaxLevel = lpMemScript->GetAsNumber();

			info.Gens = lpMemScript->GetAsNumber();

			strcpy_s(info.GuildName01, lpMemScript->GetAsString());

			info.Gate = lpMemScript->GetAsNumber();

			info.MsgNumber = lpMemScript->GetAsNumber();

			this->m_PvPCoordInfo.push_back(info);

			LogAdd(LOG_GREEN, "[MAP: %d] [X/Y: %d/%d] [TX/TY: %d/%d] [VIP: %d] [GENS: %d] [GUILD: %s]", info.Map, info.X, info.Y, info.TX, info.TY, info.Mode, info.Gens, info.GuildName01);
		}
	}
	catch (...)
	{
		ErrorMessageBox(lpMemScript->GetLastError());
	}

	delete lpMemScript;
}

bool cCCoord::CheckCoord(LPOBJ lpObj)
{
	for (std::vector<MOVE_PVPCOORD_INFO>::iterator it = this->m_PvPCoordInfo.begin(); it != this->m_PvPCoordInfo.end(); it++)
	{
		if (it->Map != lpObj->Map)
		{
			continue;
		}
		else if ((it->X > lpObj->X || it->TX < lpObj->TX) || (it->Y > lpObj->Y || it->TY < lpObj->TY))
		{
			continue;
		}
		else
		{
			if (lpObj->AccountLevel < it->Mode)
			{
				gObjMoveGate(lpObj->Index, it->Gate);
				gNotice.GCNoticeSend(lpObj->Index, 1, 0, 0, 0, 0, 0, gMessage.GetMessage(it->MsgNumber));
				return 0;
			}

			if (lpObj->Level > it->MaxLevel)
			{
				gObjMoveGate(lpObj->Index, it->Gate);
				gNotice.GCNoticeSend(lpObj->Index, 1, 0, 0, 0, 0, 0, gMessage.GetMessage(it->MsgNumber));
				return 0;
			}

			if (it->Gens != 0 && lpObj->GensFamily != it->Gens)
			{
				gObjMoveGate(lpObj->Index, it->Gate);
				gNotice.GCNoticeSend(lpObj->Index, 1, 0, 0, 0, 0, 0, gMessage.GetMessage(it->MsgNumber));
				return 0;
			}

			if ((strcmp(it->GuildName01, "SEMGUILDA") != 0) && (strcmp(it->GuildName01, lpObj->GuildName) != 0))
			{
				gObjMoveGate(lpObj->Index, it->Gate);
				gNotice.GCNoticeSend(lpObj->Index, 1, 0, 0, 0, 0, 0, gMessage.GetMessage(it->MsgNumber));
				return 0;
			}
		}

		return 1;
	}

	return 0;
}
