namespace HomeWorkSeminar3
{
    internal class Exercise2
    {
        public void Execute()
        {
            Console.WriteLine("Задание 2. Сложение матриц");
            var matrix1 = Exercise1.FillMatrix();
            var matrix2 = Exercise1.FillMatrix(matrix1.Length, matrix1[0].Length);
            Console.WriteLine();
            Console.WriteLine("Матрица 1: ");
            for(int i = 0; i < matrix1.Length; i++)
            {
                for(int j = 0; j < matrix1[i].Length; j++)
                    Console.Write(matrix1[i][j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Матрица 2: ");
            for (int i = 0; i < matrix2.Length; i++)
            {
                for (int j = 0; j < matrix2[i].Length; j++)
                {
                    matrix1[i][j] += matrix2[i][j];
                    Console.Write(matrix2[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Сумма матриц: ");
            for (int i = 0; i < matrix1.Length; i++)
            {
                for (int j = 0; j < matrix1[i].Length; j++)
                    Console.Write(matrix1[i][j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
