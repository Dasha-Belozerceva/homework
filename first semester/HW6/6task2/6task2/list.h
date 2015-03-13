#pragma once

struct List;
struct ListElement;

List *create();

ListElement *returnHead(List *list);

void addElement(List* list, int value);

void deleteElement(List* list, int value);

void printList(List *list);

void deleteList(List* list);