using Desgin.Pattern.Structure;


ICake plainCake = new PlainCake();
Console.WriteLine(plainCake.Baked());

ICake chocolateDecorator = new ChocolateDecorator(new PlainCake());

Console.WriteLine(chocolateDecorator.Baked());

ICake fulltoping = new StrawberryDecorator(new ChocolateDecorator(new PlainCake()));
Console.WriteLine(fulltoping.Baked());