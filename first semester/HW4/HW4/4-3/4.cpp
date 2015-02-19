#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	ifstream in("text.txt");
	char string[1000];

	int nonEmptyString = 0;

	while (!in.eof())
	{
		in.getline(string, 1000);
		cout << string << endl;

		for (int i = 0; string[i] != '\0'; i++)
		{
			if (string[i] != ' ' && string[i] != '\t')
			{
				nonEmptyString++;
				break;
			}
		}
	}

	cout << nonEmptyString << endl;
	in.close();
	return 0;
}