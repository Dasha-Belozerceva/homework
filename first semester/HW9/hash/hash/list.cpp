#include <iostream>
#include "list.h"
#include <string>

using namespace std;

struct ListElement
{
	string value;
	int repeatString;
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

void addInHead(List *list, string string)
{
		ListElement *element = new ListElement;
		element->value = string;
		element->repeatString = 1;
		element->next = list->head;
		list->head = element;
}

void addElement(List *list, ListElement *current, string string)
{
		ListElement *element = new ListElement;
		element->value = string;
		element->repeatString = 1;
		element->next = current->next;
		current->next = element;
}

void deleteElement(List *list, ListElement *parrent, string element)
{
	ListElement *current = parrent->next;
	parrent->next = parrent->next->next;
	delete current;
}

void deleteHead(List *list)
{
	ListElement *element = list->head;
	list->head = list->head->next;
	delete element;
}

void deleteList(List *list)
{
	ListElement *current = list->head;
	while (current != nullptr)
	{
		ListElement *element = current;
		current = current->next;
		delete element;
	}
	delete list;
}

void printList(List *list)
{
	ListElement *current = list->head;
	while (current != nullptr)
	{
		cout << current->value << current->repeatString << endl;
		current = current->next;
	}

}

void increaseAmountOfRepeat(List *list, ListElement *current)
{
	current->repeatString++;
}

int returnRepeatOfString(List *list, ListElement *current)
{
	return current->repeatString;
}

bool emptyList(List *list)
{
	return (list->head == nullptr);
}

string returnValue(List *list, ListElement *current)
{
	return current->value;
}

ListElement *nextElement(List *list, ListElement *current)
{
	return current->next;
}