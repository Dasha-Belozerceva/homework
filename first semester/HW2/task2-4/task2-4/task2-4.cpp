#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int length = 0;
	int range = 0;
	cout << "Enter length of array: " << "\n";
	cin >> length;
	if (length < 0)
	{
		cout << "mistake! length must be more than zero" << "\n";
	}
	cout << "Enter range of values:" << "\n";
	cin >> range;
	if (range < 0)
	{
		cout << "mistake! range must be more than zero";
	}
	int *arr = new int[length];
	cout << "Result:" << "\n";
	for (int i = 0; i < length; ++i)
	{
		arr[i] = rand() % range;
		cout << arr[i] << " ";
	}
	cout << "\n";

	int firstEl = arr[0];
	int i = 0;
	int j = length - 1;
	int temp = 0;

	while (i <= j)
	{
		while (i < length && arr[i] <= firstEl)
			++i;
		while (j > 0 && arr[j] > firstEl)
			--j;
		if (i <= j)
		{
			temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
			++i;
			--j;
		}
	}

	for (i = 0; i < length; i++)
		cout << arr[i] << " ";
	cout << "\n";

	delete[] arr;

	system("pause");
	return 0;
}

/* программа проверялась на следующих данных (формат: ввод|вывод):
5,4|1 3 2 0 1,1 1 0 2 3
-5, -6|mistake! length must be more than zero, mistake! range must be more than zero
7, 8| 1 3 6 4 1 4 6, 1 1 6 4 3 4 6
*/
