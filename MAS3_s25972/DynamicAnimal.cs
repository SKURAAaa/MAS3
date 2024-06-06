using System;

public interface IEmployee
{
    void Work();
}

public interface IStudent
{
    void Study();
}

// Overlapping (dziedziczenie łączne)
public class WorkingStudent : IEmployee, IStudent
{
    public void Work()
    {
        Console.WriteLine("Working");
    }

    public void Study()
    {
        Console.WriteLine("Studying");
    }
}

// Dziedziczenie dynamiczne
public abstract class DynamicAnimal : Animal
{
    protected DynamicAnimal(string name, int age) : base(name, age) { }

    // Możliwość zmiany typu w trakcie działania
    public abstract void ChangeType();
}

public class DynamicLion : DynamicAnimal
{
    public DynamicLion(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Dynamic Roar");
    }

    public override void ChangeType()
    {
        Console.WriteLine("Changing type from Lion to another animal");
    }
}