using System;

namespace Schedule
{
    class Program
    { 
        class Schedule
        {
            public string this[int i]
            {
                get
                {
                    switch (i)
                    {
                        case 1:
                            return "Monday";
                            break;
                        case 2:
                            return "Tueday";
                            break;
                        case 3:
                            return "Wednesday";
                            break;
                        case 4:
                            return "Thursday";
                            break;
                        case 5:
                            return "Friday";
                            break;
                        case 6:
                            return "Saturday";
                            break;
                        case 7:
                            return "Sunday";
                            break;
                        default:
                            return "Unfortunately, there is no such day!";
                            break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Schedule sc = new Schedule();

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Today is {sc[n]}");
        }
    }
}