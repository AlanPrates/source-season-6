// GLFont.h: interface for the CGLFont class.
#pragma once

class CGLFont
{
public:
	CGLFont();
	virtual ~CGLFont();
	void ClearFontHdc( );
	void FontHdc(HFONT font);
	void FontColor( GLfloat R, GLfloat G, GLfloat B, GLfloat Alpha);
	void PaintFont(int DirPathX, int DirPathY, LPCSTR lpString, int DirPathW, int DirPathAling);
public:
	HFONT hFont;
	GLfloat ColorFont[4];
};
extern CGLFont CFont;