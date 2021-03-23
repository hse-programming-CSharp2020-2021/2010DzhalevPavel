using System;
using System.IO;

public class BinaryFileReader
{
    private string path;

    public BinaryFileReader(string path)
    {
        this.path = path;
    }

    public int GetDifference()
    {
        int sum1 = 0, sum2 = 0;
        using (var br = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.Read)))
        {
            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                sum1 += br.ReadInt16();
            }

            br.BaseStream.Position = 0;
            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                sum2 += br.ReadInt32();
            } 
        }

        return sum2 - sum1;
    }
}