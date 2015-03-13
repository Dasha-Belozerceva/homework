// Task6.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include "iostream"
using namespace std;

int main()
{
	int numberOfTickets = 0;
	for (int number = 0; number <= 999999; number++)
	{
		int number1 = number / 100000;
		int number2 = number / 10000 % 10;
		int number3 = number / 1000 % 10;
		int number4 = number / 100 % 10;
		int number5 = number / 10 % 10;
		int number6 = number % 10;
		if (number1 + number2 + number3 == number4 + number5 + number6)
		{
			numberOfTickets++;
		}
	}
	cout << "numberOfTickets=" << numberOfTickets << "\n";
	return 0;
}

