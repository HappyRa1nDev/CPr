#include "interfaces.h"
#include <tchar.h>
#include <stdio.h>
#include <unknwn.h>
#include "iid.h"
#include <string>
#include <locale>
#include <codecvt>

class CoCar : public IEngine, public ICreateCar, public IStats, public IDispatch
{
	ITypeInfo* m_pTypeInfo;
public:
	CoCar();
	~CoCar();

	// IUnknown
	STDMETHODIMP QueryInterface(REFIID riid, void** pIFace);
	STDMETHODIMP_(DWORD)AddRef();
	STDMETHODIMP_(DWORD)Release();

	// IEngine
	STDMETHODIMP SpeedUp();
	STDMETHODIMP GetMaxSpeed(int* maxSpeed);
	STDMETHODIMP GetCurSpeed(int* curSpeed);

	// IStats
	STDMETHODIMP DisplayStats();
	STDMETHODIMP GetPetName(BSTR* petName);

	// ICreateCar
	STDMETHODIMP SetPetName(BSTR petName);
	STDMETHODIMP SetMaxSpeed(int maxSp);

	//IDispatch
	HRESULT __stdcall GetTypeInfoCount(UINT* pCount);
	HRESULT __stdcall GetTypeInfo(UINT uiTInfoRequest, LCID lcid, ITypeInfo** ppTInfo);
	HRESULT __stdcall GetIDsOfNames(REFIID riid, OLECHAR** ppNames, UINT cNames, LCID lcid, DISPID* pDispId);
	HRESULT __stdcall Invoke(DISPID dispidMember, REFIID riid, LCID lcid, WORD wFlags,
		DISPPARAMS* pDispParams, VARIANT* pvarResult, EXCEPINFO* pExcepInfo, UINT* puArgErr);

private:
	ULONG m_refCount;
	BSTR	m_petName; // »нициализаци¤ через SysAllocString(), 
	// удаление Ч через вызов SysFreeString()
	int		m_maxSpeed; // ћаксимальна¤ скорость
	int		m_currSpeed; // “екуща¤ скорость —о—аr
	HRESULT LoadTypeInfo(void);
	const int MAX_SPEED = 250;
	int MAX_NAME_LENGTH = 20;

	CRITICAL_SECTION g_cs;
	long g_mtaUsageCount = 0;
};

