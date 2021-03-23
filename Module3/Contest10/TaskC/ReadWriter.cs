using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class ReadWriter
{
    public static Tuple<char, char> GetMostAndLeastCommonLetters(string path)
    {
        try
        {
            using (var sr = new StreamReader(path, Encoding.UTF8))
            {
                var d = new Dictionary<char, int>();

                while (!sr.EndOfStream)
                {
                    foreach (var letter in sr.ReadLine())
                    {
                        if (char.IsLetter(letter))
                        {
                            if (d.ContainsKey(char.ToLower(letter)))
                            {
                                d[char.ToLower(letter)] += 1;
                            }
                            else
                            {
                                d.Add(char.ToLower(letter), 1);
                            }
                        }
                    }
                }

                char most = ' ', less = ' ';
                int max = 0;
                foreach (var l in d.Keys)
                {
                    if (d[l] > max)
                    {
                        max = d[l];
                        most = l;
                    }
                }

                int min = max;
                foreach (var l in d.Keys)
                {
                    if (Char.IsLetter(l))
                    {
                        if (d[l] < min)
                        {
                            min = d[l];
                            less = l;
                        }
                    }
                }

                /*if (min == max)
                {
                    bool ch = false;
                    foreach (var c in d)
                    {
                        if (c.Value == min && ch)
                            less = c.Key;
                        if (c.Value == min)
                            ch = true;
                    }

                    return new Tuple<char, char>(most, less);
                }*/

                return new Tuple<char, char>(most, less);
            }
        }
        catch (Exception e)
        {
            return new Tuple<char, char>('0', '0');
        }
    }

    public static void ReplaceMostRareLetter(
        Tuple<char, char> leastAndMostCommon, string inputPath,
        string outputPath)
    {
        using (var sr = new StreamReader(inputPath))
        {
            using (var sw = new StreamWriter(outputPath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    char[] newLineArray = new char[line.Length];
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.ToLower(line[i]) == leastAndMostCommon.Item2)
                        {
                            if (char.IsLower(line[i]))
                                newLineArray[i] = leastAndMostCommon.Item1;
                            else
                                newLineArray[i] =
                                    char.ToUpper(leastAndMostCommon.Item1);
                        }
                            
                        else
                        {
                            newLineArray[i] = line[i];
                        }
                    }

                    string newLine = string.Empty;
                    foreach (var c in newLineArray)
                    {
                        newLine += c;
                    }

                    sw.WriteLine(newLine);
                }
            }
        }
    }
}