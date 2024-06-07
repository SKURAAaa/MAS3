using System;
using System.Collections.Generic;

public class Zoo
{
    public string Name { get; set; }
    public List<Enclosure> Enclosures { get; set; }
    public List<Keeper> Keepers { get; set; }

    public Zoo(string name)
    {
        Name = name;
        Enclosures = new List<Enclosure>();
        Keepers = new List<Keeper>();
    }

    public void AddEnclosure(Enclosure enclosure)
    {
        Enclosures.Add(enclosure);
    }

    public void AddKeeper(Keeper keeper)
    {
        Keepers.Add(keeper);
    }

    public void AssignKeeperToAnimal(Animal animal, Keeper keeper)
    {
        keeper.Animals.Add(animal);
    }
}

// Dziedziczenie wieloaspektowe dla członków zoo

// Klasa bazowa dla członków zoo
public abstract class ZooMember
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<ZooMemberType> MemberTypes { get; set; }

    public ZooMember(string name, int age)
    {
        Name = name;
        Age = age;
        MemberTypes = new List<ZooMemberType>();
    }

    public void AddMemberType(ZooMemberType memberType)
    {
        MemberTypes.Add(memberType);
    }

    public abstract double GetIncome();
}

// Typy członków zoo
public enum ZooMemberType
{
    Employee,
    Student,
    Pensioner
}

// Klasa dla pracowników
public class Employee : ZooMember
{
    public double Salary { get; set; }

    public Employee(string name, int age, double salary) : base(name, age)
    {
        Salary = salary;
        AddMemberType(ZooMemberType.Employee);
    }

    public override double GetIncome()
    {
        return Salary;
    }

    public void Work()
    {
        Console.WriteLine($"{Name} pracuje.");
    }
}

// Klasa dla studentów
public class Student : ZooMember
{
    public double Scholarship { get; set; }

    public Student(string name, int age, double scholarship) : base(name, age)
    {
        Scholarship = scholarship;
        AddMemberType(ZooMemberType.Student);
    }

    public override double GetIncome()
    {
        return Scholarship;
    }

    public void Study()
    {
        Console.WriteLine($"{Name} studiuje.");
    }
}

// Klasa dla emerytów
public class Pensioner : ZooMember
{
    public double Pension { get; set; }

    public Pensioner(string name, int age, double pension) : base(name, age)
    {
        Pension = pension;
        AddMemberType(ZooMemberType.Pensioner);
    }

    public override double GetIncome()
    {
        return Pension;
    }

    public void Relax()
    {
        Console.WriteLine($"{Name} odpoczywa.");
    }
}

// Klasa dla członków zoo z wieloma typami (dziedziczenie overlapping)
public class WorkingStudent : ZooMember
{
    public double Salary { get; set; }
    public double Scholarship { get; set; }

    public WorkingStudent(string name, int age, double salary, double scholarship) : base(name, age)
    {
        Salary = salary;
        Scholarship = scholarship;
        AddMemberType(ZooMemberType.Employee);
        AddMemberType(ZooMemberType.Student);
    }

    public override double GetIncome()
    {
        return Salary + Scholarship;
    }

    public void Work()
    {
        Console.WriteLine($"{Name} pracuje.");
    }

    public void Study()
    {
        Console.WriteLine($"{Name} studiuje.");
    }
}
