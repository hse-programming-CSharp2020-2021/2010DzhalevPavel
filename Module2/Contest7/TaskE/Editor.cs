using System;

abstract class Editor
{
    public string Name { get; set; }
    public int Salary { get; set; }
    
    protected Editor(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    protected string EditHeader(string header)
    {
        return $"{header} {Name}";
    }

    public int CountSalary(string oldStr, string newStr)
    {
        int diff = Math.Abs(oldStr.Length - newStr.Length);
        return diff * Salary;
    }
}