
// CntrItem.h : interface of the CMFCCntrItem class
//

#pragma once

class CMFCDoc;
class CMFCView;

class CMFCCntrItem : public COleClientItem
{
	DECLARE_SERIAL(CMFCCntrItem)

// Constructors
public:
	CMFCCntrItem(CMFCDoc* pContainer = NULL);
		// Note: pContainer is allowed to be NULL to enable IMPLEMENT_SERIALIZE
		//  IMPLEMENT_SERIALIZE requires the class have a constructor with
		//  zero arguments.  Normally, OLE items are constructed with a
		//  non-NULL document pointer

// Attributes
public:
	CMFCDoc* GetDocument()
		{ return reinterpret_cast<CMFCDoc*>(COleClientItem::GetDocument()); }
	CMFCView* GetActiveView()
		{ return reinterpret_cast<CMFCView*>(COleClientItem::GetActiveView()); }

public:
	virtual void OnChange(OLE_NOTIFICATION wNotification, DWORD dwParam);
	virtual void OnActivate();

protected:
	virtual void OnGetItemPosition(CRect& rPosition);
	virtual void OnDeactivateUI(BOOL bUndoable);
	virtual BOOL OnChangeItemPosition(const CRect& rectPos);
	virtual BOOL OnShowControlBars(CFrameWnd* pFrameWnd, BOOL bShow);

// Implementation
public:
	~CMFCCntrItem();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif
	virtual void Serialize(CArchive& ar);
};

