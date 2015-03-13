#include "stdafx.h"
#include "iostream"
using namespace std;

int main()
{
	int const m = 3;
	int const n = 4;
	int x[m + n];
	for (int i = 0; i < m + n; i++)
	{
		x[i] = rand() % 100;
	}
	for (int i = 0; i < m + n; i++)
	{
		cout << x[i] << "\n";
	}
	for (int i = 0; i < (m - 1) / 2; i++)
	{
		int supportingElement = x[i];
		x[i] = x[m - 1 - i];
		x[m - 1 - i] = supportingElement;
	}
	int count = 0;
	for (int j = m; j < ((2 * m + n) / 2); j++)
	{
		int g = x[j];
		x[j] = x[m + n - 1 - count];
		x[m + n - 1 - count] = g;
		count++;
	}
		for (int i = 0; i < (m + n - 1) / 2; i++)
	{
		int p = x[i];
		x[i] = x[m + n - 1 - i];
		x[m + n - 1 - i] = p;
	}
		for (int i = 0; i < m + n; i++)
		{
			cout << x[i] << "\n";
		}
	return 0;
}

