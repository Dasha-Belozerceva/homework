#include "stdafx.h"
#include <iostream>

using namespace std;

int bubbleSort(int arr[1000], int length)
{
	int temp = 0;
	for (int i = 0; i < length; ++i)
	{
		for (int j = i + 1; j < length; ++j)
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


int main()
{
	int length = 0;
	cout << "enter the length of array" << "\n";
	cin >> length;

	if (length <= 0)
	{
		cout << "mistake! length of the array must be more than zero";
		return 0;
	}

	int arr[1000];
	int arrSort[1000];
	cout << "enter a non-negative number is not more than a thousand" << "\n";
	for (int i = 0; i < length; ++i)
	{
		cin >> arr[i];
		arrSort[i] = arr[i];
		if (arr[i] > 1000)
		{
			cout << "mistake! number must be less than a thousand";
			return 0;
		}
		if (arr[i] < 0)
		{
			cout << "mistake! number must be more than zero";
			return 0;
		}
	}

	bubbleSort(arr, length - 1);
	
	int mostRepetitive = 0;
	int Index = 0;
	int count = 0;
	for (int i = 0; i < length - 1; ++i)
	{
		count = 0;
		while (arr[i] == arr[i + 1])
		{
			++count;
			++i;
		}
		if (count > mostRepetitive)
		{
			mostRepetitive = count;
			Index = i - 1;
		}
	}
	if (mostRepetitive == 0)
		cout << "no elements satisfying the condition " << "\n";
	else
		cout << "The most frequent element: " << arr[Index] << "\n";

	return 0;
}

/* программа проверялась на следующих данных (формат: ввод|вывод):
6, 1 3 5 7 5 3| 5
6, 1 3 1 5 3 7 | 1
7, 1 3 5 7 9 2 4 | no elements satisfying the condition
5, 1 7 5 3 7 | 7
-5|mistake! length of the array must be more than zero;
5, -6| mistake! number must be more than zero;
*/