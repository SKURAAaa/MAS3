using System;

public interface ILionKeeper
{
    void TakeCareOfLion(MaleLion lion);
    void TakeCareOfLion(FemaleLion lion);
}

public interface IEagleKeeper
{
    void TakeCareOfEagle(MaleEagle eagle);
    void TakeCareOfEagle(FemaleEagle eagle);
}

// Wielodziedziczenie przez interfejsy
public class Keeper : ILionKeeper, IEagleKeeper
{
    public string Name { get; set; }
    public int Experience { get; set; }

    public void TakeCareOfLion(MaleLion lion)
    {
        Console.WriteLine($"{Name} the lion keeper is taking special care of {lion.Name}");
    }

    public void TakeCareOfLion(FemaleLion lion)
    {
        Console.WriteLine($"{Name} the lion keeper is taking special care of {lion.Name}");
    }

    public void TakeCareOfEagle(MaleEagle eagle)
    {
        Console.WriteLine($"{Name} the eagle keeper is taking special care of {eagle.Name}");
    }

    public void TakeCareOfEagle(FemaleEagle eagle)
    {
        Console.WriteLine($"{Name} the eagle keeper is taking special care of {eagle.Name}");
    }
}