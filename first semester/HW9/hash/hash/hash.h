#pragma once

#include "list.h"
#include <string>

struct HashTable;

//создать хэш-таблицу
HashTable *createHash();

//хэш-функция
int hashFunction(std::string str);

//добавить элемент в хэш-таблицу
void addToHash(HashTable *hash, std::string str);

//вывести на экран хэш-таблицу
void printHash(HashTable *hash);

//удалить хэш-таблицу
void deleteHash(HashTable *hash);