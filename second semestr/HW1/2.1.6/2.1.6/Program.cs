using System;

namespace _2._1._6
{
    class Snail
    {
        //Функция для обхода матрицы по спирали
        public static void OutpootBySnail(int[][] matrix, int N)
        {
            //Выбираем центральную ячейку матрицы и выводим ее на экран
            int i = N/2;
            int j = N/2;
            Console.Write(matrix[i][j] + " ");
            //Количество перемещений в одном направлении сначала равно единице. 
            //Движение начинается с центральной ячейки.
            int CountOfMove = 1;
            int row = i;
            int column = j;
            while (CountOfMove != N)
            {
                column = MoveToRight(matrix, row, column, CountOfMove, N);
                row = MoveToDown(matrix, row, column, CountOfMove, N);
                ++CountOfMove;
                column = MoveToLeft(matrix, row, column, CountOfMove);
                row = MoveToUp(matrix, row, column, CountOfMove);
                if (CountOfMove + 1 == N)
                {
                    MoveToRight(matrix, row, column, CountOfMove, N);
                }
                ++CountOfMove;
            }
        }

        //Отдельные функции для перемещения вправо, вниз, влево, вверх
        public static int MoveToRight(int[][] matrix, int i, int j, int CountOfMove, int N)
        {
            int step = 0;
            while (step != CountOfMove)
            {
                ++j;
                ++step;
                if (j == N)
                    break;
                Console.Write(matrix[i][j] + " ");
            }
            return j;
        }

        public static int MoveToDown(int[][] matrix, int i, int j, int CountOfMove, int N)
        {
            int step = 0;
            while (step != CountOfMove)
            {
                ++i;
                ++step;
                if (i == N)
                    break;
                Console.Write(matrix[i][j] + " ");
            }
            return i;
        }

        public static int MoveToLeft(int[][] matrix, int i, int j, int CountOfMove)
        {
            int step = 0;
            while (step != CountOfMove)
            {
                --j;
                ++step;
                if (j < 0)
                    break;
                Console.Write(matrix[i][j] + " ");
            }
            return j;
        }

        public static int MoveToUp(int[][] matrix, int i, int j, int CountOfMove)
        {
            int step = 0;
            while (step != CountOfMove)
            {
                --i;
                ++step;
                if (i < 0)
                    break;
                Console.Write(matrix[i][j] + " ");
            }
            return i;
        }

        public static int Main()
        {
            //Размерность квадратной матрицы
            Console.WriteLine("Enter the number of matrix: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N% 2 == 0)
            {
                Console.WriteLine("Number of matrix must be odd");
                return 0;
            }
            if (N < 0)
            {
                Console.WriteLine("Number of matrix must be more then 0");
                return 0;
            }

            int[][] matrix = new int[N][];
            for (int i = 0; i < N; ++i)
                matrix[i] = new int[N];

            //Заполняем матрицу
            //Заполняем матрицу
            for (int i = 0; i < N; ++i)
                for (int j = 0; j < N; ++j)
                    matrix[i][j] = Convert.ToInt32(Console.ReadLine());
            //Вывод исходной матрицы на экран
            Console.WriteLine("Matrix: \n");
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                    Console.Write(matrix[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            //Вывод матрицы спиралью на экран
            Console.WriteLine("Numbers of Matrix: ");
            OutpootBySnail(matrix, N);
            Console.WriteLine();
            return 0;
        }
    }
}
