// Task1.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int x = 0;
	cout << "x=";
	cin >> x;
	int square = x * x;
	cout << "sum= " << (square + x) * (square + 1) + 1 << "\n";	
	return 0;
}

