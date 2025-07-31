namespace EjemplosPatrones;

public class PracticaCreacionalesMenuCommand : ICommand
{
    public void Ejecutar()
    {
        var menu = new Menu();
        menu.AddTitle("Práctica Creacionales I");
        menu.AddOption("Ejercicio Builder", new FactoryCommand());
        menu.AddOption("Ejercicio Prototype", new PrototypeCommand());
        menu.AddOption("Ejercicio Singleton", new SingletonCommand());
        menu.AddOption("Volver al Menú Principal", new VolverMenuPrincipalCommand());
        menu.Show();
    }
}

public class PracticaCreacionalesV2MenuCommand : ICommand
{
    public void Ejecutar()
    {
        var menu = new Menu();
        menu.AddTitle("Práctica Creacionales II");
        menu.AddOption("Ejercicio Abstract Factory", new AbstractFactoryCommand());
        menu.AddOption("Ejercicio Builder", new BuilderCommand());
        menu.AddOption("Volver al Menú Principal", new VolverMenuPrincipalCommand());
        menu.Show();
    }
}
public class SeleccionCreacionalesMenuCommand : ICommand
{
    public void Ejecutar()
    {
        var menu = new Menu();
        menu.AddTitle("Selección Creacionales");
        menu.AddOption("Ejercicio 1 - Creacion de Documentos", new CreacionDeDocumentosCommand());
        menu.AddOption("Ejercicio 2 - Generación de Interfaz Gráfica", new GeneracionUiCommand());
        menu.AddOption("Ejercicio 3 - Configuración de Personajes en un Videojuego", new PersonajesVideojuegoCommand());
        menu.AddOption("Ejercicio 4 - Creación de Autos Personalizados", new AutosPersonalizadosCommand());
        menu.AddOption("Ejercicio 5 - Registro de Usuario Único", new RegistroUsuarioCommand());
        menu.AddOption("Volver al Menú Principal", new VolverMenuPrincipalCommand());
        menu.Show();
    }
}

public class PracticaEstructuralesMenuCommand : ICommand
{
    public void Ejecutar()
    {
        var menu = new Menu();
        menu.AddTitle("Práctica Estructurales");
        menu.AddOption("Adapter - Cargador", new CargadorCommand());
        menu.AddOption("Decorator - Sistema de gestion de factura", new GestionFacturaCommand());
        menu.AddOption("Bridge - Sistema de procesamiento de pagos", new PagosCommand());
        menu.AddOption("Volver al Menú Principal", new VolverMenuPrincipalCommand());
        menu.Show();
    }
}

public class PracticaEstructuralesV2MenuCommand : ICommand
{
    public void Ejecutar()
    {
        var menu = new Menu();
        menu.AddTitle("Práctica Estructurales II");
        menu.AddOption("Flyweight - Ejército de soldados", new FlyweightCommand());
        menu.AddOption("Facade - Cine de casa", new FacadeCommand());
        menu.AddOption("Proxy - Registro de acceso", new ProxyCommand());
        menu.Show();
    }
}

public class VolverMenuPrincipalCommand : ICommand
{
    public void Ejecutar()
    {
        Console.Clear();
        Console.WriteLine("Volviendo al Menú Principal...");
        Console.ReadKey();
        Program.RunMainMenu();
    }
}