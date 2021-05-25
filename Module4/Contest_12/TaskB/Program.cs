using System;


//Link to help: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/statements#the-foreach-statement
public class Program
{
    public static void Main(string[] args)
    {
        using (StudentReader studentReader = new StudentReader("students.txt"))
        {
            double averageGpa = GetAverageGpa(studentReader);
            foreach (var item in studentReader.GetStudentsWithGreaterGpa(averageGpa))
            {
                Console.WriteLine(item);
            }
        }
    }

    private static double GetAverageGpa(StudentReader studentReader)
    {
        double averageGpa = .0;
        int studentsCount = 0;

        foreach (var item in studentReader)
        {
            averageGpa += item.Gpa;
            studentsCount += 1;
        }

        averageGpa /= studentsCount;
        return averageGpa;
    }
}