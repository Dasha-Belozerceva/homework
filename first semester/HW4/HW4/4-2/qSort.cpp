#include <iostream>
#include "qSort.h"

using namespace std;

/*Сортировка вставками*/
void insertSort(int arr[], int left, int right)
{
	for (int i = left + 1; i < right; i++)
	{
		for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--)
			swap(arr[j - 1], arr[j]);
	}
}

/*Быстрая сортировка*/
void qSort(int arr[], int left, int right)
{
	int i = left;
	int j = right;
	int supportElement = 0;
	bool temp = true;
	while (temp == true)
	{
		if (arr[left] > arr[left + 1])
		{
			supportElement = arr[left];
			temp = false;
		}
		else if (arr[left] < arr[left + 1])
		{
			supportElement = arr[left + 1];
			temp = false;
		}
		else
			++left;
	}
	while (i <= j)
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
	if (i < right && (right - i) > 10)
		qSort(arr, i, right);
	else if ((right - i) <= 10)
		insertSort(arr, i, right + 1);
	if (left < j && (j - left) > 10)
		qSort(arr, left, j);
	else if ((j - left) <= 10)
		insertSort(arr, left, j + 1);
}
