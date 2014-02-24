// Modify MFC.h : main header file for the Modify MFC DLL
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// CModifyMFCApp
// See Modify MFC.cpp for the implementation of this class
//

class CModifyMFCApp : public CWinApp
{
public:
	CModifyMFCApp();

// Overrides
public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};
