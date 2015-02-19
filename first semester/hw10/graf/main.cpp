#include <iostream>
#include <fstream>

using namespace std;

bool addCityInCountry(int **graf, bool *distributedCities, int *arrayOfCities, int capital, int n)
{
	int min = 100000;
	int unneededTop = -1;
	//ищем ближайший незан€тый город, чтобы присвоить его какой-то стране
	for (int i = 0; i < n; ++i)
	{
		if (arrayOfCities[i] == capital)
		{
			for (int j = 0; j < n; ++j)
			{
				if (graf[i][j] != 0 && !distributedCities[j] && graf[i][j] < min)
				{
					min = graf[i][j];
					unneededTop = j;
				}
			}
		}
	}
	if (unneededTop != -1)
	{
		distributedCities[unneededTop] = true;
		arrayOfCities[unneededTop] = capital;
		return true;
	}
	return false;
}

int main()
{
	setlocale(LC_ALL, "Russian");
	fstream in("text.txt");
	//считать число городов
	int n = 0;
	in >> n;
	//считать число дорог
	int m = 0;
	in >> m;
	//считать число столиц
	int k = 0;
	in >> k;
	
	//массив путей
	int **graf = new int *[n];
	for (int i = 0; i < n; ++i)
	{
		graf[i] = new int[n];
	}
	for (int i = 0; i < n; ++i)
	{
		for (int j = 0; j < n; ++j)
		{
			graf[i][j] = 0;
		}
	}
	//«аписать длины дорог в массив
	while (m != 0)
	{
		int a = 0;
		int b = 0;
		int len = 0;
		in >> a;
		in >> b;
		in >> len;
		graf[a][b] = len;
		graf[b][a] = len;
		--m;
	}
	//ѕроверка - записал ли уже город в другую страну
	bool *distributedCities = new bool[n];
	for (int i = 0; i < n; ++i)
	{
		distributedCities[i] = false;
	}
	//ћассив городов
	int *arrayOfCities = new int[n];
	for (int i = 0; i < n; ++i)
	{
		arrayOfCities[i] = i;
	}
	//ћассив столиц. —толицы сразу записываем в соответствующие по номеру государства
	int *arrayOfcapitals = new int[k];
	for (int i = 0; i < k; ++i)
	{
		int capital = 0;
		in >> capital;
		arrayOfcapitals[i] = capital;
		distributedCities[capital] = true;
	}
	//число оставшихс€ незан€тых городов
	int amountOfFreeTops = n - k;
	while (amountOfFreeTops > 0)
	{
		for (int i = 0; i < k; ++i)
		{
			if (addCityInCountry(graf, distributedCities, arrayOfCities, arrayOfcapitals[i], n))
			{
				--amountOfFreeTops;
			}
		}
	}

	//¬ывод массивов городов, распределенных по массивам стран на экран
	for (int i = 0; i < k; ++i)
	{
		cout << "Ќомер страны(соответствует номеру столицы): " << arrayOfcapitals[i] + 1 << ' ';
		cout << "√орода страны: " << ' ';
		for (int j = 0; j < n; ++j)
		{
			if (arrayOfCities[j] == arrayOfcapitals[i])
			{
				cout << j + 1 << ' ';
			}
		}
		cout << endl;
	}

	for (int i = 0; i < n; ++i)
	{
		delete graf[i];
	}
	delete[] graf;
	delete[] arrayOfcapitals;
	delete[] arrayOfCities;
	delete[] distributedCities;
	cout << "¬ведите любое число, чтобы выйти\n";
	int a = 0;
	cin >> a;
	return 0;
}