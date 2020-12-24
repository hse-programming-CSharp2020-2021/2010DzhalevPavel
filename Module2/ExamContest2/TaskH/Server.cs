using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class Server
{
    private static Server _instance;
    private string name;
    private static StringBuilder sb = new StringBuilder();

    public Server()
    {
    }

    public static Server Connect(string name)
    {
        if (_instance == null)
        {
            _instance = new Server();
            _instance.name = name;
        }
 
        return _instance;
    }

    public void Send(string message)
    {
        if(name == null)
            throw new ArgumentException("No connected server");
        sb.AppendLine($"Sending data {message} to server {name}");
    }

    public void Receive(string message)
    {
        if(name == null)
            throw new ArgumentException("No connected server");
        sb.AppendLine($"Receiving data {message} from server {name}");
    }

    public void Output()
    {
        
        //Copied from stackoverflow
        //https://stackoverflow.com/questions/7647716/how-to-remove-empty-lines-from-a-formatted-string
        var resultString = Regex.Replace(sb.ToString(), @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
        Console.WriteLine(resultString);
        sb.Clear();
    }
}