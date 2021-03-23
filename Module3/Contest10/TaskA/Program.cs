using System;
using System.IO;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        using (var sr = new StreamReader("input.txt"))
        {
            ushort n = ushort.Parse(sr.ReadLine());
            ushort[] arr = new ushort[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = ushort.Parse(sr.ReadLine());
            }

            //using var writeStream = new FileStream("output.bin", FileMode.Create, FileAccess.Read);
            using var binWriter = new BinaryWriter(File.Open("output.bin", FileMode.Create));
            binWriter.Write(n);
            foreach (var number in arr)
            {
                binWriter.Write(number);
            }
        }
    }
}