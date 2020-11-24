using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public partial class Program
{
    public static bool ParseCommandsCount(string input, out int count)
    {
        if (int.TryParse(input, out count))
            return true;
        return false;
    }

    public class Logger
    {
        string[] logs;
        private static Logger logger;

        public Logger(string[] logs)
        {
            this.logs = logs;
        }

        public static Logger GetLogger()
        {
            return  logger;
        }

        public static void HandleCommand(string command)
        {
            Logger log = GetLogger();
            string[] cmds = command.Split(' ');
            int index = 0;
            switch (cmds[0])
            {
                case "AddLog":
                    var rx = new Regex(@"<(.*?)>");
                    var text = rx.Match(command.Substring(5)).Groups[1].Value;
                    log.logs[index] = text;
                    index++;
                    break;
                case "DeleteLastLog":
                    logger.logs[index] = "";
                    index--;
                    break;
                case "WriteAllLogs":
                    GetLogger();
                    if (logger.logs.Length==0)
                    {
                        File.WriteAllText("logs.log", "No active logs");
                    }
                    else
                    {
                        File.WriteAllLines("logs.log", logger.logs);
                    }
                    break;
                default:
                    File.WriteAllText("logs.log", "Incorrect input");
                    return;
            }
        }
    }

}