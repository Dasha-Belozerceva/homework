using System;
using RealizationOfTheHashTable;
using _2._3._2;

namespace _2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralFunction hashFunction = new hashFunction1();
            Hash hash = new Hash(hashFunction);

        }
    }
}
