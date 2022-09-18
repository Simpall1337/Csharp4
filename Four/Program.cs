using System;

namespace Lessons
{
    internal class Program
    {

        static string DoubleString(string str)
        {
            int a;
            Console.Write("Введите количество повторений символа : ");
            a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.Write(str);
            }

            return str;
        }

        static void Main(string[] args)

        {
            string b;

            Console.WriteLine("Ведите какой символ хотите повторить");
            string str;
            str = Console.ReadLine();
            b = DoubleString(str);
        }
    }
}

