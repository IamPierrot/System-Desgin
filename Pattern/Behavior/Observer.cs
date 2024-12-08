namespace Desgin.Pattern.Behavior;

public interface IWorker
{
    void PushSalary(long salary);
}

public class Developer : IWorker
{
    public void PushSalary(long salary)
    {
        Console.WriteLine($"Developer got salary: {salary * 0.1}");
    }
}

public class Manager : IWorker
{
    public void PushSalary(long salary)
    {
        Console.WriteLine($"Manager got salary: {salary * 1.5}");
    }
}

public class Admin
{
    private readonly List<IWorker> _workers = [];
    public void HireWorker(IWorker worker)
    {
        _workers.Add(worker);
    }

    public void PushAllSalary(long salary)
    {
        foreach (var worker in _workers)
        {
            worker.PushSalary(salary);
        }
    }
}