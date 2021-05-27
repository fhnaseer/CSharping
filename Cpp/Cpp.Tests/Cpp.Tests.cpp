#include "pch.h"
#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace CppTests
{
	TEST_CLASS(CppTests)
	{
	public:

		int m_ebp = 10;

		TEST_METHOD(TestMethod1)
		{
			Test(1);
		}

		TEST_METHOD(TestMethod2)
		{
			Test(2);
		}

		TEST_METHOD(TestMethod3)
		{
			Test(3);
		}

		bool Test(int check)
		{
			static const int Signature[] = {
				0x8d, 0xb5, 0x90, 0x90, 0x90, 0x90,         // [0x00] lea     esi, (dword_40F355 - 0FFFCD574h)[ebp]
				0x8b, 0x46, 0x04,                           // [0x06] mov     eax, [esi+4]
				0x6a, 0x04,                                 // [0x09] push    4
				0x68, 0x00, 0x10, 0x00, 0x00,               // [0x0B] push    1000h
				0x50,                                       // [0x10] push    eax
				0x6a, 0x00,                                 // [0x11] push    0
				0xff, 0x95, 0x90, 0x90, 0x90, 0x90,         // [0x13] call    ss:(VirtualAlloc - 0FFFCD574h)[ebp]
				0x89, 0x85, 0x90, 0x90, 0x90, 0x90,         // [0x19] mov     ss:(dword_40F351 - 0FFFCD574h)[ebp], eax
				0x56,                                       // [0x1F] push    esi
				0x8b, 0x1e,                                 // [0x20] mov     ebx, [esi]
				0x03, 0x9d, 0x90, 0x90, 0x90, 0x90,         // [0x22] add     ebx, ss:(ImageBase - 0FFFCD574h)[ebp]
				0x50,                                       // [0x28] push    eax
				0x53,                                       // [0x29] push    ebx
				0xe8, 0x90, 0x90, 0x90, 0x90,               // [0x2A] call    aplib
			};


			bool success = false;
			do
			{
				int RelativeToEbpValue = 0;
				if (check == 1)
					break;

				RelativeToEbpValue += m_ebp;
				int* decompress = &RelativeToEbpValue;

				int temp = 0;
				if (check == 2)
					break;

				int* tempP = &temp;
				success = true;
				check = 2;

			} while (0);

			return success;
		}
	};
}
