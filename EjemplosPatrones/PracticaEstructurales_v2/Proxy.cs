namespace EjemplosPatrones.PracticaEstructurales_v2;

public interface IDatabase
{
    void Connect();
}

public class RealDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Conectado a la base de datos real!");
    }
}

public class DatabaseProxy : IDatabase
{
    private RealDatabase _realDatabase;
    
    public DatabaseProxy(RealDatabase service)
    {
        _realDatabase = service;
    }

    public void Connect()
    {
        Console.WriteLine("Intentando conectar a la base de datos a través del proxy...");
        
        if (_realDatabase == null)
        {
            _realDatabase = new RealDatabase();
        }

        Console.WriteLine("Conectando a la base de datos a través del proxy...");
        
        _realDatabase.Connect();
    }
}