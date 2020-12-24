using System;

public class Student
{
    private string name;
    private int grade;
    
    public string Name 
    { 
        get=> name;
        set
        {
            if(value.Length<3 || value[0]>='a'&&value[0]<='z')
                throw new ArgumentException("Incorrect name");
            name = value;
        }
        
    }

    public int Grade
    {
        get => grade;
        set
        {
            if(value <0 || value > 10)
                throw new ArgumentException("Incorrect mark");
            grade = value;
        }
    }
    
    private Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public static Student Parse(string line)
    {
        string[] words = line.Split(' ');
        if(!int.TryParse(words[1], out int grade))
            throw new ArgumentException("Incorrect input mark");
        return new Student(words[0], grade);
    }

    public override string ToString()
    {
        return $"{Name} got a grade of {Grade}.";
    }
}