using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        int[] a1 = new int[s1.Split(' ').Length];
        int[] a2 = new int[s2.Split(' ').Length];

        for (int i = 0; i < a1.Length; i++)
        {
            a1[i] = int.Parse(s1[i].ToString());
        }
        for (int i = 0; i < a1.Length; i++)
        {
            a2[i] = int.Parse(s2[i].ToString());
        }
        
        //to be continued
        
    }
}