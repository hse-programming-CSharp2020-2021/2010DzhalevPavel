using System;
using System.IO;
using MagicCity;

namespace Homework
{
    /// <summary>
    /// By default, the first and last line of the file "data.txt" are ignored,
    /// as shown in the example.
    /// </summary>
    public static class OpenAndCheck
    {
        public static Street[] StreetsArray { get; set; }
        public static int NumberOfStreets { get; set; }
        public static bool FileIsCorect { get; set; }
        
        public static int Lines { get; set; }

        /// <summary>
        /// This method is used for checking the validity of the file "data.txt".
        /// It also counts the number of streets in the document.
        /// </summary>
        /// <returns></returns>
        public static bool Verify()
        {
            FileIsCorect = true;
            try
            {
                using (var sr = new StreamReader("data.txt"))
                {
                    do
                    {
                        string[] line = sr.ReadLine().Trim().Split();
                        if (line?.Length > 1)
                        {
                            //Starting from 1, since this is the street name.
                            for (int i = 1; i <= line.Length-1; i++)
                            {
                                if (!int.TryParse(line[i], out int n) ||
                                    n > 100 || n <= 0) FileIsCorect = false;
                            }
                            NumberOfStreets++;
                            Lines++;
                        }
                    } while (!sr.EndOfStream);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                FileIsCorect = false;
            }
            
            return FileIsCorect;
            }
        
        public static void CreateArray()
        {
            //There were errors in the "data.txt" file.
            if (!FileIsCorect)
            {
                var rand = new Random();
                StreetsArray = new Street[NumberOfStreets];
            
                for (int i = 0; i < StreetsArray.Length; i++)
                {
                    StreetsArray[i] = new Street();
                    var houses = rand.Next(1, 10);
                    StreetsArray[i].Houses = new int[houses];
                    for (int j = 0; j < houses; j++)
                    {
                        StreetsArray[i].Houses[j] = rand.Next(1, 100);
                    }

                    var name = string.Empty;
                    for (int j = 0; j < 5; j++)
                    {
                        name += (char)rand.Next('a', 'z');
                    }

                    StreetsArray[i].Name = name;
                }
            }
            //No errors in "data.txt"
            else
            {
                int arraySize;
                if (NumberOfStreets > Lines) arraySize = Lines;
                else arraySize = NumberOfStreets;

                StreetsArray = new Street[arraySize];
                int streetIndex = 0;
                using (var sr = new StreamReader("data.txt"))
                {
                    
                    do
                    {
                        string[] line = sr.ReadLine().Trim().Split();
                        if (line?.Length > 1)
                        {
                            StreetsArray[streetIndex] = new Street();
                            StreetsArray[streetIndex].Name = line[0];
                            StreetsArray[streetIndex].Houses =
                                new int[line.Length - 1];
                            //Starting from 1, since this is the street name.
                            for (int i = 1; i <= line.Length-1; i++)
                            {
                                StreetsArray[streetIndex].Houses[i - 1] = int
                                    .Parse(line[i]);
                            }

                            streetIndex++;
                        }
                    } while (!sr.EndOfStream);
                }
            }
            
            DisplayStreets();
        }

        public static void DisplayStreets()
        {
            foreach (var street in StreetsArray)
            {
                Console.WriteLine(street);
            }
        }

        public static void SaveFile()
        {
            using (var sw = new StreamWriter("out.txt"))
            {
                sw.WriteLine("================");
                Console.SetOut(sw);
                DisplayStreets();
                var standardOutput = new StreamWriter(Console.OpenStandardOutput());
                standardOutput.AutoFlush = true;
                Console.SetOut(standardOutput);
                sw.WriteLine("================");
            }
        }
        
            
    }
}