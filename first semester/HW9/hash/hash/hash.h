#pragma once

#include "list.h"
#include <string>

struct HashTable;

//������� ���-�������
HashTable *createHash();

//���-�������
int hashFunction(std::string str);

//�������� ������� � ���-�������
void addToHash(HashTable *hash, std::string str);

//������� �� ����� ���-�������
void printHash(HashTable *hash);

//������� ���-�������
void deleteHash(HashTable *hash);