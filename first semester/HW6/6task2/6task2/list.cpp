#include <iostream>
#include "list.h"

using namespace std;

struct List
{
	ListElement *head;
};

struct ListElement
{
	int value;
	ListElement *next;
};

List *create()
{
	List *list = new List;
	list->head = nullptr;
	return list;
}

ListElement *returnHead(List *list)
{
	return list->head;
}

void addElement(List *list, int value)
{
	if (list->head == nullptr || value <= list->head->value)
	{
		ListElement *element = new ListElement;
		element->value = value;
		element->next = list->head;
		list->head = element;
	}
	else
	{
		ListElement *element = list->head;
		while (element != nullptr)
		{
			if (element->next == nullptr || value <= element->next->value)
			{
				ListElement *temp = new ListElement;
				temp->value = value;
				temp->next = element->next;
				element->next = temp;
				return;
			}
			element = element->next;
		}
	
	}

}

void deleteElement(List *list, int value)
{
	ListElement *checkValue = list->head;
	int count = 0;
	while (checkValue != nullptr)
	{
		if (checkValue->value == value)
			++count;
		checkValue = checkValue->next;
	}
	if (count == 0)
	{
		cout << "Введенного значения нет в списке\n";
		return;
	}
	if (list->head->value == value)
	{
		ListElement *temp = list->head;
		list->head = list->head->next;
		delete temp;
	}
	else
	{
		ListElement *temp1 = list->head;
		while (temp1->next != nullptr)
		{
			if (temp1->next->value == value)
			{
				ListElement *temp2 = temp1->next;
				temp1->next = temp1->next->next;
				delete temp2;
				break;
			}
			temp1 = temp1->next;
		}
	}
	
}

void deleteList(List* list)
{
	while (list->head != nullptr)
	{
		ListElement *temp = list->head;
		list->head = list->head->next;
		delete temp;
	}
	delete list;
}

void printList(List* list)
{
	ListElement *temp = list->head;
	while (temp != nullptr)
	{
		cout << temp->value << " ";
		temp = temp->next;
	}
}
