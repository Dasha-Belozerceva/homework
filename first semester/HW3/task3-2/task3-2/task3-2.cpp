#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int n = 0;
	cout << "enter the length of array:" << "\n";
	cin >> n;
	if (n < 0)
		cout << "the length of array must be more than 0" << "\n";
	int k = 0;
	cout << "enter the amount of numbers:" << "\n";
	cin >> k;
	if (k < 0)
		cout << "the length of array must be more than 0" << "\n";
	int *arr = new int[n];
	for (int i = 0; i < n; i++)
	{
		arr[i] = rand() % 30;
		cout << arr[i] << " ";
	}
	cout << "\n";
	int *arrNumbers = new int[k];
	for (int t = 0; t < k; t++)
	{
		arrNumbers[t] = rand() % 30;
		cout << arrNumbers[t] << " ";
	}
	cout << "\n";
	int count = 0;
	for (int j = 0; j < n; j++)
		for (int m = 0; m < k; m++)
			{
			if (arr[j] == arrNumbers[m])
				++count;
			}
		cout << count << "\n";
	return 0;
}
/*
программа проверялась на следующих данных (формат: ввод|вывод):
5,5|1
10,8|1
-5, -6|the length of array must be more than 0, the length of array must be more than 0
*/