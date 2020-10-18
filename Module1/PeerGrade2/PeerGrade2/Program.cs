using System;
using System.Linq;
using System.IO;

namespace Project
{
    class Program
    {
        /// <summary>
        /// Метод для получения информации о файле по указанному пути в директории
        /// </summary>
        /// <param name="dir">Путь до директории</param>
        static void GetInformationAboutFile(string dir = "")
        {
            string s = "";
            Console.WriteLine("Введите относительный путь до файла внутри директории");
            s = Console.ReadLine();
            if (File.Exists(dir + "\\" + s)) // Проверка на существование файла
            {
                Console.WriteLine($"Файл {dir + "\\" + s} существует:");
                //Doesn't work
                //Console.WriteLine($"Свойства доступа: {File.GetAccessControl(dir + "\\" + s)}"); // Свойства доступа
                Console.WriteLine($"Атрибуты: {File.GetAttributes(dir + "\\" + s)}");
                Console.WriteLine($"Время создания: {File.GetCreationTime(dir + "\\" + s)}"); // Время создания
                Console.WriteLine(
                    $"Время создания UTC: {File.GetCreationTimeUtc(dir + "\\" + s)}"); // Время создания UTC
                Console.WriteLine(
                    $"Время последнего обращения: {File.GetLastAccessTime(dir + "\\" + s)}"); // Время последнего обращения
                Console.WriteLine(
                    $"Время последнего обращения UTC: {File.GetLastAccessTimeUtc(dir + "\\" + s)}"); // Время последнего обращения UTC
                Console.WriteLine(
                    $"Время последнего изменения: {File.GetLastWriteTime(dir + "\\" + s)}"); // Время последнего изменения
                Console.WriteLine(
                    $"Время последнего изменения UTC: {File.GetLastWriteTimeUtc(dir + "\\" + s)}"); // Время последнего изменения UTC
            }
        }


        /// <summary>
        /// Рекурсивыный вывод списка подпапок и файлов в них
        /// </summary>
        /// <param name="counter">Счётчик пустых папок</param>
        /// <param name="path">Адрес директории</param>
        /// <param name="depth">Уровень поддиректории</param>
        static void ShowListDirReq(ref int counter, string path, string depth = "-")
        {
            if (depth.Length == 1)
            {
                Console.WriteLine(path.Split(new char[] {'\\'})[path.Split(new char[] {'\\'}).Length - 1]);
            }

            Console.WriteLine(
                $"{depth}Files: {Directory.EnumerateFiles(path).Count()}, Dirs: {Directory.EnumerateDirectories(path).Count()}");
            if (Directory.EnumerateFiles(path).Count() + Directory.EnumerateDirectories(path).Count() == 0)
            {
                counter += 1;
                return;
            }

            foreach (string file in Directory.EnumerateFiles(path))
            {
                Console.WriteLine(depth + file.Substring(path.Length + 1));
            }

            foreach (string dir in Directory.EnumerateDirectories(path))
            {
                Console.WriteLine(depth + dir.Substring(path.Length + 1));
                ShowListDirReq(ref counter, dir, depth + "-");
            }
        }

        /// <summary>
        /// Найти поддиректорию с заданным именем
        /// </summary>
        /// <param name="path">Где искать</param>
        /// <param name="dirname">Что искать</param>
        /// <param name="depth">Уровень</param>
        /// <returns></returns>
        static string FindDirReq(string path, string dirname, int depth = 0)
        {
            if (path.Split(new char[] {'\\'})[path.Split(new char[] {'\\'}).Length - 1] == dirname)
            {
                return path;
            }

            foreach (string dir in Directory.EnumerateDirectories(path))
            {
                string s = FindDirReq(dir, dirname, depth + 1);
                if (s.Length > 0) return s;
            }

            return "";
        }

        /// <summary>
        /// This method retrieves drive data.
        /// </summary>
        static void Drives()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            
            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine("  File system: {0}", d.DriveFormat);
                    Console.WriteLine(
                        "  Available space to current user:{0, 15} bytes",
                        d.AvailableFreeSpace);

                    Console.WriteLine(
                        "  Total available space:          {0, 15} bytes",
                        d.TotalFreeSpace);

                    Console.WriteLine(
                        "  Total size of drive:            {0, 15} bytes ",
                        d.TotalSize);
                }
            }
        }

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(
                    @"Добро пожаловать в программу для расширенного управления файловой системой вашего компьютера
Use cd <global directory path> or cd <local directory path> for changing your directory
во всех командах <глобальный путь ...> - это глобальный путь, который можно изменить на <локальный путь ...> - локальный путь
Use ls or ls <path to folder> in order to show all folders and files in the current or selected directory
Для того, чтобы переместить папку используйте команду mv <путь до существующей папки> <путь по которому переместить папку>
Для того, чтобы удалить пустую папку используйте команду rmdir <путь>
Use rm to remove a file or folder <path> [parameter]
   --- no parameter - delete file or empty folder
   --- -r  - file or folder and all contained files and folders
Для того, чтобы выйти из программы используйте команду exit");
                string command = "";
                do
                {
                    //Get current directory.
                    string dir = Directory.GetCurrentDirectory();
                    Console.Write(dir + ": ");
                    command = Console.ReadLine();
                    string[] commands = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    string wrongCommand = "Command is wrong, not sufficient, or not supported.";
                    switch (commands[0])
                    {
                        case "cd":
                        {
                            try
                            {
                                if (commands.Length != 2)
                                {
                                    Console.WriteLine(wrongCommand);
                                }
                                else
                                {
                                    Directory.SetCurrentDirectory(commands[1]);
                                }
                            }
                            catch (IOException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        }
                        case "ls":
                        {
                            try
                            {
                                if (commands.Length < 1 || commands.Length > 2)
                                {
                                    Console.WriteLine(wrongCommand);
                                }
                                else
                                {
                                    if (commands.Length == 1)
                                    {
                                        foreach (string file in Directory.EnumerateFileSystemEntries(dir))
                                        {
                                            Console.WriteLine(
                                                file.Split(new char[] {'\\'})[
                                                    file.Split(new char[] {'\\'}).Length - 1]);
                                        }
                                    }
                                    else
                                    {
                                        foreach (string file in Directory.EnumerateFileSystemEntries(commands[1]))
                                        {
                                            Console.WriteLine(
                                                file.Split(new char[] {'\\'})[
                                                    file.Split(new char[] {'\\'}).Length - 1]);
                                        }
                                    }
                                }
                            }
                            catch (IOException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        }
                        case "mv":
                        {
                            try
                            {
                                if (commands.Length != 3)
                                {
                                    Console.WriteLine(wrongCommand);
                                }
                                else
                                {
                                    Directory.Move(commands[1], commands[2]);
                                }
                            }
                            catch (IOException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        }
                        case "rmdir":
                        {
                            try
                            {
                                if (commands.Length != 2)
                                {
                                    Console.WriteLine(wrongCommand);
                                }
                                else
                                {
                                    if (Directory.EnumerateFileSystemEntries(commands[1]).Count() > 0)
                                    {
                                        Console.WriteLine(
                                            "Папка не пуста, для удаления папки воспользуйтес командой rm <путь> -r");
                                    }
                                    else
                                    {
                                        Directory.Delete(commands[1]);
                                    }
                                }
                            }
                            catch (IOException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        }
                        case "rm":
                        {
                            try
                            {
                                if (commands.Length != 2 && commands.Length != 3)
                                {
                                    Console.WriteLine(wrongCommand);
                                }
                                else
                                {
                                    if (commands.Length == 2)
                                    {
                                        Directory.Delete(commands[1]);
                                    }
                                    else
                                    {
                                        if (commands[2] == "-r")
                                        {
                                            Directory.Delete(commands[1], true);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Неизвестный параметр");
                                        }
                                    }
                                }
                            }
                            catch (IOException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        }
                        case "drives":
                        {
                            if (commands.Length != 1)
                            {
                                Console.WriteLine(wrongCommand);
                            }
                            else
                            {
                                Program.Drives();
                            }
                            break;
                        }
                        case "exit":
                        {
                            if (commands.Length != 1)
                            {
                                Console.WriteLine(wrongCommand);
                            }
                            else
                            {
                                command = "exit";
                            }

                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Command doesn't exist");
                            break;
                        }
                    }
                } while (command != "exit");


                Console.WriteLine("Для завершения работы программы нажмите Escape, иначе - любую кнопку");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            //File.Move()
        }
    }
}