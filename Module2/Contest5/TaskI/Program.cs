using System;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
	    Stopwatch sw = new Stopwatch();
	    sw.Start();
	    string s = Console.ReadLine();
		string initialSubstring = Console.ReadLine();
		string finalSubstring = Console.ReadLine();

	    var replacedString = new ReplacedString(s, initialSubstring, finalSubstring);

	    Console.WriteLine(replacedString);
	    sw.Stop();
	    Console.WriteLine(sw.Elapsed);
    }
}

