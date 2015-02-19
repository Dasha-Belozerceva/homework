#include <iostream>

using namespace std;

void Shell(int arr[100], int length)
{
	int interval = length;
	interval = interval / 2;
	while (interval > 0)
	{

		for (int i = 0; i < length - interval; ++i)
		{
			int j = i;
			while (j >= 0 && arr[j] > arr[j + interval])
			{
				int count = arr[j];
				arr[j] = arr[j + interval];
				arr[j + interval] = count;
				j--;
			}

		}
		interval = interval / 2;
	}
	for (int i = 0; i < length; ++i)
		cout << arr[i] << " ";
}

void main()
{
	setlocale(LC_ALL, "Rus");
	int length = 0;
	cout << "Размер массива:";
	cin >> length;
	int *arr = new int[length];
	cout << "Введите элементы массива: ";
	for (int i = 0; i < length; ++i)
	{
		cin >> arr[i];
	}
	
	cout << "Отсортированный массив: ";
	Shell(arr, length);

	delete [] arr;
}