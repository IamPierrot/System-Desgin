namespace Desgin.Pattern.Behavior;

public interface IGirlState
{
    void SayHi();
    void SayGoodbye();
}

class NormalState : IGirlState
{
    public void SayHi()
    {
        Console.WriteLine("Hi!");
    }

    public void SayGoodbye()
    {
        Console.WriteLine("Goodbye!");
    }
}

class HappyState : IGirlState
{
    public void SayHi()
    {
        Console.WriteLine("Hi, friend!");
    }

    public void SayGoodbye()
    {
        Console.WriteLine("Goodbye, friend!");
    }
}

class AngryState : IGirlState
{
    public void SayHi()
    {
        Console.WriteLine("Hi, stranger!");
    }

    public void SayGoodbye()
    {
        Console.WriteLine("Goodbye, stranger!");
    }
}

public class Girl
{
    private IGirlState _state = new NormalState();

    public void SetState(IGirlState state)
    {
        _state = state;
    }

    public void SayHi()
    {
        _state.SayHi();
    }

    public void SayGoodbye()
    {
        _state.SayGoodbye();
    }
}