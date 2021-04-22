using System;
using System.Collections.Generic;

[Serializable]
public class Student
{
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public int GroupNumber { get; private set; }
    public List<int> Grades { get; private set; }

    public Student(string name, string lastName, int groupNumber, List<int> grades)
    {
        Name = name;
        LastName = lastName;
        GroupNumber = groupNumber;
        Grades = grades;
    }

    public static Student Create(string studentInfo)
    {
        var sInfo = studentInfo.Trim().Split(" ");
        string name = sInfo[0];
        string lastName = sInfo[1];
        int groupN = int.Parse(sInfo[2]);
        List<int> grades = new List<int>();
        for (int i = 3; i < sInfo.Length; i++)
        {
            grades.Add(int.Parse(sInfo[i]));
        }
        Student newStudent = new Student(name,
            lastName,
            groupN,
            grades);

        return newStudent;
    }
}