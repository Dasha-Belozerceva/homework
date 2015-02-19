#include <iostream>
#include <fstream>
#include "qSort.h"

using namespace std;

int main()
{
	ifstream in("text.txt");

	int length = 0;
	in >> length;

	int *arr = new int[length];
	for (int i = 0; i < length; i++)
	{
		in >> arr[i];
		cout << arr[i] << " ";
	}
	cout << endl;
	
	qSort(arr, 0, length - 1);

	int mostRepetitive = 0;
	int index = 0;
	for (int i = 0; i < length - 1; ++i)
	{
		int count = 0;
		while (arr[i] == arr[i + 1])
		{
			++count;
			++i;
		}
		if (count > mostRepetitive)
		{
			mostRepetitive = count;
			index = i - 1;
		}
	}
	if (mostRepetitive == 0)
		cout << "no elements satisfying the condition " << "\n";
	else
		cout << "The most frequent element: " << arr[index] << "\n";

	in.close();
	delete[] arr;
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