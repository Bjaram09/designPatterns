using EjemplosPatrones.PracticaCreacionales.EjercicioBuilder;
using EjemplosPatrones.PracticaCreacionales.EjercicioPrototype;
using EjemplosPatrones.PracticaCreacionales.EjercicioSingleton;

namespace EjemplosPatrones;

public class Program
{
    static void Main(string[] args)
    {
        //Ejercicio Singleton
        Console.WriteLine("-----SINGLETON-----");
        EjecutarEjercicioSingleton();
        
        //Ejercicio Prototype
        Console.WriteLine("-----PROTOTYPE-----");
        EjecutarEjercicioPrototype();
        
        //Ejercicio Builder
        Console.WriteLine("-----BUILDER-----");
        EjecutarEjercicioBuilder();
        
    }

    static void EjecutarEjercicioSingleton()
    {
        var config = ConfigManager.GetInstance();
        config.ApplicationName = "Denarius";
        config.Version = "1.0.0";
        
        Console.WriteLine($"De mi primera instancia tengo la aplicacion {config.ApplicationName} con version {config.Version}");
        
        var config2 = ConfigManager.GetInstance();
        Console.WriteLine($"De mi segunda instancia tengo la aplicacion {config2.ApplicationName} con version {config2.Version}\n");
    }

    static void EjecutarEjercicioPrototype()
    {
        Reporte reporteBase = new Reporte("Formula secreta del Cangre-burger", "Ni en sus mas profundos sueños, va a saber la formula secreta...", "Bob Esponja", DateTime.Now );
        Reporte reporteCopia = reporteBase.Clone();
        reporteCopia.Autor = "Plancton";
        reporteCopia.Contenido = "Esta vacio!";
        
        Console.WriteLine(reporteBase.ImprimirReporte());
        Console.WriteLine(reporteCopia.ImprimirReporte());
    }

    static void EjecutarEjercicioBuilder()
    {
        IBuilder<Personaje> builder = new PersonajeBuilder();
        
        builder.AgregarNombre("Steve");
        builder.AgregarArma("Espada");
        builder.AgregarArmadura("Diamante");

        Personaje personajeConstruido = builder.GetResult();
        Console.WriteLine(personajeConstruido.ToString());
    }
}