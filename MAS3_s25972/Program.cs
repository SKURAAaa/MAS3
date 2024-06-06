using System;

public class Program
{
    public static void Main(string[] args)
    {
        Zoo zoo = new Zoo("City Zoo");

        Enclosure lionEnclosure = new Enclosure("Lion Enclosure");
        Enclosure eagleEnclosure = new Enclosure("Eagle Enclosure");

        MaleLion maleLion = new MaleLion("Leo", 5);
        FemaleLion femaleLion = new FemaleLion("Leona", 4);
        MaleEagle maleEagle = new MaleEagle("Eddie", 3);
        FemaleEagle femaleEagle = new FemaleEagle("Edna", 2);

        lionEnclosure.AddAnimal(maleLion);
        lionEnclosure.AddAnimal(femaleLion);
        eagleEnclosure.AddAnimal(maleEagle);
        eagleEnclosure.AddAnimal(femaleEagle);

        zoo.AddEnclosure(lionEnclosure);
        zoo.AddEnclosure(eagleEnclosure);

        Keeper john = new Keeper { Name = "John", Experience = 10 };

        zoo.AssignKeeperToAnimal(maleLion, john);
        zoo.AssignKeeperToAnimal(femaleLion, john);
        zoo.AssignKeeperToAnimal(maleEagle, john);
        zoo.AssignKeeperToAnimal(femaleEagle, john);

        // Overlapping and dynamic inheritance examples
        WorkingStudent workingStudent = new WorkingStudent();
        workingStudent.Work();
        workingStudent.Study();

        DynamicLion dynamicLion = new DynamicLion("Dynamic Leo", 4);
        dynamicLion.MakeSound();
        dynamicLion.ChangeType();
    }
}