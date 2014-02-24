
// SrvrItem.h : interface of the CASrvrItem class
//

#pragma once

class CASrvrItem : public COleServerItem
{
	DECLARE_DYNAMIC(CASrvrItem)

// Constructors
public:
	CASrvrItem(CADoc* pContainerDoc);

// Attributes
	CADoc* GetDocument() const
		{ return reinterpret_cast<CADoc*>(COleServerItem::GetDocument()); }

// Overrides
	public:
	virtual BOOL OnDraw(CDC* pDC, CSize& rSize);
	virtual BOOL OnGetExtent(DVASPECT dwDrawAspect, CSize& rSize);

// Implementation
public:
	~CASrvrItem();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:
	virtual void Serialize(CArchive& ar);   // overridden for document i/o
};

