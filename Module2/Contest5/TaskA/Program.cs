using System;
using System.IO;

partial class Program
{
    public static void Main(string[] args)
	{
        uint rowCount = uint.Parse(Console.ReadLine());
        PrintJaggedArray(GetBellTriangle(rowCount));
    }
    //official.contest.yandex.ru/contest/21735/enter/
}

