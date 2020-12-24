using System;

namespace Task01
{
    class Program
    {
        class Student
        {
            private long _id;
            private int _testNum;

            public long Id
            {
                get => _id;
                set
                {
                    if (value >= 1 && value <= 1000)
                        _id = value;
                    else
                    {
                        throw new Exception("Invalid id.");
                    }
                }
            }
            public int TestNum
            {
                get => _testNum;
                set
                {
                    if (value >= 1 && value <= 9)
                        _testNum = value;
                    else
                    {
                        throw new Exception("Invalid variant.");
                    }
                }
            }

            internal string DoWork(int length)
            {
                string result = "";
                for (int i = 0; i < length; i++)
                {
                    result += TestNum.ToString();
                }
                if(result.Length>=1&&result.Length<=100)
                    return result;
                else throw new Exception("Resulting string is too large.");
            }

            public Student(long id, int testNum)
            {
                Id = id;
                TestNum = testNum;
            }
        }

        class Seminarian
        {
            private int _pointsToTen;
            private int _hatefullTestNum;
            
            public int PointsToTen
            {
                get => _pointsToTen;
                set
                {
                    if (value >= 1 && value <= 100)
                        _pointsToTen = value;
                    else
                    {
                        throw new Exception("Minimal number for 10 is invalid.");
                    }
                }
            }
            public int HatefullTestNum
            {
                get => _hatefullTestNum;
                set
                {
                    if (value >= 1 && value <= 9)
                        _hatefullTestNum = value;
                    else
                    {
                        throw new Exception("Hateful seminarian number is invalid.");
                    }
                }
            }

            internal int CheckWork(string work, Student student)
            {
                if (student.TestNum == _hatefullTestNum)
                    return 1;
                int result = work.Length / _pointsToTen * 10;
                if (result > 10) result = 10;
                if (result < 0) result = 0;
                return result;
            }

            public Seminarian(int pointsToTen, int hatefullTestNum)
            {
                PointsToTen = pointsToTen;
                HatefullTestNum = hatefullTestNum;
            }
        }

        static void Main(string[] args)
        {
            var rand = new Random();
            
            Console.Write("Enter the number of students: ");
            int n = int.Parse(Console.ReadLine());

            //We generate students with random parameters.
            var students = new Student[n];
            for (int i = 0; i < students.Length; i++)
            {
                try
                {
                    students[i] = new Student(rand.Next(-1000,2000), rand.Next(-10,20));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
                
            }
            
            //We generate seminarians with random parameters.
            var seminarians = new Seminarian[2];
            for (int i = 0; i < seminarians.Length; i++)
            {
                try
                {
                    seminarians[i] = new Seminarian(rand.Next(-100,200), rand.Next(-10,20));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
                
            }

            double results = 0;
            foreach (Student student in students)
            {
                double sum = 0;
                foreach (Seminarian seminarian in seminarians)
                {
                    sum+=seminarian.CheckWork(student.DoWork(rand.Next(1, 100)), student);
                }
                results += sum / 2;
                Console.WriteLine($"ID:{student.Id}, TestNum:{student.TestNum}, mark:{(int)sum/2}");
            }
            Console.WriteLine($"Average:{results/students.Length}");
            foreach (Seminarian seminarian in seminarians)
            {
                Console.WriteLine($"PointToTen:{seminarian.PointsToTen}, HatefulTestNum:{seminarian.HatefullTestNum}");
            }
        }
    }
}