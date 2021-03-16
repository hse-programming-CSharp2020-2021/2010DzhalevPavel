using System;
using System.Collections.Generic;
using System.IO;

namespace ReadText
{
    /*Написать программу, читающую файл со своим собственным исходным текстом и разыскивающую
     в тексте десятичные цифры. Использовать FileStream. 
     Помнить про относительные пути @"..\..\..\..\MyTest.txt".
    */
    class Program
    {
        static void Main(string[] args)
        {
            string path = $@"..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}test.txt";
            // чтение из файла
            using (FileStream fstream = File.OpenRead($"{path}"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                var numbers = new List<int>();
                foreach(string word in textFromFile.Split(new char[]{' ', ','}))
                {
                    if(int.TryParse(word, out int n) && n >= 10 && n<= 99)
                        numbers.Add(n);
                }
                Console.WriteLine($"Текст из файла: {textFromFile}");
                Console.WriteLine($"These numbers were found in the file: ");
                foreach (var n in numbers)
                {
                    Console.Write(n+" ");
                }
                
            }
        }
    }
}