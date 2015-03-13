#include <iostream>
#include <locale.h>
#include "list.h"

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	int choice = 1;
	List* list = create();
	while (choice)
	{
		cout << "0 - выйти\n"
			<< "1 - добавить значение в сортированный список\n"
			<< "2 - удалить значение из списка\n"
			<< "3 - распечатать список\n";
		cin >> choice;
		switch (choice)
		{
			case 1:
			{
					  cout << "Введите значение элемента" << endl;
					  int number = 0;
					  cin >> number;
					  addElement(list, number);
					  break;
			}
			case 2:
			{
					  cout << "Введите значение элемента, который хотите удалить" << endl;
					  ListElement *temp = returnHead(list);
					  if (temp == nullptr)
					  {
						  break;
					  }
					  int value = 0;
					  cin >> value;
					  deleteElement(list, value);
					  break;
			}
			
			case 3:
			{

					  cout << "Распечатать список :" << endl;
					  printList(list);
					  cout << endl;
			}
				break;
		}
	}
	
	deleteList(list);
	return 0;
}