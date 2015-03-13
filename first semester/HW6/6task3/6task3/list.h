#pragma once

struct ListElement;

struct List;

//создание списка
List *create();

//добавление элемента в список
void addElement(List *list, int element);

//удаление из списка
void removeElement(List *list, int element);

//распечатать список
void printList(List *list);

//возврат головы списка
ListElement *head(List *list);
