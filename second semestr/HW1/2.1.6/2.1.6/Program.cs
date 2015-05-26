using System;

namespace _2._1._6
{
    public class Snail
    {
        /// <summary>
        /// method of bypassing matrix spiral
        /// </summary>
        /// <param name="matrix">required matrix</param>
        public static string OutpootBySnail(int[][] matrix)
        {
            //Выбираем центральную ячейку матрицы и выводим ее на экран
            int i = matrix.Length / 2;
            int j = matrix.Length / 2;
            string outpootLine = matrix[i][j].ToString() + " ";
            //Количество перемещений в одном направлении сначала равно единице. 
            //Движение начинается с центральной ячейки.
            int countOfMove = 1;
            int row = i;
            int column = j;
            while (countOfMove != matrix.Length)
            {
                column = MoveToRight(matrix, row, column, countOfMove, ref outpootLine);
                row = MoveToDown(matrix, row, column, countOfMove, ref outpootLine);
                ++countOfMove;
                column = MoveToLeft(matrix, row, column, countOfMove, ref outpootLine);
                row = MoveToUp(matrix, row, column, countOfMove, ref outpootLine);
                if (countOfMove + 1 == matrix.Length)
                {
                    MoveToRight(matrix, row, column, countOfMove, ref outpootLine);
                    return outpootLine;
                }
                ++countOfMove;
            }
            return outpootLine;
        }

        /// <summary>
        /// function of move right
        /// </summary>
        /// <param name="matrix">required matrix</param>
        /// <param name="i">row number from which the movement begins</param>
        /// <param name="j">column number from which the movement begins</param>
        /// <param name="countOfMove">amount of movement in the direction that needs to be done during the work function</param>
        /// <returns>the column number at which to stop the movement</returns>
        public static int MoveToRight(int[][] matrix, int i, int j, int countOfMove, ref string outpootLine)
        {
            int step = 0;
            while (step != countOfMove)
            {
                ++j;
                ++step;
                if (j == matrix.Length)
                    break;
                outpootLine += matrix[i][j].ToString() + " ";
            }
            return j;
        }

        /// <summary>
        /// function of move down
        /// </summary>
        /// <param name="matrix">required matrix</param>
        /// <param name="i">row number from which the movement begins</param>
        /// <param name="j">column number from which the movement begins</param>
        /// <param name="countOfMove">amount of movement in the direction that needs to be done during the work function</param>
        /// <returns>the row number at which to stop the movement</returns>
        public static int MoveToDown(int[][] matrix, int i, int j, int countOfMove, ref string outpootLine)
        {
            int step = 0;
            while (step != countOfMove)
            {
                ++i;
                ++step;
                if (i == matrix.Length)
                    break;
                outpootLine += matrix[i][j].ToString() + " ";
            }
            return i;
        }

        /// <summary>
        /// function of move left
        /// </summary>
        /// <param name="matrix">required matrix</param>
        /// <param name="i">row number from which the movement begins</param>
        /// <param name="j">column number from which the movement begins</param>
        /// <param name="countOfMove">amount of movement in the direction that needs to be done during the work function</param>
        /// <returns>the column number at which to stop the movement</returns>
        public static int MoveToLeft(int[][] matrix, int i, int j, int countOfMove, ref string outpootLine)
        {
            int step = 0;
            while (step != countOfMove)
            {
                --j;
                ++step;
                if (j < 0)
                    break;
                outpootLine += matrix[i][j].ToString() + " ";
            }
            return j;
        }

        /// <summary>
        /// function of move up
        /// </summary>
        /// <param name="matrix">required matrix</param>
        /// <param name="i">row number from which the movement begins</param>
        /// <param name="j">column number from which the movement begins</param>
        /// <param name="countOfMove">amount of movement in the direction that needs to be done during the work function</param>
        /// <returns>the row number at which to stop the movement</returns>
        public static int MoveToUp(int[][] matrix, int i, int j, int countOfMove, ref string outpootLine)
        {
            int step = 0;
            while (step != countOfMove)
            {
                --i;
                ++step;
                if (i < 0)
                    break;
                outpootLine += matrix[i][j].ToString() + " ";
            }
            return i;
        }

        public static int Main()
        {
            //Размерность квадратной матрицы
            Console.WriteLine("Enter the number of matrix: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 0)
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
            string outpootLine = OutpootBySnail(matrix);
            Console.WriteLine(outpootLine);
            return 0;
        }
    }
}
