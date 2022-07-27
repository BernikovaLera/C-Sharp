
#include <iostream>
#include <locale>
using namespace std;
int _tmain(int argc, char* argv[])
{
	static int pu = 0;
	int a, b, d, stl, str, baz[10], f, g = 0, i, j, l = 0, q = 0, z = 0, y = 0, xx, z1[10];
	float m, tab[10][10], min = 1000, c[10], tab1[10][10], x = 1000;
	setlocale(LC_ALL, "russian");
	//проверка на оптимальность
	cout << "Введите количество строки и количество столбцов";
	cin >> a >> b;
	//заполнение начальной матрицы
	for (i = 0; i<a; i++)
	{
		for (j = 0; j<b; j++)
		{
			cout << "Введите [" << i << "][" << j << "] элемент таблицы" << endl;
			cin >> tab[i][j];
		}
	}
	cout << "первая итерация" << endl;
	for (i = 0; i<a; i++)
	{
		for (j = 0; j<b; j++){ cout << tab[i][j] << " "; }cout << endl;
	}
	k:
	l = 0;
	for (i = 0; i<b; i++)
	{
		if (tab[a - 1][i]<0)
		{
			l = l + 1;
		}
	}
	if (l == 0)
	{
		for (j = 1; j<b - a + 1; j++)
		{
			int kol = 0, nol = 0, ind;
			for (i = 0; i<a - 1; i++)
			{
				if (tab[i][j] == 1)
				{
					kol++; ind = i;
				}
				else
				nol++;
			}
			if ((kol == 1) && (a - nol == 2))
			{
				cout << "x" << j << "=" << tab[ind][0] << endl;
				cout << "Решение оптимально" << endl;
				system("pause");
				return 0;
			}
		}
		for (i = 0; i<a; i++)
		{
			for (j = 0; j<b; j++)
			{
				cout << tab[i][j] << " ";
			}
			cout << endl;
		}
		cout << "F(x)=" << tab[a - 1][0];
	}
	x = 1000;
	//поиск ключевого столбца
	for (i = 1; i<b; i++)
	{
		if (tab[a - 1][i] <= x)
		{
			x = tab[a - 1][i];
			stl = i;
		}
	}
	//поиск ключевой строки
	for (j = 0; j<a - 1; j++)
	{
		if (tab[j][stl]>0)
			c[j] = tab[j][0] / tab[j][stl];
		else
			c[j] = 1000;
	}
	cout << endl;
	cout << "Массив для нахождения ключевой строки" << endl;
	for (j = 0; j<a - 1; j++){
		cout << c[j] << " ";
	}
	cout << endl;
	for (i = 0; i<(a - 1); i++)
	if (c[i]<min){
		min = c[i];
		str = i;
	}
	cout << endl;
	cout << "Kлючевой столбец и ключевая строка" << endl;
	cout << stl << " " << str << " " << endl;
	cout << endl;
	cout << "Ключевой элемент:" << tab[str][stl] << endl;
	cout << endl;
	//пересчетновой таблицы
	for (i = 0; i<a; i++)
	{
		for (j = 0; j<b; j++)
		{
			tab1[i][j] = tab[i][j] - (tab[i][stl] * tab[str][j] / tab[str][stl]);
			tab1[i][stl] = 0;
			tab1[str][stl] = 1;
			tab1[str][j] = tab[str][j] / tab[str][stl];
		}
	}
	//переприсвоенние матриц и вывод их на экран
	for (i = 0; i<a; i++)
	{
		for (j = 0; j<b; j++)
		{
			tab[i][j] = tab1[i][j];
		}
	}
	pu++;
	if (pu == 5)
	{
		system("cls");
		cout << "Неправильный ввод программа зациклилась" << endl;
		system("pause");
		return 0;
	}
	goto k;
	system("pause");
	return 0;
}