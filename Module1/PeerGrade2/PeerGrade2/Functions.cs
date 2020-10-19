using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PeerGrade2
{
    /// <summary>
    /// This file contains all the functionalities of this project.
    /// </summary>
    public class Functions
    {
        //Global error message is stored in a variable for easy access.
        static string functionsError =
            @"Something went wrong! Please check spelling again or press ""help"" to see all commands...";

        /// <summary>
        /// This function lists all available commands and is called when the user presses "help".
        /// </summary>
        public static void Help()
        {
            Console.WriteLine(@"Type ""disk"" [parameter] choose a drive directory, where [parameter] is:
   --- no parameter - lists all available disks
   --- change <path> - change to chosen drive
Type ""cd"" <path> to change your current director, where <path> is:
   --- .. - go back a directory
   --- <path> - name of directory contained in the current directory
Type ""ls"" to list all files in the current directory
Type ""view"" <filename> [encoding] to view all contents of a file, where [encoding] is:
   --- no encoding - file is displayed using UTF-8 by default
   --- ascii - ASCII encoding id used while reading the file
   --- unicode - UNICODE encoding id used while reading the file
   --- utf-32 - uft-32 encoding id used while reading the file
Type ""copy"" <fileName> to copy a file
Type ""move"" <fileName> <destinationPath> to move a file. Relative paths are supported.
Type ""del"" <fileName> to delete a file
Type ""create"" <fineName> [encoding] to create a file, where [encoding] is:
   --- no parameter - the default UTF-8 encoding is used
   --- ascii - ASCII encoding id used while creating the file
   --- unicode - UNICODE encoding id used while creating the file
   --- utf-32 - uft-32 encoding id used while creating the file
Type ""combine"" <fileName> [parameters] to combine different files, where [parameters] are fileName within
the same directory. The content is saved in the first file. Combined files are deleted.
Type ""clear"" to clear the console
Type ""exit"" to exit the program");
        }

        /// <summary>
        /// This method lists all currently active drives using the DriveInfo class.
        /// </summary>
        /// <param name="parameters">How many parameters are passed</param>
        public static void showDisks(string[] parameters)
        {
            //This is a common check performed in this file. It makes sure that the amount of
            //commands correspond to the number of parameters of the method.
            if (parameters.Length != 3 && parameters.Length != 1)
            {
                Console.WriteLine(functionsError);
            }

            if (parameters.Length == 1 && parameters[0] == "disk")
            {
                Console.WriteLine("Your currently active drives are:");
                DriveInfo[] disks = DriveInfo.GetDrives();

                foreach (DriveInfo drive in disks)
                {
                    Console.WriteLine(
                        $"{drive.Name,2} | Total space: {drive.TotalSize,2} | " +
                        $"Available space {drive.TotalFreeSpace,2}");
                }
            }

            if (parameters.Length == 3 && parameters[0] == "disk" && parameters[1] == "-change" &&
                Directory.Exists(parameters[2]))
            {
                Directory.SetCurrentDirectory(parameters[2]);
            }
        }

        /// <summary>
        /// This method is used to exit from the switch cycle in Switcher.cs.
        /// </summary>
        /// <param name="parameters">This array contains all user commands.</param>
        /// <param name="command">This string changes the command string in Switcher.cs in order to exit the cycle</param>
        public static void Exit(string[] parameters, out string command)
        {
            //This is a common check performed in this file. It makes sure that the amount of
            //commands correspond to the number of parameters of the method.
            if (parameters.Length != 1)
            {
                Console.WriteLine(functionsError);
                command = " ";
            }

            else
            {
                Console.WriteLine("Exiting...");
                //This timer is added just to make the program more interesting. It serves no practical purpose.
                System.Threading.Thread.Sleep(2000);
                command = "exit";
            }
        }

        /// <summary>
        /// This method lists all files.
        /// </summary>
        public static void List()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string file in files)
            {
                file.Split(Path.PathSeparator);
                Console.WriteLine(file.Split(Path.DirectorySeparatorChar)
                    [file.Split(Path.DirectorySeparatorChar).Length - 1]);
            }
        }

        /// <summary>
        /// This method allows the user to change directories.
        /// </summary>
        /// <param name="commands"></param>
        public static void ChangeDirectory(string[] commands)
        {
            //This is a common check performed in this file. It makes sure that the amount of
            //commands correspond to the number of parameters of the method.
            if (commands.Length != 2)
            {
                Console.WriteLine(functionsError);
            }
            else
            {
                if (commands[1] == "..")
                {
                    Directory.SetCurrentDirectory("..");
                }
                else
                {
                    try
                    {
                        Directory.SetCurrentDirectory(commands[1]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message + "Please check the path again.");
                    }
                }
            }
        }

        /// <summary>
        /// This method opens and reads all of the text in a specified file.
        /// It also provides functionality for reading the file in different encodings (UTF-8 - default, ASCII, UNICODE, UTF-32).
        /// </summary>
        /// <param name="commands">The command array entered by the user</param>
        public static void ViewFile(string[] commands)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            //This is a common check performed in this file. It makes sure that the amount of
            //commands correspond to the number of parameters of the method.
            if (commands.Length == 2)
                try
                {
                    Console.WriteLine(File.ReadAllText(commands[1], Encoding.UTF8));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please choose an existing file");
                }
            else if (commands.Length == 3)
            {
                switch (commands[2])
                {
                    case "utf-8":
                    {
                        try
                        {
                            Console.WriteLine(File.ReadAllText(commands[1], Encoding.UTF8));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Please choose an existing file");
                        }

                        break;
                    }
                    case "ascii":
                    {
                        try
                        {
                            Console.WriteLine(File.ReadAllText(commands[1], Encoding.ASCII));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Please choose an existing file");
                        }

                        break;
                    }
                    case "unicode":
                    {
                        try
                        {
                            Console.WriteLine(File.ReadAllText(commands[1], Encoding.Unicode));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Please choose an existing file");
                        }

                        break;
                    }
                    case "utf-32":
                    {
                        try
                        {
                            Console.WriteLine(File.ReadAllText(commands[1], Encoding.UTF32));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Please choose an existing file");
                        }

                        break;
                    }
                    default:
                    {
                        Console.WriteLine("This encoding doesn't exist or is not yet supported by this program.");
                        Console.WriteLine("Please choose a supported encoding.");
                        break;
                    }
                }
            }
            else
                Console.WriteLine("This file doesn't exist.");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }

        /// <summary>
        /// This function copies a file in the current directory.
        /// </summary>
        /// <param name="commands"></param>
        public static void CopyFile(string[] commands)
        {
            //This is a common check performed in this file. It makes sure that the amount of
            //commands correspond to the number of parameters of the method.
            if (commands.Length == 2)
            {
                try
                {
                    //TODO: Repair output fileName
                    File.Copy(commands[1], commands[1] + "-copy");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
                Console.WriteLine(functionsError);
        }

        public static void MoveFile(string[] commands)
        {
            //This is a common check performed in this file. It makes sure that the amount of
            //commands correspond to the number of parameters of the method.
            if (commands.Length == 3)
            {
                //TODO: Access denied when moving a file back to a folder
                try
                {
                    File.Move(commands[1], commands[2] + commands[1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
                Console.WriteLine(functionsError);
        }

        /// <summary>
        /// This function deletes a specified file
        /// </summary>
        /// <param name="commands"></param>
        public static void DeleteFile(string[] commands)
        {
            //This is a common check performed in this file. It makes sure that the amount of
            //commands correspond to the number of parameters of the method.
            if (commands.Length == 2)
            {
                try
                {
                    if (File.Exists(commands[1]))
                        File.Delete(commands[1]);
                    else
                        Console.WriteLine("This file doesn't exist. Please check spelling.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
                Console.WriteLine(functionsError);
        }


        /// <summary>
        /// This method creates files. It allows the user to enter some text and choose encoding.
        /// </summary>
        /// <param name="commands"></param>
        public static void CreateFile(string[] commands)
        {
            //This is a common check performed in this file. It makes sure that the amount of
            //commands correspond to the number of parameters of the method.
            if (commands.Length == 2)
            {
                try
                {
                    Console.Write("Write some text to include in the file: ");
                    string inputText = Console.ReadLine();
                    File.WriteAllText(commands[1], inputText, Encoding.UTF8);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else if (commands.Length == 3)
            {
                switch (commands[2])
                {
                    case "utf-8":
                    {
                        try
                        {
                            Console.Write("Write some text to include in the file: ");
                            string inputText = Console.ReadLine();
                            File.WriteAllText(commands[1], inputText, Encoding.UTF8);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    }
                    case "ascii":
                    {
                        try
                        {
                            Console.Write("Write some text to include in the file: ");
                            string inputText = Console.ReadLine();
                            File.WriteAllText(commands[1], inputText, Encoding.ASCII);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    }
                    case "unicode":
                    {
                        try
                        {
                            Console.Write("Write some text to include in the file: ");
                            string inputText = Console.ReadLine();
                            File.WriteAllText(commands[1], inputText, Encoding.Unicode);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    }
                    case "utf-32":
                    {
                        try
                        {
                            Console.Write("Write some text to include in the file: ");
                            string inputText = Console.ReadLine();
                            File.WriteAllText(commands[1], inputText, Encoding.UTF32);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    }
                    default:
                    {
                        Console.WriteLine("This encoding doesn't exist or is not yet supported by this program.");
                        Console.WriteLine("Please choose a supported encoding.");
                        break;
                    }
                }
            }
            else Console.WriteLine(functionsError);
        }

        /// <summary>
        /// This method combines different files. It has the functionality to combine more that 2 files.
        /// </summary>
        /// <param name="commands"></param>
        public static void Combine(string[] commands)
        {
            //A for cycle allows the user to combine as many files as they want.
            for (int i = 2; i < commands.Length; i++)
            {
                try
                {
                    //Before execution of the combination, file existence is checked to prevent errors.
                    if (File.Exists(commands[i]))
                    {
                        File.AppendAllText(commands[1], File.ReadAllText(commands[i]));
                        File.Delete(commands[i]);
                    }
                    else
                        Console.WriteLine(
                            "One or more of the files that you have entered doesn't exist. Please check spelling.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }
    }
}