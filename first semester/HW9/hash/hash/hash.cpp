#include <iostream>
#include "list.h"
#include "hash.h"
#include <string>

using namespace std;

const int hashSize = 100;

struct HashTable
{
	List *hash[hashSize];
};

HashTable *createHash()
{
	HashTable *hash = new HashTable;
	
	for (int i = 0; i < hashSize; ++i)
		hash->hash[i] = create();
	return hash;
}

int hashFunction(string str)
{
	int index = 0;
	for (int i = 0; i < str.length(); ++i)
		index += int(str[i]);
	if (index == 0)
	{
		return index;
	}
	else
		index /= str.length();
	return index;
}

void addToHash(HashTable *hash, string str)
{
	int index = hashFunction(str) % hashSize;
	if (emptyList(hash->hash[index]))
	{
		addInHead(hash->hash[index], str);
	}
	else
	{
		ListElement *current = head(hash->hash[index]);
		while (current != nullptr)
		{
			if (returnValue(hash->hash[index], current) == str)
			{
				increaseAmountOfRepeat(hash->hash[index], current);
				return;
			}
			current = nextElement(hash->hash[index], current);
		}
		if (current == nullptr)
		{
			addInHead(hash->hash[index], str);
		}
	}	
}

void printHash(HashTable *hash)
{
	for (int i = 0; i < hashSize; i++)
	{
		ListElement *current = head(hash->hash[i]);
		while (current != nullptr)
		{
			cout << returnValue(hash->hash[i], current) << " " <<  returnRepeatOfString(hash->hash[i], current) << endl;
			current = nextElement(hash->hash[i], current);
		}
	}
}

void deleteHash(HashTable *hash)
{
	for (int i = 0; i < hashSize; i++)
		deleteList(hash->hash[i]);
	delete[] hash;
}