using System.Text;

namespace HomeWorkSeminar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Exercise1 exercise1 = new Exercise1();
            Exercise2 exercise2 = new Exercise2();
            Console.WriteLine("Домашнее задание 3, для выбора задачи введите 1 или 2");
            var answer = Console.ReadKey();
            Console.WriteLine();
            switch (answer.Key)
            {
                case ConsoleKey.D1:
                    exercise1.Execute();
                    break;
                case ConsoleKey.D2:
                    exercise2.Execute();
                    break;
            }
            Console.ReadLine();
        }
    }
}
