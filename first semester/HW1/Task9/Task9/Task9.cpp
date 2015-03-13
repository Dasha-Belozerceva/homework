#include "stdafx.h"
#include "iostream"
using namespace std;

int main()
{
	int N = 0;
	cout << "N=";
	cin >> N;
	for (int i = 2; i <= N; i++)
	{
		int countDivisor = 0;
		for (int j = 2; j < sqrt(i); j++)
		{
			if (i % j == 0)
				countDivisor++;
		}
		if (countDivisor == 0)
		{
			cout << i << "\n";
		}
	}
	return 0;
}

