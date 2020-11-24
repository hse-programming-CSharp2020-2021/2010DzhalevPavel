using System;
public class ReplacedString
{
    private string replacedString;

    public ReplacedString(string s, string initialSubstring, string finalSubstring)
    {
        replacedString = s;
        bool flag = true;

        if (initialSubstring==finalSubstring)
        {
            return;
        }
        do
        {
            if (replacedString.Contains(initialSubstring))
            {
                replacedString = replacedString.Replace(initialSubstring, finalSubstring);
            }
            else flag = false;
        } while (flag);
        
    }
    
    //This method turned out to be useless.
    private bool SameChars(string input)
    {
        char[] c = input.ToCharArray();
        for (int i = 0; i < c.Length; i++)
        {
            if (c[i] != c[0])
                return false;
        }
        return true;
    }

    public override string ToString()
    {
        return replacedString;
    }
}