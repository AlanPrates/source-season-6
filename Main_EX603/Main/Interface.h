#pragma once

#include "stdafx.h"
#include "import.h"
#include "Protect.h"

#define MAX_OBJECT 	250
#define MAX_WIN_WIDTH 640
#define MAX_WIN_HEIGHT 480
#define MAX_WINDOW_EX 100

#define pDrawInterfaceNumBer   ((double(__stdcall*)(float X, float Y, int num, float size)) 0x854FE0)

#define GMT (24 + (gProtect.m_MainInfo.TIME_GMT))

enum ObjectID
{
	eFlag01=1,
	eFlag02,
	eFlag03,
	eFlag04,
	eFlag05,
	eFlag06,
	eFlag07,
	eFlag08,
	eFlag09,
	eFlag10,
	eFlag11,
	eFlag12,
	eFlag13,
	eFlag14,
	eFlag15,
	eFlag16,
	eFlag17,
	eFlag18,
	eFlag19,
	eFlag20,
	eFlag21,
	eFlag22,
	eTIME,
	eRankPANEL_MAIN,
	eRanking,
	eSAMPLEBUTTON,
	eSAMPLEBUTTON2,
	eVip_MAIN,
	eVip_TITLE,
	eVip_FRAME,
	eVip_FOOTER,
	eVip_DIV,
	eVip_CLOSE,
	eVip_BRONZE,
	eVip_SILVER,
	eVip_GOLD,
	eVip_PLATINUM,
	eVip_STATUS,
	eRanking_MAIN,
	eRanking_CLOSE,
	eRanking_TITLE,
	eRanking_FRAME,
	eRanking_FOOTER,
	eLogo,
	eEventTimePANEL_MAIN,
	eEventTime_MAIN,
	eEventTime_TITLE,
	eEventTime_CLOSE,
	eEventTime_FRAME,
	eEventTime_FOOTER,
	eMenu,
	eMenuBG,
	eMenu_MAIN,
	eMenu_CLOSE,
	eMenu_OPT1,
	eMenu_OPT2,
	eMenu_OPT3,
	eMenu_OPT4,
	eMenu_OPT20,
	eCommand_MAIN,
	eCommand_TITLE,
	eCommand_FRAME,
	eCommand_FOOTER,
	eCommand_DIV,
	eCommand_CLOSE,
	eOFFTRADE_JoB,
	eOFFTRADE_JoS,
	eOFFTRADE_JoC,
	eOFFTRADE_WCC,
	eOFFTRADE_WCP,
	eOFFTRADE_WCG,
	eOFFTRADE_OPEN,
	//Minimap
	ePLAYER_POINT,
	eNULL_MAP,
	eLORENCIA_MAP,
	eDUNGEON_MAP,
	eDEVIAS_MAP,
	eNORIA_MAP,
	eLOSTTOWER_MAP,
	eSTADIUM_MAP,
	eATLANS_MAP,
	eTarkan_MAP,
	eElbeland_MAP,
	eICARUS_MAP,
	eLANDOFTRIALS_MAP,
	eAIDA_MAP,
	eCRYWOLF_MAP,
	eKANTRU_MAP,
	eKANTRU3_MAP,
	eBARRACKS_MAP,
	eCALMNESS_MAP,
	eRAKLION_MAP,
	eVULCANUS_MAP,
	eKALRUTAN_MAP,
	eKALRUTAN2_MAP,
	eCONFIRM_MAIN,
	eCONFIRM_BTN_OK,
	eCONFIRM_BTN_CANCEL,
	eCONFIRM_TITLE,
	eCONFIRM_FRAME,
	eCONFIRM_FOOTER,
	eCONFIRM_DIV,
	eNextCommand,
	ePrevCommand,
	eNextEvent,
	ePrevEvent,
//Ex700
	eMainEx700,
	eQuest,
	eCommunity,
	eSystem,
	//--custom
	eSTORE_CLOSE,
	ex_INFO_2,
	eADVANCE_STAT_INFO,
	//--s2
	eMainS2right,
	eMainS2middle,
	eMainS2left,
	eSkillBox,
	eDragonLeft,
	eDragonRight,
	eCharacter,
	eInventory,
	eParty,
	eFriend,
	eFastMenu,
	eShop,
	eGuild,
	//--custom money
	eMoney1,
	eMoney2,
	CharacterSelect,
	CharacterSelect_Button1,
	CharacterSelect_Button2,
	CharacterSelect_Button3,
	CharacterSelect_Button4,
	CharacterSelect_Button5,
	CharacterCreate_Button1,
	CharacterCreate_Button2,
	CharacterCreate_Button3,
	CharacterCreate_Button4,
	CharacterCreate_Button5,
	CharacterCreate_Button6,
	CharacterCreate_Button7,
	CharacterCreate_SEND,
	CharacterCreate_CANCEL,
	//chat
	chatbackground,
	MINIMAP_FRAME,
	MINIMAP_TIME_FRAME,
	MINIMAP_BUTTOM,
	ButtonSettings,
	ButtonStart,
	ButtonStop,
	ButtonStartAttack,
	eCamera3DInit,
	eCamera3DSwitch,
	strucMoveInv,
	eMainEx700Exp,
	RuudShopListIzq,
	RuudShopListDer,
	RuudShopWindow,
	RuudShopExit,
	eButton1,
	eButton2,
	eButton3,
	eButton4,
	eButton5,
	eJewelOfBank,
	eJewelOfBankPush,
	eJewelOfBankRemove,
	eJewelOfBankClose,
};

struct InterfaceElement
{
	DWORD	ModelID;
	float	Width;
	float	Height;
	float	X;
	float	Y;
	float	MaxX;
	float	MaxY;
	DWORD	EventTick;
	bool	OnClick;
	bool	OnShow;
	BYTE	Attribute;
};

class Interface
{
public:
	int ConfirmSlot;
	float PetY;
	float PetX;
	int lastReport;
	int frameCount;
	int frameRate;
	char FPS_REAL[30];
	void UPDATE_FPS();
	void guiMonitore();
	int iniciador;
	int msPing;
	int lastSend;
	int validar;
	char ServerPing[50];
	char ultimoPing[50];
	int ultimo_Ping;
	char ServerRTT[50];
	char ultimoRTT[50];
	int ultimo_RTT;
	InterfaceElement Data[MAX_OBJECT];
public:
	Interface();
	virtual ~Interface();
	void RenderObjectSystem();
	static void LoadImages();
	static void LoadModels();
	static void Work();
//-- System Windows
	void OpenVipWindow(){ this->Data[eVip_MAIN].OnShow = true; };
	void CloseVipWindow() { this->Data[eVip_MAIN].OnShow = false; }
	bool CheckVipWindow() { return this->Data[eVip_MAIN].OnShow; };
	void DrawVipWindow();
	bool EventVipWindow_Main(DWORD Event);
	bool EventVipWindow_Close(DWORD Event);
	bool EventVipWindow_Bronze(DWORD Event);
	bool EventVipWindow_Silver(DWORD Event);
	bool EventVipWindow_Gold(DWORD Event);
	bool EventVipWindow_Platinum(DWORD Event);
	bool EventVipWindow_StatusVip(DWORD Event);
	//--
	void DrawMenu();
	bool EventDrawMenu_Open(DWORD Event);
	void OpenMenuWindow() { this->Data[eMenu_MAIN].OnShow = true; };
	void CloseMenuWindow() {this->Data[eMenu_MAIN].OnShow = false; };
	bool CheckMenuWindow() { return this->Data[eMenu_MAIN].OnShow; };
	void DrawMenuOpen();
	bool EventDrawMenu_Close(DWORD Event);
	bool EventDrawMenu_Op1(DWORD Event);
	bool EventDrawMenu_Op2(DWORD Event);
	bool EventDrawMenu_Op3(DWORD Event);
	bool EventDrawMenu_Op4(DWORD Event);
	bool EventDrawMenu_Op20(DWORD Event);
	//--
	void DrawConfirmOpen();
	bool EventConfirm_OK(DWORD Event);
	bool EventConfirm_CANCEL(DWORD Event);
//-- Funtions
	void BindObject(short ObjectID, DWORD ModelID, float Width, float Height, float X, float Y);
	void DrawGUI(short ObjectID, float PosX, float PosY);
	void DrawGUI2(short ObjectID, float PosX, float PosY);
	void DrawGUI3(short ObjectID, float PosX, float PosY, float ScaleX, float ScaleY);
	void DrawTimeUI();
	int DrawFormat(DWORD Color, int PosX, int PosY, int Width, int Align, LPCSTR Text, ...);
	void DrawIMG(short ObjectID, float PosX, float PosY, float ScaleX, float ScaleY);
	void ResetDrawIMG(short ObjectID);
	int DrawMessage(int Mode, LPCSTR Text, ...);
	void DrawItem(float PosX, float PosY, float Width, float Height, int ItemID, int Level, int Excl, int Anc, bool OnMouse);
	bool CheckWindow(int WindowID);
	int CloseWindow(int WindowID);
	int OpenWindow(int WindowID);
	bool IsWorkZone2(float X, float Y, float MaxX, float MaxY);
	bool IsWorkZone(short ObjectID);
	float GetResizeX(short ObjectID);
	int DrawToolTip(int X, int Y, LPCSTR Text, ...);
	float DrawRepeatGUI(short MonsterID, float X, float Y, int Count);
	float DrawRepeatGUIScale(short MonsterID, float X, float Y,float ScaleX, float ScaleY, int Count);
	void DrawColoredGUI(short ObjectID, float X, float Y, DWORD Color);
	void DrawButton(short ObjectID, float PosX, float PosY, float ScaleX, float ScaleY);
	void DrawButtonRender(short ObjectID, float PosX, float PosY, float ScaleX, float ScaleY);
	void DrawLogo(bool active);
	void CloseCustomWindow();
	//Mini Map
	void DrawMiniMap();
	bool MiniMapCheck();
	bool CombinedChecks();
	bool CheckMap();
	void SwitchMiniMap();
	// ex700
	void DrawInterfaceCustom();
	// s2
	void DrawInterfaceS2Menu();
	void DrawInterface97Menu();
	void EventNewInterface_All(DWORD Event);
	void EventNewInterface97_All(DWORD Event);
	void DrawCoord();
	void DrawInterfaceDragonLS3();
	void DrawInterfaceDragonRS3();
	// Advanced Stats
	bool WindowEx[MAX_WINDOW_EX];
	bool CheckWindowEx(int WindowID);
	void DrawBarForm(float PosX,float PosY,float Width,float Height,GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
	//--
	void OpenConfig(int type);
	void SwitchCamera();
	void SwitchChatExpand();
	void CameraInit();
	bool Button(DWORD Event, int WinID, int ButtonID, bool Type);
	void DrawPing();
	void SendPingRecv();
	void MiniMapMini();

	static void DrawZenAndRud(int a1, int a2, int a3, int a4);
	//-- Mover MiniMapa
	bool		IsWorkZone(float X, float Y, float MaxX, float MaxY, bool a5 = false);
private:
	
};
extern Interface gInterface;
