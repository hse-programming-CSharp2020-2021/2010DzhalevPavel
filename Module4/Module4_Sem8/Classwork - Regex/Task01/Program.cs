using System;
using System.Text.RegularExpressions;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string match = "^(<link).*\\.js.*>";
            var input = Console.ReadLine();

            string match2 = "#Goods.*(Code[0-9]*)*";

            var rand = new Random();
            var result = Regex.Replace(input, match2, rand.Next(1,10000).ToString());

            Console.WriteLine(result);
        }
    }
}