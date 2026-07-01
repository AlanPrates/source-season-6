#pragma once

#include "stdafx.h"
#include "User.h"
#include <vector>

struct MOVE_PVPCOORD_INFO
{
	int Map;
	int X;
	int Y;
	int TX;
	int TY;
	int Mode;
	int Gate;
	int MsgNumber;
	int MaxLevel;
	int Gens;
	char GuildName01[11];
};

class cCCoord
{
public:
	cCCoord();
	virtual ~cCCoord();
	void Load(char* path);
	bool CheckCoord(LPOBJ lpObj);
private:
	std::vector<MOVE_PVPCOORD_INFO> m_PvPCoordInfo;
};

extern cCCoord gPvPCoord;