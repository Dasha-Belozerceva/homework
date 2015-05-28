using System;

namespace _2._1._7
{
    public class MatrixSort
    {
        
        /// <summary>
        /// Sorting of matrix columns
        /// </summary>
        /// <param name="matrix">required matrix</param>
        /// <param name="n">number of row in matrix</param>
        /// <param name="m">number of column in matrix</param>
       public static void SortMatrix(int[][] matrix)
        {
           for (int i = 0; i < matrix.GetLength(0); ++i)
           {
               for (int j = i; j < matrix[i].GetLength(0); ++j)
               {
                   if (matrix[0][j] < matrix[0][i])
                       Swap(matrix, i, j);
               }
           }
        }

        //Меняем местами столбцы матрицы
        /// <summary>
       /// swap the columns of the matrix
        /// </summary>
       /// <param name="matrix">required matrix</param>
        /// <param name="n">number of row in matrix</param>
       /// <param name="i">column position which values must be changed</param>
       /// <param name="j">column position which values must be changed</param>
       static void Swap(int[][] matrix, int i, int j)
         {
             int temp = 0;
             for (int m = 0; m < matrix.GetLength(0); ++m)
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
           SortMatrix(matrix);
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
