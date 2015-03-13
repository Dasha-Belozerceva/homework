#include "stdafx.h"
#include <iostream>

using namespace std;

int bubbleSort(int arr[1000], int lenght)
{
	int temp = 0;
	for (int i = 0; i < lenght; ++i)
	{
		for (int j = i + 1; j < lenght; ++j)
		{
			if (arr[j] < arr[i])
			{
				temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
			}
		}
	}
	return arr[1000];
}

int countSort(int arrSort[1000], int lenght)
{
	int additionalArr[1000] = { 0 };
	for (int i = 0; i < lenght; ++i)
	{
		++additionalArr[arrSort[i]];
		int count = 0;
		for (int i = 0; i < 1000; ++i)
		{
			for (int j = 0; j < additionalArr[i]; ++j)
			{
				arrSort[count] = i;
				++count;
			}
		}
	}
	return arrSort[1000];
}

int main()
{
	int lenght = 0;
	cout << "enter the lenght of array" << "\n";
	cin >> lenght;

	if (lenght <= 0)
	{
		cout << "mistake! length of the array must be more than zero";
		return 0;
	}

	int arr[1000];
	int arrSort[1000];
	cout << "enter a non-negative number is not more than a thousand" << "\n";
	for (int i = 0; i < lenght; ++i)
	{
		cin >> arr[i];
		arrSort[i] = arr[i];
		if (arr[i] > 1000)
		{
			cout << "mistake! length of the array must be less than zero";
			return 0;
		}
		if (arr[i] < 0)
		{
			cout << "mistake! length of the array must be more than zero";
			return 0;
		}
	}
	cout << "bubble sorting" << "\n";
	arr[1000] = bubbleSort(arr, lenght);
	for (int i = 0; i < lenght; ++i)
	{
		cout << arr[i] << "\n";
	}	
	cout << "counting sort" << "\n";
	arrSort[1000] = countSort(arrSort, lenght);
	for (int i = 0; i < lenght; ++i)
	{
		cout << arrSort[i] << "\n";
	}
	return 0;
}

