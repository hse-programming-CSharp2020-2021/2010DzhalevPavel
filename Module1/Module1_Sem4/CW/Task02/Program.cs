using System;

namespace Task02
{
    internal class Program
    {
        static bool Shift(ref char ch)
        {
            if (ch >= 'a' && ch <= 'z')
            {
                int shift = 4;
                int letters = 26;
                
                //Or c--; if we want to move backwards
                for (int i = 0; i < shift; i++) ch++; 
                //we make sure that after z we return to a, not next ASCII symbols
                ch = (char) ((ch - 'a') % letters + (int)'a');
                return true;
            }else return false;
        }
        public static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            // Console.WriteLine("\n");
            Console.WriteLine(Program.Shift(ref a));
            Console.WriteLine(a);
        }
    }
}