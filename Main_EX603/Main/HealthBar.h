#pragma once

#define MAX_MAIN_VIEWPORT 400

struct NEW_HEALTH_BAR
{
	WORD index;
	BYTE type;
	BYTE rate;
	BYTE rate2;
};

void ClearNewHealthBar();
void InsertNewHealthBar(WORD index,BYTE type,BYTE rate,BYTE rate2);
NEW_HEALTH_BAR* GetNewHealthBar(WORD index,BYTE type);
void DrawNewHealthBar();