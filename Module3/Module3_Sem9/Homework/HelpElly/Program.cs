using System;
using MagicCity;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FirstProgram

            Console.WriteLine($"Input file is correct: {OpenAndCheck.Verify()}");
            Console.WriteLine($"Number of streets: {OpenAndCheck.NumberOfStreets}");
            OpenAndCheck.CreateArray();
            OpenAndCheck.SaveFile();

            #endregion

            #region SecondProgram

            if (OpenAndCheck.FileIsCorect)
            {
                FindMagicStreets.RetrieveInfo();
                FindMagicStreets.SetMagicStreets();
            }
            

            #endregion
        }
    }
}