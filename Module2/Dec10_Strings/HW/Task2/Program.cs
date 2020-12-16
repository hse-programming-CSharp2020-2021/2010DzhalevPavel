using System;

namespace Task2
{
    class Program
    {
        // проверка, что строки состоят только из символов латинского алфавита
        // и пробелом
        public static bool Validate(string str)
        {
            char[] english = new char[53];
            english[0] = ' ';
            for (int i = 1; i < english.Length; i++)
            {
                english[i] = (char) ('a' + i);
            }

            for (int i = 0; i < 26; i++)
            {
                english[27+i] = (char) ('A' + i);
            }

            if (str.IndexOfAny(english) < 0) return false;
            return true;
        } // end of Validate(string)

        // получение массива строк
        // каждый элемент проверен на соответствие формату
        public static string[] ValidatedSplit(string str, char ch)
        {
            string[] output = null;
            output = str.Split(ch);
            foreach (string s in output)
            {
                if (!Validate(s)) return null;
            }

            return output;
        } // end of ValidatdSplit(string, char)

        // Обрезка строки по первому гласному
        public static string Shorten(string str)
        {
            char[] alph = {'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y'};
            int ind = str.IndexOfAny(alph);
            return ind == 0? str.Substring(0,1 ).ToUpper():str.Substring(0, ind + 1);
        } // end of Shorten(string)

        // Метод создания аббревиатуры для ПОДстроки (в ней много слов)
        public static string Abbrevation(string str)
        {
            string output = String.Empty;
            if (str != String.Empty)
            {
                string[] tmp = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in tmp)
                {
                    string shortenS = Shorten(s);
                    FirstUpcase(ref shortenS);
                    output += shortenS;
                }
            }

            return output;
        } // end of Abbrevation(string)
        
        // Метод преобразования первого символа к заглавному
        public static void FirstUpcase(ref string str) {
            char[] chars = str.ToCharArray();
            if (chars.Length > 1)
                str = str[0].ToString().ToUpper() + str.Substring(1).ToLower();
        } // end of FirstUpcase(ref string)



        static void Main(string[] args)
        {
            foreach (var line in ValidatedSplit("Let it be; All you need is love; Dizzy Miss Lizzy", ';'))
            {
                Console.WriteLine(Abbrevation(line));
            }
        }
    }
}