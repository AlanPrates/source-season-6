// ServerDisplayer.cpp: implementation of the CServerDisplayer class.
//
//////////////////////////////////////////////////////////////////////

#include "stdafx.h"
#include "ServerDisplayer.h"
#include "Log.h"
#include "Protect.h"
#include "ServerManager.h"
#include "SocketManager.h"

CServerDisplayer gServerDisplayer;
//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

CServerDisplayer::CServerDisplayer() // OK
{
	for(int n=0;n < MAX_LOG_TEXT_LINE;n++)
	{
		memset(&this->m_log[n],0,sizeof(this->m_log[n]));
	}

	this->m_font = CreateFont(44,0,0,0,FW_SEMIBOLD,0,0,0,ANSI_CHARSET,OUT_DEFAULT_PRECIS,CLIP_DEFAULT_PRECIS,DEFAULT_QUALITY,DEFAULT_PITCH | FF_DONTCARE,"Segoe UI");

	this->m_font3 = CreateFont(13,0,0,0,FW_NORMAL,0,0,0,ANSI_CHARSET,OUT_DEFAULT_PRECIS,CLIP_DEFAULT_PRECIS,DEFAULT_QUALITY,DEFAULT_PITCH | FF_DONTCARE,"Consolas");
	
	this->m_brush[0] = CreateSolidBrush(RGB(71,85,105));
	this->m_brush[1] = CreateSolidBrush(RGB(14,165,139));
	this->m_brush[2] = CreateSolidBrush(RGB(15,23,42));
	this->m_brush[3] = CreateSolidBrush(RGB(30,64,175));
	this->m_brush[4] = CreateSolidBrush(RGB(17,24,39));

	strcpy_s(this->m_DisplayerText[0],"STANDBY MODE");
	strcpy_s(this->m_DisplayerText[1],"ACTIVE MODE");
	
}

CServerDisplayer::~CServerDisplayer() // OK
{
	DeleteObject(this->m_font);
	DeleteObject(this->m_brush[0]);
	DeleteObject(this->m_brush[1]);
	DeleteObject(this->m_brush[2]);
	DeleteObject(this->m_brush[3]);
	DeleteObject(this->m_brush[4]);
}

void CServerDisplayer::Init(HWND hWnd) // OK
{
	PROTECT_START

	this->m_hwnd = hWnd;

	PROTECT_FINAL

	gLog.AddLog(1,"LOG");
}

void CServerDisplayer::Run() // OK
{
	this->Interface(this->m_hwnd);
	this->SetWindowName();
	this->PaintAllInfo();
	this->LogTextPaint();
	this->PaintName();
}

void CServerDisplayer::SetWindowName() // OK
{
	char buff[256];

	wsprintf(buff,"[%s] %s DataServer (QueueSize : %d)",DATASERVER_VERSION,DATASERVER_CLIENT,gSocketManager.GetQueueSize());

	SetWindowText(this->m_hwnd,buff);
}

void CServerDisplayer::PaintAllInfo() // OK
{
	this->Interface(this->m_hwnd);
	RECT rect;

	GetClientRect(this->m_hwnd,&rect);

	rect.top = 50;
	rect.bottom = 100;

	HDC hdc = GetDC(this->m_hwnd);

	int OldBkMode = SetBkMode(hdc,TRANSPARENT);

	HFONT OldFont = (HFONT)SelectObject(hdc,this->m_font);

	int state = 0;

	for(int n=0;n < MAX_SERVER;n++)
	{
		if(gServerManager[n].CheckState() == 0)
		{
			continue;
		}

		if((GetTickCount()-gServerManager[n].m_PacketTime) <= 60000)
		{
			state = 1;
			break;
		}
	}

	if(state == 0)
	{
		SetTextColor(hdc,RGB(226,232,240));
		FillRect(hdc,&rect,this->m_brush[0]);
		DrawText(hdc,this->m_DisplayerText[0],strlen(this->m_DisplayerText[0]),&rect,DT_CENTER | DT_VCENTER | DT_SINGLELINE);
	}
	else
	{
		SetTextColor(hdc,RGB(255,255,255));
		FillRect(hdc,&rect,this->m_brush[1]);
		DrawText(hdc,this->m_DisplayerText[1],strlen(this->m_DisplayerText[1]),&rect,DT_CENTER | DT_VCENTER | DT_SINGLELINE);
	}

	SelectObject(hdc,OldFont);
	SetBkMode(hdc,OldBkMode);
	ReleaseDC(this->m_hwnd,hdc);
}

void CServerDisplayer::PaintName() // OK
{
	RECT rect;

	GetClientRect(this->m_hwnd,&rect);

	rect.top = 0;

	rect.bottom = 50;

	HDC hdc = GetDC(this->m_hwnd);

	int OldBkMode = SetBkMode(hdc,TRANSPARENT);

	HFONT OldFont = (HFONT)SelectObject(hdc,this->m_font);

	SetTextColor(hdc,RGB(255,255,255));

	FillRect(hdc,&rect,this->m_brush[3]);

	DrawText(hdc, DATASERVER_CLIENT, sizeof(DATASERVER_CLIENT), &rect, DT_CENTER | DT_VCENTER | DT_SINGLELINE);

	SelectObject(hdc,OldFont);

	SetBkMode(hdc,OldBkMode);

	ReleaseDC(this->m_hwnd,hdc);
}

void CServerDisplayer::LogTextPaint() // OK
{
	RECT rect;

	GetClientRect(this->m_hwnd,&rect);

	rect.top = 80;

	HDC hdc = GetDC(this->m_hwnd);

	HFONT OldFont = (HFONT)SelectObject(hdc,this->m_font3);

	int line = MAX_LOG_TEXT_LINE;

	int count = (((this->m_count-1)>=0)?(this->m_count-1):(MAX_LOG_TEXT_LINE-1));

	for(int n=0;n < MAX_LOG_TEXT_LINE;n++)
	{
		switch(this->m_log[count].color)
		{
			case LOG_BLACK:
				SetTextColor(hdc,RGB(226,232,240));
				SetBkMode(hdc,TRANSPARENT);
				break;
			case LOG_RED:
				SetTextColor(hdc,RGB(248,113,113));
				SetBkMode(hdc,TRANSPARENT);
				break;
			case LOG_GREEN:
				SetTextColor(hdc,RGB(52,211,153));
				SetBkMode(hdc,TRANSPARENT);
				break;
			case LOG_BLUE:
				SetTextColor(hdc,RGB(96,165,250));
				SetBkMode(hdc,TRANSPARENT);
				break;
		}

		int size = strlen(this->m_log[count].text);

		if(size > 1)
		{
			TextOut(hdc,10,(rect.bottom - 440 + (line * 15)), this->m_log[count].text, size);
			line--;
		}

		count = (((--count)>=0)?count:(MAX_LOG_TEXT_LINE-1));
	}

	ReleaseDC(this->m_hwnd,hdc);
}

void CServerDisplayer::LogAddText(eLogColor color,char* text,int size) // OK
{
	PROTECT_START

	size = ((size>=MAX_LOG_TEXT_SIZE)?(MAX_LOG_TEXT_SIZE-1):size);

	memset(&this->m_log[this->m_count].text,0,sizeof(this->m_log[this->m_count].text));

	memcpy(&this->m_log[this->m_count].text,text,size);

	this->m_log[this->m_count].color = color;

	this->m_count = (((++this->m_count)>=MAX_LOG_TEXT_LINE)?0:this->m_count);

	PROTECT_FINAL

	gLog.Output(LOG_GENERAL,"%s",&text[9]);
}

void CServerDisplayer::Interface(HWND hWnd)
{
    HDC hDC = GetDC(this->m_hwnd);
    RECT rect;
    // ----
    GetClientRect(this->m_hwnd, &rect);
    FillRect(hDC, &rect, this->m_brush[2]);
    SetBkMode(hDC, TRANSPARENT);
    ReleaseDC(this->m_hwnd, hDC);
}
