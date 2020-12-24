using System;
 
/*
 Реализовать класс, представляющий сведения о человеке Person.
Реализовать свойства: Ф.И.О.(string FullName), дата рождения (DateTime BirthDate),
пол (bool IsMale). Реализовать метод для вывода информации о человеке void ShowInfo().
Реализовать класс, представляющий сведения о студенте Student (наследуется от Person).
Реализовать свойства: название ВУЗа (string Institute), специальность (string Speciality).
Реализовать класс, представляющий сведения о сотруднике фирмы Employee (наследуется от Person). Реализовать свойства: название компании (string CompanyName), должность (string Post), график (string Schedule), оклад (decimal Salary).
 
В основной программе решить задачи:
- Создать  объекты всех трех типов и вызвать ShowInfo(), чтобы показать всю доступную информацию.
- Создать массив Person[] arr и присвоить его членам объекты всех трех типов. Продемонстрировать работу метода ShowInfo() на массиве. 
 
 */
 
class Person
{
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsMale { get; set; }
 
    public Person(string f, DateTime d, bool i)
    {
        FullName = f;
        BirthDate = d;
        IsMale = i;
    }
 
    public virtual void ShowInfo()
    {
        Console.WriteLine($"{FullName} {BirthDate} {IsMale}");
    }
}
 
class Student : Person
{
    public string Institute { get; set; }
    public string Speciality { get; set; }
 
    public Student(string f, DateTime d, bool i, string inst, string spec) : base(f, d, i)
    {
        Institute = inst;
        Speciality = spec;
    }
 
    public override void ShowInfo()
    {
        Console.WriteLine($"{FullName} {BirthDate} {IsMale} {Institute} {Speciality}");
    }
}

class Employee : Person
{
    public string CompanyName { get; set; }
    public string Post { get; set; }
    public string Schedule { get; set; }
    public decimal Salary { get; set; }
    
    public Employee( string f, DateTime d, bool i, string companyName, string post, string schedule, decimal salary) : base(f,d,i)
    {
        CompanyName = companyName;
        Post = post;
        Schedule = companyName;
        Salary = salary;
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"{FullName} {BirthDate} {IsMale} {CompanyName} {Post} {Salary}");
    }
    
}
 
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("r34t43", new DateTime(2020, 10, 10), true);
        Student student = new Student("r34t43", new DateTime(2020, 10, 10), true, 
            "FEWF", "vrere");
        Employee employee = new Employee("r34t43", new DateTime(2020, 10, 10), true, 
            "Dell", "CEO", "8 to 6", 100000);
        person.ShowInfo();
        student.ShowInfo();
        employee.ShowInfo();
    }
}
 