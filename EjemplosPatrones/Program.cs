using EjemplosPatrones.PracticaCreacionales_v2.EjercicioAbstractFactory;
using EjemplosPatrones.PracticaCreacionales_v2.EjercicioFactory;
using EjemplosPatrones.PracticaCreacionales.EjercicioBuilder;
using EjemplosPatrones.PracticaCreacionales.EjercicioPrototype;
using EjemplosPatrones.PracticaCreacionales.EjercicioSingleton;

namespace EjemplosPatrones;

public class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("==== MENÚ DE PATRONES DE DISEÑO ====");
            Console.WriteLine("1. Singleton");
            Console.WriteLine("2. Prototype");
            Console.WriteLine("3. Builder");
            Console.WriteLine("4. Factory");
            Console.WriteLine("5. Abstract Factory");
            Console.WriteLine("6. Salir");
            Console.Write("Selecciona una opción (1-6): ");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingresa un número.");
                Console.ReadKey();
                continue;
            }

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("----- SINGLETON -----");
                    EjecutarEjercicioSingleton();
                    break;
                case 2:
                    Console.WriteLine("----- PROTOTYPE -----");
                    EjecutarEjercicioPrototype();
                    break;
                case 3:
                    Console.WriteLine("----- BUILDER -----");
                    EjecutarEjercicioBuilder();
                    break;
                case 4:
                    Console.WriteLine("----- FACTORY -----");
                    EjecutarEjercicioFactory();
                    break;
                case 5:
                    Console.WriteLine("----- ABSTRACT FACTORY -----");
                    EjecutarEjercicioAbstractFactory();
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

            if (opcion != 6)
            {
                Console.WriteLine("\nPresiona una tecla para volver al menú...");
                Console.ReadKey();
            }

        } while (opcion != 6);
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

    static void EjecutarEjercicioFactory()
    {
        FabricaVehiculo factoryAuto = new FabricaAuto();
        FabricaVehiculo factoryMoto = new FabricaMoto();
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("----- FACTORY -----");
            Console.WriteLine("Seleccione el tipo de vehiculo:");
            Console.WriteLine("1. Auto");
            Console.WriteLine("2. Moto");
            Console.WriteLine("3. Salir");
            Console.Write("Selecciona una opción (1-3): ");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                Console.ReadKey();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Creando un Auto...");
                    IVehiculo auto = factoryAuto.CrearVehiculo();
                    auto.Conducir();
                    break;
                case 2:
                    Console.WriteLine("Creando una Moto...");
                    IVehiculo moto = factoryMoto.CrearVehiculo();
                    moto.Conducir();
                    break;
                case 3:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (opcion != 3)
            {
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 3);
    }

    static void EjecutarEjercicioAbstractFactory()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("----- ABSTRACT FACTORY -----");
            Console.WriteLine("Seleccione el tipo de tarjeta:");
            Console.WriteLine("1. Credito");
            Console.WriteLine("2. Debito");
            Console.WriteLine("3. Salir");
            Console.Write("Selecciona una opción (1-3): ");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                Console.ReadKey();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    EjecutarFlujoTarjeta(new FabricaCredito());
                    break;
                case 2:
                    EjecutarFlujoTarjeta(new FabricaDebito());
                    break;
                case 3:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (opcion != 3)
            {
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 3);
    }
    
    static void EjecutarFlujoTarjeta(IFabricaTarjetas fabrica)
    {
        ITarjeta tarjeta = fabrica.CrearTarjeta();
        tarjeta.ObtenerTipo();

        IProcesadorPago procesador = fabrica.CrearProcesadorPago();
        procesador.ProcesarPago();
    }

}