#include <iostream>
#include "stack.h"

using namespace std;

int operation(int number1, int number2, char value)
{
	switch (value)
	{
	case '+':
		return number1 += number2;
	case '-':
		return number1 -= number2;
	case '*':
		return number1 *= number2;
	case '/':
		return number1 /= number2;
	}
}

int resultByPostfixForm(char str[])
{
	Stack *stack = create();

	int result = 0;
	for (int i = 0; i < strlen(str); i++)
	{
		if (str[i] - '0' >= 0 && str[i] - '0' <= 9)
		{
			addElement(stack, str[i]);
		}
		else
		{
			result = returnHeadValue(stack) - '0';
			deleteElement(stack);
			result = operation(returnHeadValue(stack) - '0', result, str[i]);
			deleteElement(stack);
			addElement(stack, char(result + int('0')));
		}
	}

	result = returnHeadValue(stack) - '0';

	deleteStack(stack);
	return result;
}

int main()
{
	setlocale(LC_ALL, "russian");
	char str[100];
	cout << "Введите выражение в постфиксной форме:" << endl;
	cin >> str;

	cout << resultByPostfixForm(str) << endl;
	cout << "Введите любое значение чтобы выйти:\n";
	int number = 0;
	cin >> number;
	return 0;
}
/*
Программа проверялась на следующих данных: (формат: ввод /вывод)
1356+*+|34
12+3+|6
56*42/85*+7/-|24
*/