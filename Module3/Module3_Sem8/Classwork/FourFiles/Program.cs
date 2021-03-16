using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FourFiles
{
    /*Сгенерировать 10 случайных чисел и записать их 4 разными
    способами в 4 файла: с помощью класса File, с помощью FileStream,
    с помощью StreamWriter, с помощью BinaryWriter. Вывести содержимое
    каждого файла. Для любого файла, считывая данные побайтово или посимвольно
    или построчно (главное, не целиком весь файл), вывести сумму четных чисел.*/
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] arr = new int[4];

            //Fill the array with random numbers.
            for (int i = 0; i < 4; i++)
            {
                arr[i] = rand.Next();
            }
            
            string text = String.Empty;
            foreach (var n in arr)
            {
                text += n+" ";
                
            }
            
            string filePath = $"..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}";
            File.WriteAllText(filePath+"output1.txt", text);
            ReadAndCount(filePath+"output1.txt");
            
            using (var str = new FileStream(filePath + "output2.txt", FileMode.Create))
            {
                str.Write(Encoding.Default.GetBytes(text));
            }
            ReadAndCount(filePath+"output1.txt");

            using (var streamWriter = new StreamWriter(filePath+"output3.txt"))
            {
                streamWriter.Write(text);
            }
            ReadAndCount(filePath+"output1.txt");
            using ( var binWriter = new BinaryWriter(File.Create(filePath + "output4.txt")))
            {
                binWriter.Write(text);
            }
            ReadAndCount(filePath+"output1.txt");
        }

        public static void ReadAndCount(string filePath)
        {

            // чтение из файла
            using (FileStream fstream = File.OpenRead($"{filePath}"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                var numbers = new List<int>();
                foreach (string word in textFromFile.Split(new char[] {' ', ','}))
                {
                    if (int.TryParse(word, out int n) && n % 2 == 0)
                        numbers.Add(n);
                }

                Console.WriteLine($"Текст из файла: {textFromFile}");
                int sum = 0;
                numbers.ForEach(x => sum += x);
                Console.WriteLine($"This is the sum of all even numbers: {sum}");
            }
        }
    }
}