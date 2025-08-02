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
        menu.Show();
    }
}

public class SeleccionComportamientoCommand : ICommand
{
    public void Ejecutar()
    {
        var menu = new Menu();
        menu.AddTitle("Selección Comportamiento");
        menu.AddOption("Ejercicio 1 - Procesamiento de Solicitudes en Cadena", new ChainOfResponsabilityCommand());
        menu.AddOption("Ejercicio 2 - Editor de Texto con Comandos", new CommandCommand());
        menu.AddOption("Ejercicio 3 - Recorrido de productos", new IteratorCommand());
        menu.AddOption("Ejercicio 4 - Sistema de Chat", new MediatorCommand());
        menu.AddOption("Ejercicio 5 - Progreso de Jugador", new MementoCommand());
        menu.AddOption("Ejercicio 6 - Observador de Stock", new ObserverCommand());
        menu.AddOption("Ejercicio 7 - Estado de pedidos", new StateCommand());
        menu.AddOption("Ejercicio 8 - Sistema de Facturación", new StrategyCommand());
        menu.AddOption("Ejercicio 9 - Generacion de Informes", new TemplateMethodCommand());
        menu.AddOption("Ejercicio 10 - Analisis de archivos", new VisitorCommand());
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