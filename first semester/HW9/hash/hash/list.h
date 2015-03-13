#pragma once

#include <string>

struct ListElement;
struct List;

//создать список
List *create();
//вернуть голову списка
ListElement *head(List *list);
//добавить элемент в голову списка
void addInHead(List *list, std::string string);
//добавить элемент в список
void addElement(List *list, ListElement *position, std::string string);
//удалить элемент
void deleteElement(List *list, ListElement *position, std::string element);
//удалить голову
void deleteHead(List *list);
//удалить список
void deleteList(List *list);
//увеличить количество повтор€ющихс€ строк
void increaseAmountOfRepeat(List *list, ListElement *current);
//вернуть число повтор€ющихс€ строк
int returnRepeatOfString(List *list, ListElement *current);
//проверка списка на наличие элементов в нем
bool emptyList(List *list);
//¬ернуть значение элемента
std::string returnValue(List *list, ListElement *current);
//следующий элемент
ListElement *nextElement(List *list, ListElement *current);
