using System;

namespace Task1
{
    delegate string ConvertRule (string input);
    class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr?.Invoke(str);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs =
            {
                "lksld;kfhk34r4owirfhds", "lksfjlsdkfjsilgjdfhg323",
                "slfjdkh ;aksfhjd 4hk3 4lk 43r4"
            };

            var conv = new Converter();

            ConvertRule del = RemoveSpaces;
            del += RemoveDigits;
        }

        public static string RemoveDigits(string str)
        {
            var newstring = string.Empty;
            foreach (char c in str)
            {
                if(char.IsDigit(c)) continue;
                newstring += c;
            }
       
            return newstring;
        }

        public static string RemoveSpaces(string str)
        {
            var newstring = string.Empty;
            foreach (char c in str)
            {
                if(char.IsWhiteSpace(c)) continue;
                newstring += c;
            }
       
            return newstring;
        }
    }
}