
// mfc2View.h : interface of the Cmfc2View class
//

#pragma once


class Cmfc2View : public CView
{
protected: // create from serialization only
	Cmfc2View();
	DECLARE_DYNCREATE(Cmfc2View)

// Attributes
public:
	Cmfc2Doc* GetDocument() const;

// Operations
public:

// Overrides
public:
	virtual void OnDraw(CDC* pDC);  // overridden to draw this view
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);

// Implementation
public:
	virtual ~Cmfc2View();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	afx_msg void OnFilePrintPreview();
	afx_msg void OnRButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnContextMenu(CWnd* pWnd, CPoint point);
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // debug version in mfc2View.cpp
inline Cmfc2Doc* Cmfc2View::GetDocument() const
   { return reinterpret_cast<Cmfc2Doc*>(m_pDocument); }
#endif

