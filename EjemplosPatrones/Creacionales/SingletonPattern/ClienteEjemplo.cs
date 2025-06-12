namespace EjemplosPatrones.Creacionales.SingletonPatron;

public class ClienteEjemplo
{
    public void EjecutarEjemplo()
    {
        var singleton = Singleton.GetInstance();
        singleton.Nombre = "Bryan";
        singleton.Edad = 21;
        
        Console.WriteLine(singleton.Nombre);
        Console.WriteLine(singleton.Edad);
        
        var singleton2 = Singleton.GetInstance();
        singleton2.Nombre = "Luis";
        
        Console.WriteLine(singleton.Nombre); //Luis
    }
}