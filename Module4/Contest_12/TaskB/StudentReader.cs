using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class StudentReader : IDisposable, IEnumerable<Student>
{
    private List<Student> _students = new List<Student>();

    public StudentReader(string path)
    {
        using (var sr = new StreamReader(path))
        {
            while (!sr.EndOfStream)
            {
                var stu = Student.PreprocessStudentData(sr.ReadLine());
                
                _students.Add(new Student(
                    stu.Item1, 
                    stu.Item2));
            }
        }
    }

    public IEnumerable<Student> GetStudentsWithGreaterGpa(double gpa)
    {
        foreach (var student in _students)
        {
            if (student.Gpa > gpa)
                yield return student;
        }
    }

    public void Dispose()
    {
        _students = null;
    }

    public IEnumerator<Student> GetEnumerator()
    {
        foreach (var student in _students)
        {
            yield return student;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}