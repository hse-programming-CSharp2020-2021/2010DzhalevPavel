using System;


public class Group
{
    private Student[] _students;
    
    public Student[] Students
    {
        get => _students;
        set
        {
            if(value.Length <5)
                throw new ArgumentException("Incorrect group");
            _students = value;
        }
    }
    public Group(Student[] students)
    {
        Students = students;
    }

    public int IndexOfMaxGrade()
    {
        int maxGrade = Students[0].Grade;
        int index = 0;
        
        for (var i = 0; i < Students.Length; i++)
        {
            if (Students[i].Grade > maxGrade)
            {
                maxGrade = Students[i].Grade;
                index = i;
            }
        }

        return index;
    }

    public int IndexOfMinGrade()
    {
        int minGrade = Students[0].Grade;
        int index = 0;
        
        for (var i = 0; i < Students.Length; i++)
        {
            if (Students[i].Grade < minGrade)
            {
                minGrade = Students[i].Grade;
                index = i;
            }
        }

        return index;
    }

    public Student this[int i] => Students[i];
}