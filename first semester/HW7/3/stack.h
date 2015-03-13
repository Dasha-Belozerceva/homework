#pragma once
#include <string>

struct StackElement;
struct Stack;

//������� ����
Stack *create();


//�������� ������� � ����
void addElement(Stack *stack, char value);

//�������� ������ �����
char returnHeadValue(Stack *stack);

//������� ������� �� �����
void deleteElement(Stack *stack);

//�������� ����� �� ������� ���������
bool isEmpty(Stack *stack);

//������� ����
void deleteStack(Stack *stack);