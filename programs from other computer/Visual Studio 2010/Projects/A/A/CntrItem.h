
// CntrItem.h : interface of the CACntrItem class
//

#pragma once

class CADoc;
class CAView;

class CACntrItem : public COleClientItem
{
	DECLARE_SERIAL(CACntrItem)

// Constructors
public:
	CACntrItem(CADoc* pContainer = NULL);
		// Note: pContainer is allowed to be NULL to enable IMPLEMENT_SERIALIZE
		//  IMPLEMENT_SERIALIZE requires the class have a constructor with
		//  zero arguments.  Normally, OLE items are constructed with a
		//  non-NULL document pointer

// Attributes
public:
	CADoc* GetDocument()
		{ return reinterpret_cast<CADoc*>(COleClientItem::GetDocument()); }
	CAView* GetActiveView()
		{ return reinterpret_cast<CAView*>(COleClientItem::GetActiveView()); }

public:
	virtual void OnChange(OLE_NOTIFICATION wNotification, DWORD dwParam);
	virtual void OnActivate();

protected:
	virtual void OnGetItemPosition(CRect& rPosition);
	virtual void OnDeactivateUI(BOOL bUndoable);
	virtual BOOL OnChangeItemPosition(const CRect& rectPos);
	virtual BOOL OnShowControlBars(CFrameWnd* pFrameWnd, BOOL bShow);
	virtual BOOL CanActivate();

// Implementation
public:
	~CACntrItem();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif
	virtual void Serialize(CArchive& ar);
};

