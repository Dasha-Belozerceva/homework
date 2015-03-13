#include <iostream>
#include "list.h"
#include <locale.h>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	cout << " оличество человек:" << endl;
	int n = 0;
	cin >> n;
	cout << "ѕериодичность убийств:" << endl;
	int m = 0;
	cin >> m;

	List *list = create();

	addElement(list, 1);
	
	for (int i = n; i >= 2; i--)
	{
		addElement(list, i);
	}

	
	printList(list);
	
	cout << endl;
	int temp1 = 0;
	int temp2 = n;
	for (int i = m - 1; i < n * m; i += m)
	{
		//если последний элемент списка достигаетс€ раньше, чем заканчиваетс€ вычисление следующей жертвы, лишнюю часть периода начинаем отсчитывать от начала списка.
		if ((i - temp1) / temp2 > 0) 
		{
			i = (i - temp1) % temp2;
			temp1 = 0;
		}

		removeElement(list, i - temp1);
		printList(list);
		cout << endl;
		temp1++;
		temp2--;

		if (temp2 == 1)
			break;
	}
	

	cout << "»скома€ позици€: " << endl;
	printList(list);
	cout << endl;

	delete head(list);
	delete list;
	cout << "¬ведите любое значение, чтобы выйти:\n";
	int number = 0;
	cin >> number;
	return 0;
}
