using System;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] TestStrings = {"", "a b c", "Let it be", "All You Need Is    Love"};

            foreach (string str in TestStrings)
            {
                Console.WriteLine();
                string[] tmp = str.Split(' ');
                // результат выведен без лишних пробелов
                foreach (string s in tmp)
                {
                    Console.Write(s);
                }

                Console.WriteLine();
                // добавим индексы, чтобы "увидеть" элементы с пустыми строками
                for (int i = 0; i < tmp.Length; i++)
                {
                    Console.Write(i+1 + ": " + tmp[i]);
                }
            }
        }
    }
}