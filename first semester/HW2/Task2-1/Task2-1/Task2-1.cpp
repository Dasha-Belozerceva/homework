#include "stdafx.h"
#include "iostream"

using namespace std;

int recFibonacci(int number)
{
	if (number == 0 || number == 1)
	{
		return number;
	}
	else
	{
		return recFibonacci(number - 1) + recFibonacci(number - 2);
	}
}

int iterFibonacci(int number)
{
	int number1 = 0;
	int number2 = 1;
	int exchange = 0;
	if (number == 0 || number == 1)
	{
		return number;
	}
	else
	{
		for (int i = 2; i <= number; i++)
		{
			exchange = number1 + number2;
			number1 = number2;
			number2 = exchange;
		}
		return exchange;
	}
}

int main()
{
	int number = 0;
	cout << "number=";
	cin >> number;

	if (number < 0)
	{
		cout << "number must be more or equal then zero" << "\n";
	}
	else
	{
		cout << "iterNumberFibonacci=" << iterFibonacci(number) << "\n";
	}
	
	if (number < 0)
	{
		cout << "number must be more or equal then zero" << "\n";
		return 0;
	}
	else
	{
		int numberFibonacci = recFibonacci(number);
		cout << "recNumberFibonacci=" << numberFibonacci << "\n";
	}

	return 0;
}

/* Recursive method works obviously slower iterative method for number> = 37 */