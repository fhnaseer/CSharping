#include "pch.h"
#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

#define TEST_METHOD1(methodName)\
	static const EXPORT_METHOD ::Microsoft::VisualStudio::CppUnitTestFramework::MemberMethodInfo* CALLING_CONVENTION CATNAME(__GetTestMethodInfo_, methodName)()\
	{\
		__GetTestClassInfo();\
		__GetTestVersion();\
		ALLOCATE_TESTDATA_SECTION_METHOD\
		static const ::Microsoft::VisualStudio::CppUnitTestFramework::MethodMetadata s_Metadata = {L"TestMethodInfo", L## #methodName, reinterpret_cast<const unsigned char*>(__FUNCTION__), reinterpret_cast<const unsigned char*>(__FUNCDNAME__), __WFILE__, __LINE__};\
\
		static ::Microsoft::VisualStudio::CppUnitTestFramework::MemberMethodInfo s_Info = {::Microsoft::VisualStudio::CppUnitTestFramework::MemberMethodInfo::TestMethod, NULL, &s_Metadata};\
		s_Info.method.pVoidMethod = static_cast<::Microsoft::VisualStudio::CppUnitTestFramework::TestClassImpl::__voidFunc>(&ThisClass::methodName);\
		return &s_Info;\
	}\
	void methodName()

namespace CppUnitTest
{
	TEST_CLASS(CppUnitTest)
	{
	public:
		
		TEST_METHOD1(TestMethod1)
		{
		}
	};
}
