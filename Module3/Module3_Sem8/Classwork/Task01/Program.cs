﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Task_1
{
    class ColorPoint
    {
        public static string[] colors = { "Red", "Green", "DarkRed", "Magenta",
            "DarkSeaGreen", "Lime", "Purple", "DarkGreen", "DarkOrange", "Black",
            "BlueViolet", "Crimson", "Gray", "Brown", "CadetBlue" };
        public double x, y;
        public string color;
        public override string ToString()
        {
            string format = "{0:F3}    {1:F3}    {2}";
            return string.Format(format, x, y, color);
        }
    }
 
    class Program
    {
        static Random gen = new Random();
        public static void Main()
        {
            string path = $@"..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}MyTest.txt";
            int N = 3; // Количество создаваемых объектов (число строк в файле)
            //  TODO: Определить значение N 
            List<ColorPoint> list = new List<ColorPoint>();
            ColorPoint one;
            for (int i = 0; i < N; i++)
            {
                one = new ColorPoint();
                one.x = gen.NextDouble();
                one.y = gen.NextDouble();
                int j = gen.Next(0, ColorPoint.colors.Length);
                one.color = ColorPoint.colors[j];
                list.Add(one);
            }
            string[] arrData = Array.ConvertAll(list.ToArray(),
                (ColorPoint cp) => cp.ToString());
            // Запись массива стpок в текстовый файл:         
            //File.WriteAllLines(path, arrData);

            #region FileStream

            // запись в файл
            using (FileStream fstream = new FileStream($"{path}\note.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                foreach (var color in arrData)
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(color);
                    fstream.Write(array, 0, array.Length);
                }
                // запись массива байтов в файл
                
                Console.WriteLine("Текст записан в файл");
            }

            #endregion
            Console.WriteLine("Записаны {0} строк в текстовый файл: \n{1}",
                N, path);
        }
    }
}