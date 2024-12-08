namespace Desgin.Pattern.Creation;

interface ICarOption
{
    string Name { get; }
    string Description { get; }
    CarType Type { get; }
}

enum CarType
{
    BasicCar,
    SuperCar,
    FakeTaxi
}

class CarBuilder
{
    private string name = string.Empty;
    private string description = string.Empty;
    private CarType type;

    private CarBuilder(ICarOption builderOption)
    {
        name = builderOption.Name;
        description = builderOption.Description;
        type = builderOption.Type;
    }

    private CarBuilder() { }

    public static CarBuilder Create(ICarOption? builderOption)
    {
        if (builderOption != null)
        {
            return new CarBuilder(builderOption);
        }
        return new CarBuilder();
    }

    public CarBuilder WithName(string name)
    {
        this.name = name;
        return this;
    }
    public CarBuilder WithDescription(string description)
    {
        this.description = description;
        return this;
    }
    public CarBuilder WithType(CarType type)
    {
        this.type = type;
        return this;
    }

    public string Build()
    {
        return $"Name: {name}, Description: {description}, Type: {type}";
    }

}