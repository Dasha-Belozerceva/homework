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
	cout << "������� ���������\n";
	char str[100];
	cin >> str;

	bool flag = checkTheBrackets(stack, str);
	
	if (!flag)
		cout << "������ ������ �� ��������\n";
	else
	{
		if (returnHeadValue(stack) == ' ')
			cout << "������ ������ ��������\n";
		else
			cout << "������ ������ �� ��������\n";
	}
	deleteStack(stack);
	cout << "������� ����� �������� ����� �����:\n";
	int a = 0;
	cin >> a;
	return 0;
}
/*
��������� ����������� �� ��������� ������: (������: ���� /�����)
((((()|������ ������ �� �������
({[]}) | ������ ������ ��������
(){}[]|������ ������ ��������
({)} |������ ������ �� �������
*/