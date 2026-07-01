#pragma once

struct eColor 
{
	BYTE red;
	BYTE grn;
	BYTE blu;
	BYTE opl;
};

class eCustomFont
{
public:
	eCustomFont();
	~eCustomFont();
	void load();
	void Draw(HFONT font, int PosX, int PosY, DWORD color, DWORD bkcolor, int Width, int Height, BYTE Align, LPCTSTR Text, ...);
	void DrawMultipleColor(HFONT font, int PosX, int PosY, DWORD bkcolor, int Width, int Height, BYTE Align, LPCTSTR Text, ...);
	eColor	SinWaveColor(float frc1, float frc2, float frc3, BYTE phs1, BYTE phs2, BYTE phs3, BYTE center, BYTE width, BYTE step);

	HFONT	FontNormal;
	HFONT	FontBold;
	HFONT	FontSize15;
	HFONT	FontSize18;
};

extern eCustomFont CustomFont;