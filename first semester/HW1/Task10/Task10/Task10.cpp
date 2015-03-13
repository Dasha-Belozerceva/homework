// Task10.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include "iostream"
using namespace std;


int main()
{
	int Massiv[1000];
	int count = 0;
	for (int i = 0; i < 1000; i++)
	{
		Massiv[i] = rand() % 100;
		if (Massiv[i] == 0)
		{
			count++;
		}
	}
	cout << "count=" << count << "\n";
	return 0;
}

