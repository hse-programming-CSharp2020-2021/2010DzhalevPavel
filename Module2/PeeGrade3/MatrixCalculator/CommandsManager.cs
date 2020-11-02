using System;
using System.IO;

namespace MatrixCalculator
{
    public class CommandsManager
    {
        /// <summary>
        /// This method selects the different commands.
        /// </summary>
         public static void SelectCommand()
        {
            string inputError = "This command doesn't exist. Please check spelling or type \"help\"";
            string command = "";

            do
            {
                Console.Write("~");

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
                        case "principal":
                        {
                            Functions.Principal();
                            break;
                        }
                        case "transpose":
                        {
                           Functions.Transpose();
                            break;
                        }
                        case "add":
                        {
                            Functions.AddTwo();
                            break;
                        }
                        case "subtract":
                        {
                            Functions.SubtractTwo();
                            break;
                        }
                        case "multiply-two":
                        {
                            Functions.MultiplyTwo();
                            break;
                        }
                        case "multiply-by-number":
                        {
                            Functions.MultiplyByNumber();
                            break;
                        }
                        case "det":
                        {
                            Functions.Det();
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