#pragma once

#include <string>

struct ListElement;
struct List;

//������� ������
List *create();
//������� ������ ������
ListElement *head(List *list);
//�������� ������� � ������ ������
void addInHead(List *list, std::string string);
//�������� ������� � ������
void addElement(List *list, ListElement *position, std::string string);
//������� �������
void deleteElement(List *list, ListElement *position, std::string element);
//������� ������
void deleteHead(List *list);
//������� ������
void deleteList(List *list);
//��������� ���������� ������������� �����
void increaseAmountOfRepeat(List *list, ListElement *current);
//������� ����� ������������� �����
int returnRepeatOfString(List *list, ListElement *current);
//�������� ������ �� ������� ��������� � ���
bool emptyList(List *list);
//������� �������� ��������
std::string returnValue(List *list, ListElement *current);
//��������� �������
ListElement *nextElement(List *list, ListElement *current);
