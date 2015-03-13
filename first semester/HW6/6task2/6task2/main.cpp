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
		cout << "0 - �����\n"
			<< "1 - �������� �������� � ������������� ������\n"
			<< "2 - ������� �������� �� ������\n"
			<< "3 - ����������� ������\n";
		cin >> choice;
		switch (choice)
		{
			case 1:
			{
					  cout << "������� �������� ��������" << endl;
					  int number = 0;
					  cin >> number;
					  addElement(list, number);
					  break;
			}
			case 2:
			{
					  cout << "������� �������� ��������, ������� ������ �������" << endl;
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

					  cout << "����������� ������ :" << endl;
					  printList(list);
					  cout << endl;
			}
				break;
		}
	}
	
	deleteList(list);
	return 0;
}