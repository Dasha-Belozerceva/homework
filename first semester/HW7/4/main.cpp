#include <iostream>
#include "stack.h"

using namespace std;


int main()
{
	setlocale(LC_ALL, "Russian");
	Stack *stack = create();
	cout << "Введите выражение в инфиксной форме записи:\n";
	char infixStr[100];
	cin >> infixStr;
	char postfixStr[100];
	int count = 0;
	bool successfulyOperation = true;

	for (int i = 0; i < strlen(infixStr); i++)
	{
		if (infixStr[i] >= '0' && infixStr[i] <= '9')
		{
			postfixStr[count] = infixStr[i];
			count++;
		}

		if (infixStr[i] == '+' || infixStr[i] == '-' || infixStr[i] == '*' || infixStr[i] == '/')
		{
			if (infixStr[i] == '*' || infixStr[i] == '/')
			{
				char stackElement = returnHeadValue(stack);

				while (stackElement == '*' || stackElement == '/')
				{
					stackElement = returnHeadValue(stack);
					deleteElement(stack);
					postfixStr[count] = stackElement;
					count++;
					stackElement = returnHeadValue(stack);
				}
			}

			if (infixStr[i] == '+' || infixStr[i] == '-')
			{
				char stackElement = returnHeadValue(stack);

				while (stackElement == '+' || stackElement == '-' || stackElement == '*' || stackElement == '/')
				{
					stackElement = returnHeadValue(stack);
					deleteElement(stack);
					postfixStr[count] = stackElement;
					count++;
					stackElement = returnHeadValue(stack);
				}
			}

			addElement(stack, infixStr[i]);
		}

		if (infixStr[i] == '(')
			addElement(stack, infixStr[i]);

		if (infixStr[i] == ')')
		{
			while (returnHeadValue(stack) != '(')
			{
				char stackElement = returnHeadValue(stack);
				deleteElement(stack);

				if (stackElement == ' ')
				{
					successfulyOperation = false;
					break;
				}
				else
				{
					postfixStr[count] = stackElement;
					count++;
				}
			}

			deleteElement(stack);
		}
	}

	if (successfulyOperation)
	{
		while (returnSizeOfStack(stack) > 0)
		{
			char stackElement = returnHeadValue(stack);
			deleteElement(stack);
			if (stackElement == '(')
			{
				successfulyOperation = false;
				break;
			}
			else
			{
				postfixStr[count] = stackElement;
				count++;
			}
		}

		if (!successfulyOperation)
			cout << "Введены неверные данные!\n";
		else
		{
			cout << "Данное выражение в постфиксной форме имеет вид\n";
			for (int i = 0; i < count; i++)
				cout << postfixStr[i];
			cout << endl;
		}
	}
	else
	{
		cout << "Неверные данные!\n";
	}
	deleteStack(stack);
	cout << "Введите любое значение чтобы выйти\n";
	int number = 0;
	cin >> number;
	return 0;
}
/*
Программа проверялась на следующих данных: (формат: ввод /вывод)
1+3*(5+6)|1356+*+
(7+8 | Введены неверные данные
1+2+3|12+3+
5*6-(4/2+8*5)/7 |56*42/85*+7/-
*/