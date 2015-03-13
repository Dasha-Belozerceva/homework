#pragma once
#include <string>

struct StackElement;
struct Stack;

//создать стек
Stack *create();


//добавить элемент в стек
void addElement(Stack *stack, char value);

//значение головы стека
char returnHeadValue(Stack *stack);

//удалить элемент из стека
void deleteElement(Stack *stack);

//проверка стека на наличие элементов
bool isEmpty(Stack *stack);

//удалить стек
void deleteStack(Stack *stack);