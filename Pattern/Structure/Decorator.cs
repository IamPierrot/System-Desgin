namespace Desgin.Pattern.Structure;

public interface ICake
{
    string Baked();
}

public class PlainCake : ICake
{
    public string Baked()
    {
        return "Cake";
    }
}

public abstract class CakeDecorator(ICake decoratedCake) : ICake
{
    protected ICake _cakeDecorator = decoratedCake;

    // virtual = abstract with base body
    public virtual string Baked()
    {
        return _cakeDecorator.Baked(); 
    }
}

public class ChocolateDecorator(ICake decoratedCake) : CakeDecorator(decoratedCake)
{
    public override string Baked()
    {
        return _cakeDecorator.Baked() + " with chocolate";
    }
}

public class StrawberryDecorator(ICake decoratedCake) : CakeDecorator(decoratedCake)
{
    public override string Baked()
    {
        return _cakeDecorator.Baked() + " with strawberry";
    }
}