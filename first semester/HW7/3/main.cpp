#include <iostream>
#include "Stack.h"

using namespace std;

bool checkTheBrackets(Stack *stack, char str[100])
{
	bool checkTheBrackets = true;
	for (int i = 0; i < strlen(str); i++)
	{
		if (str[i] == '{' || str[i] == '[' || str[i] == '(')
			addElement(stack, str[i]);
		else
		{
			char symbol = returnHeadValue(stack);

			if (symbol == ' ')
			{
				checkTheBrackets = false;
				break;
			}

			if (str[i] == '}')
			if (symbol == '{')
				deleteElement(stack);
			else
				break;
			if (str[i] == ']')
			if (symbol == '[')
				deleteElement(stack);
			else
				break;
			if (str[i] == ')')
			if (symbol == '(')
				deleteElement(stack);
			else
				break;
		}
	}
	return checkTheBrackets;
}

int main()
{
	setlocale(LC_ALL, "RUS");
	Stack *stack = create();
	cout << "Введите выражение\n";
	char str[100];
	cin >> str;

	bool flag = checkTheBrackets(stack, str);
	
	if (!flag)
		cout << "Баланс скобок не соблюден\n";
	else
	{
		if (returnHeadValue(stack) == ' ')
			cout << "Баланс скобок соблюден\n";
		else
			cout << "Баланс скобок не соблюден\n";
	}
	deleteStack(stack);
	cout << "Введите любое значение чтобы выйти:\n";
	int a = 0;
	cin >> a;
	return 0;
}
/*
Программа проверялась на следующих данных: (формат: ввод /вывод)
((((()|Баланс скобок не солюден
({[]}) | Баланс скобок соблюден
(){}[]|Баланс скобок соблюден
({)} |Баланс скобок не солюден
*/