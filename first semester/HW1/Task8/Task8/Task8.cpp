#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	char S[1000];
	char S1[1000];
	cout << "enter S and S1" << "\n";
	cin >> S;
	cout << "\n";
	cin >> S1;
	int coincidenceOfSymbols = 0;
	int numberOfEntries = 0;
	for (int i = 0; i <= strlen(S) - strlen(S1); i++)
	{
		for (int j = 0; j < strlen(S1); j++)
		{
			if (S[i + j] == S1[j])
			{
				coincidenceOfSymbols++;
			}
		}
		if (coincidenceOfSymbols == strlen(S1))
		{
			numberOfEntries++;
			
		}
		coincidenceOfSymbols = 0;
	}
	cout << "Number of enteries S1 in S:" << numberOfEntries << "\n";
	return 0;
}
