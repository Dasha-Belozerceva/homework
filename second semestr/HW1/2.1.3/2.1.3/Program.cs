using System;

namespace _2._1._3
{
    public static class BubbleSort
    {
        //сортировка массива
        public static void bubbleSort(int[] array, int length)
        {
            int temp = 0;
            for (int i = 0; i < length; ++i)
            {
                for (int j = i + 1; j < length; ++j)
                {
                    if (array[j] < array[i])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
        public static int Main()
        {
            //Вводим длину массива
            Console.WriteLine("enter the length of array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            if (length <= 0)
            {
               Console.WriteLine("mistake! length of the array must be more than zero");
               return 0;
            }
            Console.WriteLine();
            int[] array = new int[length];
            //Заполняем массив
            Console.WriteLine("enter a non-negative number is not more than a thousand: ");
            for (int i = 0; i < length; ++i)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] > 1000)
                {
                    Console.WriteLine("mistake! element of the array must be less than 1000");
                    return 0;
                }
                if (array[i] < 0)
                {
                    Console.WriteLine("mistake! element of the array must be more than zero");
                    return 0;
                }
            }
            Console.WriteLine(); 
            //Сортируем массив
            bubbleSort(array, length);
            //Вывод массива на экран
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < length; ++i)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            return 0;
        }
    }
}
