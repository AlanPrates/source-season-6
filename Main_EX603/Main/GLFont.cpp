#include "stdafx.h"
#include "GLFont.h"
#include "Import.h"
//#include "CNewFrame.h"

CGLFont CFont;

CGLFont::CGLFont()
{
	this->ColorFont[0] = 1.0;
	this->ColorFont[1] = 1.0;
	this->ColorFont[2] = 1.0;
	this->ColorFont[3] = 1.0;
	this->hFont = CreateFontA ( 14, 0, 0, 0, FW_BOLD, FALSE, FALSE, FALSE, DEFAULT_CHARSET, OUT_TT_ONLY_PRECIS, CLIP_DEFAULT_PRECIS, PROOF_QUALITY, DEFAULT_PITCH, "Arial" ); // Creamos la Font
}

CGLFont::~CGLFont()
{

}

void CGLFont::ClearFontHdc( )
{
	this->hFont = CreateFontA ( 14, 0, 0, 0, FW_BOLD, FALSE, FALSE, FALSE, DEFAULT_CHARSET, OUT_TT_ONLY_PRECIS, CLIP_DEFAULT_PRECIS, PROOF_QUALITY, DEFAULT_PITCH, "Arial" ); // Creamos la Font
}

void CGLFont::FontHdc(HFONT font)
{
	this->hFont = font;
}

void CGLFont::FontColor( GLfloat R, GLfloat G, GLfloat B, GLfloat Alpha)
{
	this->ColorFont[0] = R/255;
	this->ColorFont[1] = G/255;
	this->ColorFont[2] = B/255;
	this->ColorFont[3] = Alpha/255;
}

void CGLFont::PaintFont(int DirPathX, int DirPathY, LPCSTR lpString, int DirPathW, int DirPathAling)
{
	glDisable(GL_TEXTURE_2D);
	glPushAttrib(GL_CURRENT_BIT);

	HDC hDC = GetDC(pGameWindow);
	struct tagSIZE psizl;
	static SHORT FontWidth[255];
	static UINT FontListID;

	if ( !FontListID )
	{
		FontListID = glGenLists ( 256 );

		while ( !wglUseFontBitmapsA ( hDC, 0, 255, FontListID ) )
			Sleep ( 1 );
	}

	SelectObject(hDC, this->hFont);
	GetTextExtentPoint32(hDC, lpString, strlen(lpString), &psizl);

	float PosX	= (double)DirPathX * pWinWidthReal;
	float PosY	= (double)DirPathY * pWinHeightReal;
	float Width = (double)DirPathW * pWinWidthReal;

	float v34 = (double)(signed int)psizl.cx;
	float v35 = (double)(signed int)psizl.cy;

	if ( Width == 0.0 )
		Width = (double)(signed int)psizl.cx;

	signed int v36 = 0;
	signed int v30 = 0;

	switch(DirPathAling)
	{
		case 2:
			if ( Width < (double)v34 )
			{
				v30 = (signed int)(v34 - Width);
				v34 = Width;
			}
			break;
		case 1:
			if ( Width < (double)v34 )
				v34 = Width;
			break;
		case 3:
			if ( Width >= (double)v34 )
			{
				v36 = (signed int)((Width - v34) / 2.0);
			}
			else
			{
				v30 = (signed int)((v34 - Width) / 2.0);
				v34 = Width;
			}
			break;
		case 4:
			if ( Width >= (double)v34 )
			{
				v36 = (signed int)(Width - v34);
			}
			else
			{
				v30 = (signed int)(v34 - Width);
				v34 = Width;
			}
			break;
		case 7:
			if ( Width >= (double)v34 )
			{
				v36 = (signed int)(Width - v34);
			}
			else
			{
				v30 = (signed int)(v34 - Width);
				v34 = Width;
			}
			PosX = PosX - Width;
			break;
		case 8:
			if ( Width >= (double)v34 )
			{
				v36 = (signed int)((Width - v34) / 2.0);
			}
			else
			{
				v30 = (signed int)((v34 - Width) / 2.0);
				v34 = Width;
			}
			PosX = PosX - Width / 2.0;
			break;
	}

	float v33 = (double)pWinHeight - PosY;

	GLfloat ColorFont[4];
	glGetFloatv ( GL_CURRENT_COLOR, ColorFont );

	glListBase ( FontListID );

	glColor4f( 0.0, 0.0, 0.0, 0.8);

	glRasterPos2f( PosX - 0.5, v33 - 0.5 );
	glCallLists( strlen ( lpString ), GL_UNSIGNED_BYTE, lpString );

	glRasterPos2f( PosX + 0.5, v33 - 0.5 );
	glCallLists( strlen ( lpString ), GL_UNSIGNED_BYTE, lpString );

	glRasterPos2f( PosX + 0.5, v33 + 0.5 );
	glCallLists( strlen ( lpString ), GL_UNSIGNED_BYTE, lpString );

	glRasterPos2f( PosX - 0.5, v33 + 0.5 );
	glCallLists( strlen ( lpString ), GL_UNSIGNED_BYTE, lpString );

	glColor4fv(this->ColorFont);

	glRasterPos2f( PosX, v33 );
	glCallLists( strlen ( lpString ), GL_UNSIGNED_BYTE, lpString );

	glColor4fv(ColorFont);

	glEnable(GL_TEXTURE_2D);

}