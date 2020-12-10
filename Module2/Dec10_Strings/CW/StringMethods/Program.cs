using System;
using System.Text;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            Console.WriteLine(RemoveSpaces(s));
            Console.WriteLine($"There are {CountWords(s)} words with more than 4 letters.");
            Console.WriteLine($"There are {StartingWithVowel(s)} words starting with a vowel.");
        }

        public static string RemoveSpaces(string s)
        {
            
            StringBuilder sb = new StringBuilder();
            foreach (var word in s.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries))
            {
                sb.Append(word + " ");
            }
            return sb.ToString().Substring(0, sb.Length -1);
        }

        public static int CountWords (string s)
        {
            int count = 0;
            foreach (var word in s.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries))
            {
                if (word.Length > 4)
                    count++;
            }

            return count;
        }
        
        public static int StartingWithVowel (string s)
        {
            string vowels = "еиыэа";
            int count = 0;
            foreach (var word in s.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries))
            {
                if (vowels.Contains(word[0].ToString().ToLower()))
                    count++;
            }

            return count;
        }



    }
}