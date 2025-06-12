using EjemplosPatrones.Creacionales.SingletonPatron;

namespace EjemplosPatrones;

public class Program
{
    static void Main(string[] args)
    {
        var ejemplo = new ClienteEjemplo();
        ejemplo.EjecutarEjemplo();
    }
}