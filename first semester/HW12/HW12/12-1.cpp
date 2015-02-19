#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	string str;
	
	ifstream F;
	F.open("text.txt", ios::in);

	while (!F.eof())
	{
		string temp;
		getline(F, temp);
		str += temp;
	}

	cout << str;

	string p;
	cout << "Введите подстроку, которую хотите найти в тексте:" << endl;
	getline(cin, p);

	str = p + '#' + str;

	int *prefixFunction = new int[str.length()];
	prefixFunction[0] = 0;
	int k = 0;
	for (int i = 1; i < str.length(); i++)
	{
		while (k > 0 && str[i] != str[k])
			k = prefixFunction[k - 1];

		if (str[i] == str[k])
			k++;

		prefixFunction[i] = k;

		if (prefixFunction[i] == p.length())
		{
			cout << i - 2 * p.length() << endl;
			break;
		}	
	}
	
	delete[]prefixFunction;
	system("pause");
	return 0;
}

/*
Программа проверялась на следующих данных (формат: ввод|вывод):
director of a firm | 282
and | 4
Moscow | 
*/