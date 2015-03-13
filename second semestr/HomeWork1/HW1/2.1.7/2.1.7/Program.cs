using System;

namespace _2._1._7
{
    class MatrixSort
    {
        //Сортируем столбцы матрицы
       static void SortMatrix(int[][] matrix, int n, int m)
        {
           for (int i = 0; i < m; ++i)
           {
               for (int j = i; j < m; ++j)
               {
                   if (matrix[0][j] < matrix[0][i])
                       swap(matrix, n, i, j);
               }
           }
        }
        //Меняем местами столбцы матрицы
       static void swap(int[][] matrix, int n, int i, int j)
         {
           int temp = 0;
            for (int m = 0; m < n; ++m)
            {
                temp = matrix[m][i];
                matrix[m][i] = matrix[m][j];
                matrix[m][j] = temp;
            }
       }
       public static void Main()
        {
           //Количество строк в матрице
            Console.WriteLine("Enter the number of line");
            int n = Convert.ToInt32(Console.ReadLine());

           //Количество столбцов в матрице
            Console.WriteLine("enter the number of column");
            int m = Convert.ToInt32(Console.ReadLine());


            int[][] matrix = new int[n][];
            for (int i = 0; i < n; ++i)
                matrix[i] = new int[m];

           //Заполняем матрицу
           for (int i = 0; i < n; ++i)
               for (int j = 0; j < m; ++j)
                  matrix[i][j] = Convert.ToInt32(Console.ReadLine());
           //Вывод исходной матрицы на экран
           Console.WriteLine("The first Matrix: \n");
           for (int i = 0; i < n; ++i)
           {
               for (int j = 0; j < m; ++j)
                   Console.Write(matrix[i][j] + " ");
               Console.WriteLine();
           }
           Console.WriteLine();
           //сортируем матрицу
           SortMatrix(matrix, n, m);
           //Выводим на экран сортированную матрицу
           Console.WriteLine("Sorted matrix: \n");
           for (int i = 0; i < n; ++i)
           {
               for (int j = 0; j < m; ++j)
                   Console.Write(matrix[i][j] + " ");
               Console.WriteLine();
           }
        }
    }
}
