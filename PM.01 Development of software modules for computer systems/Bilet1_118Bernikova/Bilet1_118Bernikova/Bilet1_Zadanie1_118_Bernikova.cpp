#define Bilet1_Zadanie1_118_Bernikova _declspec(dllexport)

#include <string>
using namespace std;

extern "C"
{
	Bilet1_Zadanie1_118_Bernikova int Count(int rate)
	{
		int temp = 0;
		int count = 0;
		temp = rate;
		if (temp >= 4)
		{
			_asm
			{
				XOR EAX, EAX // ������� �������� EAX
				XOR EBX, EBX // ������� �������� EBX
				XOR ECX, ECX // ������� �������� ECX
				XOR EDX, EDX // ������� �������� EDX
				mov eax, count //������ �� eax ���������� count
				mov ebx, 1  //������ �� ebx ���������� 1
				add eax, ebx // �������� eax � ebx
				mov count, eax //���������� ��������� eax �� ���������� count
			}
		}
		return count;
	}

	Bilet1_Zadanie1_118_Bernikova double Knowledge(int count_rate, int amount)
	{
		short temp1 = 0;
		short temp2 = 0;
		short coun = count_rate;
		short am = amount;
		_asm
		{
			XOR EAX, EAX // ������� �������� EAX
			XOR EBX, EBX // ������� �������� EBX
			XOR ECX, ECX // ������� �������� ECX
			XOR EDX, EDX // ������� �������� EDX
			mov ax, coun //������ �� ax ���������� coun
			mov bx, am //������ �� bx ���������� am
			div bx // ����� ax �� bx
			mov cx, 100  // � cx ���������� 100
			mov temp1, ax // 0 � ax
			mov ax, dx //  � ax ���������� dx
			mov cx, 100 // � cx ���������� 100
			mul cx // �������� �� 100
			div bx // ����� �� bx
			mov temp2, ax // ���������� � temp2 ax 
		}
		double a = temp1;
		double b = temp2;
		double result = a * 100 + b;
		return result;
	}

}