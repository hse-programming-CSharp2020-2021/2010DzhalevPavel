using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MagicCity;

namespace Homework
{
    public class FindMagicStreets
    {
        public static List<Street> StreetsArray { get; set;}
        public static List<Street> MagicStreets { get; set; }


        public static void RetrieveInfo()
        {
            StreetsArray = new List<Street>();
            int streetIndex = 0;
            using (var sr = new StreamReader("data.txt"))
            {
                do
                {
                    string[] line = sr.ReadLine().Trim().Split();
                    if (line?.Length > 1)
                    {
                        StreetsArray.Add(new Street());
                        StreetsArray[streetIndex].Name = line[0];
                        StreetsArray[streetIndex].Houses =
                            new int[line.Length - 1];
                        //Starting from 1, since this is the street name.
                        for (int i = 1; i <= line.Length - 1; i++)
                        {
                            StreetsArray[streetIndex].Houses[i - 1] = int
                                .Parse(line[i]);
                        }

                        streetIndex++;
                    }
                } while (!sr.EndOfStream);
            }
        }

        public static void SetMagicStreets()
        {
            MagicStreets = StreetsArray.Where(x => x.Houses.Contains(7)).ToList();
            MagicStreets = MagicStreets.Where(x => x.Houses.Length%2==1).ToList();

            Console.WriteLine($"Magic streets are: ");
            foreach (var magicStreet in MagicStreets)
            {
                Console.WriteLine(magicStreet);
            }
        }
    }
}