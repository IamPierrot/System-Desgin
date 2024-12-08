namespace Desgin.Pattern.Creation;

public interface IAnimal
{
    public void Speak();
}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("goof!");
    }
}

class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("meow!");
    }
}

public class Factory
{
    public static IAnimal CreateAnimal(string animal) => animal switch
    {
        "dog" => new Dog(),
        "cat" => new Cat(),
        _ => throw new ArgumentException("Invalid animal type", nameof(animal))
    };
}