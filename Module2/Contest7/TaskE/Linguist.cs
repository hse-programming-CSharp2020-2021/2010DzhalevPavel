using System;
using System.Collections.Generic;
using System.Linq;

class Linguist : Editor
{

    public string BannedWord { get; set; }
    
    private Linguist(string name, int salary, string bannedWord) : base(name, salary)
    {
        BannedWord = bannedWord;
    }

    public new string EditHeader(string header)
    {
        /*List<string> words = header.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        foreach (string word in words)
        {
            if (word == BannedWord)
                words.Remove(word);
        }

        header = "";
        
        foreach (var word in words)
        {
            header = header + word + " ";
        }*/
        return base.EditHeader(header.Replace(BannedWord, ""));
    }

    public static Linguist Parse(string line)
    {
        string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if(words.Length!=3||!int.TryParse(words[1], out int sal))
            throw new ArgumentException("Incorrect input");
        return new Linguist(words[0], sal, words[2]);
    }
}