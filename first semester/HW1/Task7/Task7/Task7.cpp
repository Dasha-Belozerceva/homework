#include "stdafx.h"
#include "iostream"
using namespace std;

int main()
{
	const int MaxSize = 1000;
	char line[MaxSize];
	cout << "enter a line \n";
	cin >> line;
	int balance = 0;
	int i = 0;
	while ((line[i] != '\0') && (balance > -1))
	{
			if (line[i] == '(')
				balance++;
			if (line[i] == ')')
				balance--;
			i++;
	}
	if (balance == 0)
		printf("Balance of brackets is not broken\n");
	else
	{
		if (balance > 0)
			printf("opening brackets more than closing ones\n");
		if (balance < 0)
			printf("Rule of nesting of brackets isn't executed");
	}
	return 0;
}