namespace Desgin.Pattern.Structure;

interface ITaxi
{
    void Drive();
}

class RealTaxi
{
    public void Drive()
    {
        Console.WriteLine("Get in the car");
    }
}

class FakeTaxi
{
    public void Drive()
    {
        Console.WriteLine("Gimme ur ass");
    }
}

class TaxiAdapter : ITaxi
{
    private readonly FakeTaxi fakeTaxi = new();
    public void Drive()
    {
        fakeTaxi.Drive();
    }
}