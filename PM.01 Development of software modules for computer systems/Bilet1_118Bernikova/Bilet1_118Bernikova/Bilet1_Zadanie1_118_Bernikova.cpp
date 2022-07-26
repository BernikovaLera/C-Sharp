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
				XOR EAX, EAX // очистка регистра EAX
				XOR EBX, EBX // очистка регистра EBX
				XOR ECX, ECX // очистка регистра ECX
				XOR EDX, EDX // очистка регистра EDX
				mov eax, count //запись на eax переменной count
				mov ebx, 1  //запись на ebx переменной 1
				add eax, ebx // сложение eax и ebx
				mov count, eax //записываем результат eax на переменную count
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
			XOR EAX, EAX // очистка регистра EAX
			XOR EBX, EBX // очистка регистра EBX
			XOR ECX, ECX // очистка регистра ECX
			XOR EDX, EDX // очистка регистра EDX
			mov ax, coun //запись на ax переменной coun
			mov bx, am //запись на bx переменной am
			div bx // делим ax на bx
			mov cx, 100  // в cx записываем 100
			mov temp1, ax // 0 в ax
			mov ax, dx //  в ax записываем dx
			mov cx, 100 // в cx записываем 100
			mul cx // умножаем на 100
			div bx // делим на bx
			mov temp2, ax // записываем в temp2 ax 
		}
		double a = temp1;
		double b = temp2;
		double result = a * 100 + b;
		return result;
	}

}