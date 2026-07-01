#pragma once
//#define UIOPTION_NUMBERONLY				9
//#define UIOPTION_PAINTBACK				8
#define newClass						((int(__cdecl*)(int Type)) 0x009D00C5)
#define new_CUITextInputBox				((DWORD* (__thiscall*)(DWORD* thisa)) 0x00420F60)
#define CUITextInputBox_Init			((void (__thiscall*)(DWORD* thisa, HWND hWnd, int iWidth, int iHeight, int iMaxLength, BOOL bIsPassword)) 0x00421B90)
#define CUITextInputBox_SetState		((void (__thiscall*)(DWORD* thisa, int type)) 0x00421D30)
#define CUITextInputBox_GiveFocus		((void (__thiscall*)(DWORD* thisa, BOOL bSel)) 0x00421D80)
#define CUITextInputBox_SetText			((void (__thiscall*)(DWORD* thisa, const char* pszText)) 0x00421830)
#define CUITextInputBox_Render			((void (__thiscall*)(DWORD* thisa)) 0x00422320)
#define CUITextInputBox_SetFont			((void (__thiscall*)(DWORD* thisa, HFONT hFont)) 0x00423060)
#define CUITextInputBox_GetText			((void (__thiscall*)(DWORD* thisa, char * pszText, int iGetLenght)) 0x004217D0)
#define CUITextInputBox_GetTextW			((void (__thiscall*)(DWORD* thisa, wchar_t * pszText, int iGetLenght)) 0x00421800)
#define CUITextInputBox_SetOption		((void (__thiscall*)(DWORD* thisa, int iOption)) 0x004050F0)
#define CUITextInputBox_DoAction		((BOOL (__thiscall*)(DWORD* thisa, BOOL bMessageOnly)) 0x00417F90)
#define CUITextInputBox_GetPosition_x	((int (__thiscall*)(DWORD* This)) 0x0042D170)
#define CUITextInputBox_GetPosition_y	((int (__thiscall*)(DWORD* This)) 0x0042D190)
#define CUITextInputBox_GetWidth		((int (__thiscall*)(DWORD* This)) 0x0042DC90)
#define CUITextInputBox_GetHeight		((int (__thiscall*)(DWORD* This)) 0x00477A10)
#define CUITextInputBox_HaveFocus         ((BOOL(__thiscall*)(DWORD* This)) 0x0049CD50)

enum UISTATES
{
	UISTATE_NORMAL = 0,
	UISTATE_RESIZE,
	UISTATE_SCROLL,
	UISTATE_HIDE,
	UISTATE_MOVE,
	UISTATE_READY,
	UISTATE_DISABLE
};

enum UIOPTIONS
{
	UIOPTION_NULL = 0,
	UIOPTION_NUMBERONLY = 1, //SO
	UIOPTION_SERIALNUMBER = 2, //So chu In
	UIOPTION_ENTERIMECHKOFF = 4,
	UIOPTION_PAINTBACK = 8,
	UIOPTION_NOLOCALIZEDCHARACTERS = 16 //Khong Co Dau
};

class CUITextInputBox
{
public:
	CUITextInputBox();
	virtual ~CUITextInputBox();
	void Init();
	//--
	void Render();
	DWORD* GetInput();
	const POINT& GetPos();
	const SIZE& GetSize();
	bool CheckMouseTarget();
	//--
	void ChangeEditBox(int type);
	void SetPosition(int x, int y);
	void SetTextColor(BYTE a, BYTE r, BYTE g, BYTE b);
	void SetBackColor(BYTE a, BYTE r, BYTE g, BYTE b);
	void SetSelectBackColor(BYTE a, BYTE r, BYTE g, BYTE b);
	void GetText(char* pszText, int iGetLenght = 255);
	void GetTextW(wchar_t* pszText, int iGetLenght = 255);
	void ClearTexts();

	void SetFont(HFONT hFont);
	void SetState(int iState);
	void SetOption(int iOption);
	void GiveFocus(BOOL bSel = FALSE);
	void SetTabTarget(CUITextInputBox* pTabTarget);
	void Init(HWND hWnd, int iWidth, int iHeight, int iMaxLength = 50, BOOL bIsPassword = FALSE);
	BOOL DoAction(BOOL bMessageOnly = FALSE);
	BOOL HaveFocus();

	DWORD* m_InputBox;
	int GetPosition_x();
	int GetPosition_y();
	int GetWidth();
	int GetHeight();
	void SetText(char* pszText);

private:
	POINT       m_Pos;
	SIZE        m_Size;
};