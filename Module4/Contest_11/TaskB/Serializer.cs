using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Serializer
{
    private static List<Student> _students = new List<Student>();

    public static List<Student> Students
    {
        get => _students;
        set => _students = value;
    }

    public static void ReadStudents(string path)
    {
        using (var sr = new StreamReader(path))
        {
            while (!sr.EndOfStream)
            {
                Students.Add(Student.Create(sr.ReadLine()));
            }
        }
    }

    public static void SerializeStudents(string path)
    {
        using (var fs = new FileStream("output.bin", FileMode.Create))
        {
            var bf = new BinaryFormatter();
            bf.Serialize(fs, Students);
        }

        
        
    }
}