using System;
using System.IO;
using System.Linq;


namespace Task01
{
    /// <summary>
    /// This program shows all folders under a given path to a specified max
    /// level of folder structuring. For example
    /// </summary>
    class Program
    {
        static void DirectoryOverview(string path, int level)
        {
            if (level==0)
                return;
            //получаем имена всех директорий, вложенных в данную директорию по пути path
            var directories = Directory.GetDirectories(path);

 

            //проходимся по всем директориям
            for (int i = 0; i < directories.Length; i++)
            {
                var directory = directories[i];
                //создаем объект типа directoryInfo, хранящий информацию о директории по пути
                var directoryInfo = new DirectoryInfo(directory);
                //выводим информацию о соответствующих свойствах директории
                Console.WriteLine($"{directory}\n" +
                                  //список всех атрибутов директории
                                  $"attributes: {directoryInfo.Attributes}; " +
                                  //время создания
                                  $"creation time: {directoryInfo.CreationTime} " +
                                  //последнее обновление
                                  $"last update:{directoryInfo.LastWriteTime}\n");

 

                //рекурсивно выполняем метод для всех вложенных директорий
                DirectoryOverview(directory, level-1);
            }
        }

 

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Level of folders:");
                int level = int.Parse(Console.ReadLine());
                
                DirectoryOverview(@"../../../", level);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Произошла ошибка ввода/вывода: {ex.Message}");
            }
            catch (System.Security.SecurityException ex)
            {
                Console.WriteLine($"Произошла ошибка безопасности: {ex.Message}");
            }

 

        }
    }
}