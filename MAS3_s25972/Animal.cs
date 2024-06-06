using System;

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();
}

// Aspekt płci (Wieloaspektowe dziedziczenie)
public abstract class MaleAnimal : Animal
{
    protected MaleAnimal(string name, int age) : base(name, age) { }

    public abstract void DisplayGender();
}

public abstract class FemaleAnimal : Animal
{
    protected FemaleAnimal(string name, int age) : base(name, age) { }

    public abstract void DisplayGender();
}

public class MaleLion : MaleAnimal
{
    public MaleLion(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Roar");
    }

    public override void DisplayGender()
    {
        Console.WriteLine($"{Name} is a male lion.");
    }
}

public class FemaleLion : FemaleAnimal
{
    public FemaleLion(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Roar");
    }

    public override void DisplayGender()
    {
        Console.WriteLine($"{Name} is a female lion.");
    }
}

public class MaleEagle : MaleAnimal
{
    public MaleEagle(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Screech");
    }

    public override void DisplayGender()
    {
        Console.WriteLine($"{Name} is a male eagle.");
    }
}

public class FemaleEagle : FemaleAnimal
{
    public FemaleEagle(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Screech");
    }

    public override void DisplayGender()
    {
        Console.WriteLine($"{Name} is a female eagle.");
    }
}