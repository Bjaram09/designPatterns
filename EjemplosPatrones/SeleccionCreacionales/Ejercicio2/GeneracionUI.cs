namespace EjemplosPatrones.SeleccionCreacionales.Ejercicio2;

public interface IBoton
{
    void Click();
}

public interface IVentana
{
    void Mostrar();
}

public interface IMenu
{
    void AgregarOpcion(string nombre, IBoton boton);
    void Mostrar();
}

public class Boton : IBoton
{
    private readonly string _nombre;

    public Boton(string nombre)
    {
        _nombre = nombre;
    }

    public void Click()
    {
        Console.WriteLine($"Botón '{_nombre}' ha sido presionado.");
    }
}

public class Ventana : IVentana
{
    private readonly string _titulo;

    public Ventana(string titulo)
    {
        _titulo = titulo;
    }

    public void Mostrar()
    {
        Console.WriteLine($"Ventana '{_titulo}' mostrada.");
    }
}

public class Menu : IMenu
{
    private readonly string _titulo;
    private readonly Dictionary<string, IBoton> _opciones;

    public Menu(string titulo)
    {
        _titulo = titulo;
        _opciones = new Dictionary<string, IBoton>();
    }

    public void AgregarOpcion(string nombre, IBoton boton)
    {
        _opciones[nombre] = boton;
    }

    public void Mostrar()
    {
        Console.WriteLine($"Menú: {_titulo}");
        foreach (var opcion in _opciones)
        {
            Console.WriteLine($"- {opcion.Key}");
        }
    }
}

public interface ISistemaOperativoFactory
{
    IVentana CrearVentana(string titulo);
    IMenu CrearMenu(string titulo);
    IBoton CrearBoton(string nombre);
}

public class WindowsFactory : ISistemaOperativoFactory
{
    public IVentana CrearVentana(string titulo)
    {
        return new Ventana(titulo);
    }

    public IMenu CrearMenu(string titulo)
    {
        return new Menu(titulo);
    }

    public IBoton CrearBoton(string nombre)
    {
        return new Boton(nombre);
    }
}

public class MacOsFactory : ISistemaOperativoFactory
{
    public IVentana CrearVentana(string titulo)
    {
        return new Ventana(titulo);
    }

    public IMenu CrearMenu(string titulo)
    {
        return new Menu(titulo);
    }

    public IBoton CrearBoton(string nombre)
    {
        return new Boton(nombre);
    }
}

public class LinuxFactory : ISistemaOperativoFactory
{
    public IVentana CrearVentana(string titulo)
    {
        return new Ventana(titulo);
    }

    public IMenu CrearMenu(string titulo)
    {
        return new Menu(titulo);
    }

    public IBoton CrearBoton(string nombre)
    {
        return new Boton(nombre);
    }
}

public class Client
{
    private readonly ISistemaOperativoFactory _factory;

    public Client(ISistemaOperativoFactory factory)
    {
        _factory = factory;
    }

    public void Ejecutar()
    {
        var ventana = _factory.CrearVentana("Mi Ventana");
        var menu = _factory.CrearMenu("Mi Menú");
        var boton = _factory.CrearBoton("Mi Botón");

        ventana.Mostrar();
        menu.AgregarOpcion("Opción 1", boton);
        menu.Mostrar();
        boton.Click();
    }
}