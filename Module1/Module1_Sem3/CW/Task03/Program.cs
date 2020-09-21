using System;

namespace Task03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out int grade))
            {
                Console.WriteLine("Error");
                return;
            }

            switch (grade)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("неудовлетворительно");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("удовлетворительно");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("хорошо");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("отлично");
                    break;
                    
                        
            }
        }
    }
}