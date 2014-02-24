
// mfc2View.cpp : implementation of the Cmfc2View class
//

#include "stdafx.h"
// SHARED_HANDLERS can be defined in an ATL project implementing preview, thumbnail
// and search filter handlers and allows sharing of document code with that project.
#ifndef SHARED_HANDLERS
#include "mfc2.h"
#endif

#include "mfc2Doc.h"
#include "mfc2View.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// Cmfc2View

IMPLEMENT_DYNCREATE(Cmfc2View, CView)

BEGIN_MESSAGE_MAP(Cmfc2View, CView)
	// Standard printing commands
	ON_COMMAND(ID_FILE_PRINT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &Cmfc2View::OnFilePrintPreview)
	ON_WM_CONTEXTMENU()
	ON_WM_RBUTTONUP()
END_MESSAGE_MAP()

// Cmfc2View construction/destruction

Cmfc2View::Cmfc2View()
{
	// TODO: add construction code here

}

Cmfc2View::~Cmfc2View()
{
}

BOOL Cmfc2View::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: Modify the Window class or styles here by modifying
	//  the CREATESTRUCT cs

	return CView::PreCreateWindow(cs);
}

// Cmfc2View drawing

void Cmfc2View::OnDraw(CDC* /*pDC*/)
{
	Cmfc2Doc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	if (!pDoc)
		return;

	// TODO: add draw code for native data here
}


// Cmfc2View printing


void Cmfc2View::OnFilePrintPreview()
{
#ifndef SHARED_HANDLERS
	AFXPrintPreview(this);
#endif
}

BOOL Cmfc2View::OnPreparePrinting(CPrintInfo* pInfo)
{
	// default preparation
	return DoPreparePrinting(pInfo);
}

void Cmfc2View::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add extra initialization before printing
}

void Cmfc2View::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add cleanup after printing
}

void Cmfc2View::OnRButtonUp(UINT /* nFlags */, CPoint point)
{
	ClientToScreen(&point);
	OnContextMenu(this, point);
}

void Cmfc2View::OnContextMenu(CWnd* /* pWnd */, CPoint point)
{
#ifndef SHARED_HANDLERS
	theApp.GetContextMenuManager()->ShowPopupMenu(IDR_POPUP_EDIT, point.x, point.y, this, TRUE);
#endif
}


// Cmfc2View diagnostics

#ifdef _DEBUG
void Cmfc2View::AssertValid() const
{
	CView::AssertValid();
}

void Cmfc2View::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

Cmfc2Doc* Cmfc2View::GetDocument() const // non-debug version is inline
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(Cmfc2Doc)));
	return (Cmfc2Doc*)m_pDocument;
}
#endif //_DEBUG


// Cmfc2View message handlers
