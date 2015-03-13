#include <iostream>
#include "list.h"
#include "hash.h"
#include <string>
#include <fstream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	HashTable *hash = createHash();

	ifstream in("text.txt");

	string str;
	while (!in.eof())
	{
		in >> str;
		addToHash(hash, str);
	}

	printHash(hash);

	deleteHash(hash);
	
	int exit = 0;
	cout << "¬ведите любое значение, чтобы выйти\n";
	cin >> exit;
	return 0;
}