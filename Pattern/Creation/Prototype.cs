namespace Desgin.Pattern.Creation;

public interface ITaxi
{
    ITaxi Clone();
    void Drive();
}

// Prototype pattern
// Fake taxi like the fake of class, not using the real ones
public class FakeTaxi(string name) : ITaxi
{
    public string Name { get; set; } = name;

    public ITaxi Clone()
    {
        return new FakeTaxi(Name);
    }

    public void Drive()
    {
        Console.WriteLine($"Taxi {Name} is driving");
    }
}

// Client
public class Client
{
    public void Main()
    {
        ITaxi taxi1 = new FakeTaxi("Taxi 1");
        ITaxi taxi2 = taxi1.Clone();
        taxi1.Drive();
        taxi2.Drive();
    }
}