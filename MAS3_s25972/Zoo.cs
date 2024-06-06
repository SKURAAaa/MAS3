using System;
using System.Collections.Generic;

public class Zoo
{
    public string Name { get; set; }
    public List<Enclosure> Enclosures { get; set; }

    public Zoo(string name)
    {
        Name = name;
        Enclosures = new List<Enclosure>();
    }

    public void AddEnclosure(Enclosure enclosure)
    {
        Enclosures.Add(enclosure);
    }

    // Dynamiczne przypisanie opiekuna (Dziedziczenie dynamiczne)
    public void AssignKeeperToAnimal(Animal animal, Keeper keeper)
    {
        if (animal is MaleLion maleLion)
        {
            keeper.TakeCareOfLion(maleLion);
        }
        else if (animal is FemaleLion femaleLion)
        {
            keeper.TakeCareOfLion(femaleLion);
        }
        else if (animal is MaleEagle maleEagle)
        {
            keeper.TakeCareOfEagle(maleEagle);
        }
        else if (animal is FemaleEagle femaleEagle)
        {
            keeper.TakeCareOfEagle(femaleEagle);
        }
    }
}