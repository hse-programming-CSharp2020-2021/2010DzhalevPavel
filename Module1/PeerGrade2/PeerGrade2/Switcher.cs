using System;
using System.Data.Common;
using System.IO;
using System.Resources;

namespace PeerGrade2
{
    /// <summary>
    /// This file accepts all commands from the user and calls the specified methods.
    /// </summary>
    public class Switcher
    {
        /// <summary>
        /// This is the method that handles the input of commands and invokes all functions of the program.
        /// </summary>
        public static void SelectCommand()
        {
            string inputError = "This command doesn't exist. Please check spelling or type \"help\"";
            string command = "";

            do
            {
                //Display current directory
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(Directory.GetCurrentDirectory() + ":");
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                //User enters command.
                command = Console.ReadLine();

                //Split the command in an array in order to differentiate commands and arguments.
                //We also remove empty array elements.
                string[] commands = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (commands.Length > 0)
                {
                    //We use a switch cycle to handle different commands.
                    switch (commands[0])
                    {
                        case "help":
                        {
                            Functions.Help();
                            break;
                        }
                        case "disk":
                        {
                            Functions.showDisks(commands);
                            break;
                        }
                        case "ls":
                        {
                            Functions.List();
                            break;
                        }
                        case "cd":
                        {
                            Functions.ChangeDirectory(commands);
                            break;
                        }
                        case "view":
                        {
                            Functions.ViewFile(commands);
                            break;
                        }
                        case "copy":
                        {
                            Functions.CopyFile(commands);
                            break;
                        }
                        case "move":
                        {
                            Functions.MoveFile(commands);
                            break;
                        }
                        case "del":
                        {
                            Functions.DeleteFile(commands);
                            break;
                        }
                        case "create":
                        {
                            Functions.CreateFile(commands);
                            break;
                        }
                        case "clear":
                        {
                            Console.Clear();
                            break;
                        }
                        case "combine":
                        {
                            Functions.Combine(commands);
                            break;
                        }
                        case "exit":
                        {
                            Functions.Exit(commands, out command);
                            break;
                        }
                        default:
                            Console.WriteLine(inputError);
                            break;
                    }
                }
                //We exit the switch cycle on "exit".
            } while (command != "exit");
        }
    }
}