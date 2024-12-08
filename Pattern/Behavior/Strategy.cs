namespace Desgin.Pattern.Behavior;

interface ILove
{
    void MakeLove();
}

class Love : ILove
{
    public void MakeLove()
    {
        Console.WriteLine("I love you!");
    }
}

class FakeLove : ILove
{
    public void MakeLove()
    {
        Console.WriteLine("I love your money!");
    }

}

class LoveStrategy
{
    private ILove _love = new Love();

    public void SetLove(ILove love)
    {
        _love = love;
    }

    public void MakeLove()
    {
        _love.MakeLove();
    }
}