#include "stdafx.h"
#include <iostream>

using namespace std; 

int exponentiation(int n, int number)
{
	int result = 1;
	for (int i = 1; i <= n; i++)
	{
		result = result * number;
	}
	return result;
}

int fastMetod(int n, int number)
{
	int 
}

int main()
{
	int n = 0;
	cout << "exponent=";
	cin >> n;
	int number = 0;
	cout << "number=";
	cin >> number;
	cout << "fast result of exponentiation=" << fastMetod(n, number) << "\n";
	cout << "result of exponentiation=" << exponentiation(n, number) << "\n";
	return 0;
}

