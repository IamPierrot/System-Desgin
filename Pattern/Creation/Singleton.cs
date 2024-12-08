namespace Desgin.Pattern.Creation;

public class Database
{
    private static Database? _instance;
    private readonly Dictionary<string, string> _fakeDatabase = [];
    private Database()
    {
        _instance = this;
    }

    public static Database GetInstance()
    {
        _instance ??= new Database();
        return _instance;
    }

    public string Query(string query)
    {
        return _fakeDatabase.TryGetValue(query, out var result) ? result : "Not found";
    }

    public void Save()
    {
        Console.WriteLine("Saving...");
    }

    public bool Delete(string data)
    {
        return _fakeDatabase.Remove(data);
    }
}