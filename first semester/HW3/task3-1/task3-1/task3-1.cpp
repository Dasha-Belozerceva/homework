#include "stdafx.h"
#include <iostream>

using namespace std;

/*Сортировка вставками*/
void insertSort (int arr[100], int first, int last)
{
	for (int i = first + 1; i < last; i++)
	{
		for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--)
			swap(arr[j - 1], arr[j]);
	}
}

/*Быстрая сортировка*/
void qSort(int arr[100], int left, int right)
{
	int i = left;
	int j = right;
	int supportElement = arr[i + (j - i) / 2];
	while (i < j)
	{
		while (arr[i] <= supportElement)
			++i;
		while (arr[j] >= supportElement)
			--j;

		if (i <= j)
		{
			swap(arr[i], arr[j]);
			i++;
			j--;
		}
	}
	if (left < j)
		qSort(arr, i, right);

	if (right > i)
		qSort(arr, left, j);
	if ((right - i) <= 10)
		insertSort(arr, i, right + 1);
	if ((j - left) <= 10)
		insertSort(arr, left, j + 1);
}


int main()
{
	setlocale(LC_ALL, "Russian");

	int number = 0;
	cout << "Введите длину массива: " << "\n";
	cin >> number;

	if (number <= 0)
	{
		cout << "Длина массива должна быть больше нуля\n";
		return 0;
	}

	int *arr = new int[number];
	cout << "array: " << "\n";
	for (int i = 0; i < number; ++i)
	{
		arr[i] = rand() % 30;
		cout << arr[i] << " ";
	}
	cout << "\n";

	qSort(arr, 0, number - 1);
	cout << "Result: " << "\n";
	for (int i = 0; i < number; ++i)
		cout << arr[i] << " ";
	cout << "\n";

	delete[] arr;

	return 0;
}

/*программа проверялась на следующих данных(формат: ввод | вывод) :
5 | 11 17 4 10 29, 4 10 11 17 29
3| 11 17 4, 4 11 17

*/