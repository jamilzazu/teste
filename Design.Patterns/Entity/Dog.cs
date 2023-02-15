using Design.Patterns.Interface;

namespace Design.Patterns.Entity;

public class Dog : IAnimal
{
    public string MakeSound()
    {
        return "auau";
    }
}

public class DogFood : IFood
{
    public string Name => "dog food";
}