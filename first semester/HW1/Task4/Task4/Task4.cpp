// Task4.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include "iostream"
using namespace std;

int main()
{
	int count = 0;
	int divident = 0;
	cout << "divident=";
	cin >> divident;
	int divisor = 0;
	cout << "divisor=";
	cin >> divisor;
	int absDivident = abs(divident);
	int absDivisor = abs(divisor);
	while ((absDivident) >= (absDivisor))
	{
		absDivident -= absDivisor;
		count++;
	}
	if (divident * divisor >= 0)
	{
		cout << "quotient=" << count << "\n";
	}
	else
	{
		count *= -1;
		cout << "quotient=" << count << "\n";
	}
	return 0;
}

