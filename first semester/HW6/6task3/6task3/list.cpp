#include "iostream"
#include "list.h"

using namespace std;

struct ListElement
{
	int value;
	ListElement *next;
};

struct List
{
	ListElement *head;
};

List *create()
{
	List *list = new List;
	list->head = nullptr;
	return list;
}

ListElement *head(List *list)
{
	return list->head;
}

ListElement *nextPosition(List* list, ListElement *position)
{
	return position->next;
}

void addElement(List *list, int value)
{
	ListElement *element = new ListElement;
	if (list->head == nullptr)
	{
		element->value = value;
		element->next = list->head;
		list->head = element;
	}

	else if (list->head->next == nullptr)
	{
		element->value = value;
		element->next = list->head;
		list->head->next = element;
	}

	else
	{
		element->value = value;
		element->next = list->head->next;
		list->head->next = element;
	}
}


void removeElement(List *list, int index)
{
	ListElement *current = list->head->next;
	ListElement *parrent = list->head;

	if (index == 0)
	{
		while (current != list->head)
		{
			parrent = current;
			current = current->next;
		}
		list->head = current->next;
	}

	else
	{
		for (int i = 1; i < index; i++)
		{
			parrent = current;
			current = current->next;
		}
	}

	parrent->next = current->next;
	delete current;

}

void printList(List *list)
{
	ListElement *temp = list->head;

	do
	{
		cout << temp->value << " ";
		temp = temp->next;
	} while (temp->value != list->head->value);
}