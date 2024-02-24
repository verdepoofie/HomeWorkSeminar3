using System;

namespace HomeWorkSeminar3
{
    internal class Exercise1
    {
        static public int[][] FillMatrix(int rows = 0, int columns = 0)
        {
            if (rows == 0 || columns == 0)
            {
                while (true)
                {
                    Console.WriteLine("Введите количество строк в матрице");
                    var input = Console.ReadLine();
                    if (int.TryParse(input, out rows))
                    {
                        Console.WriteLine("Введите количество столбцов в матрице");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out columns))
                            break;
                    }
                    Console.WriteLine("Введены неправильные значения, попробуйте еще раз");
                }
            }
            Random random = new Random();
            int[][] matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    matrix[i][j] = random.Next(200) - 100;
                }
            }
            return matrix;
        }
        public void Execute()
        {
            Console.WriteLine("Задание 1. Случайная матрица");
            var matrix = FillMatrix();
            int sum = 0;
            Console.WriteLine("Матрица: ");
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    sum += matrix[i][j];
                    Console.Write(matrix[i][j].ToString() + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма элементов матрицы: " + sum.ToString());
        }
    }
}
