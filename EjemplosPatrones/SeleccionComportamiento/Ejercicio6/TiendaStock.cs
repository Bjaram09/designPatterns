namespace EjemplosPatrones.SeleccionComportamiento.Ejercicio6;

public interface IObservador
{
    void Actualizar(ProductoObservado producto);
}

public interface ISujeto
{
    void Suscribir(IObservador observador);
    void Desuscribir(IObservador observador);
    void Notificar();
}
public class ProductoObservado : ISujeto
{
    private readonly List<IObservador> _observadores = new();

    public string Nombre { get; }
    private int _stock;
    public int Stock
    {
        get => _stock;
        set
        {
            _stock = value;
            Notificar();
        }
    }

    public ProductoObservado(string nombre, int stockInicial)
    {
        Nombre = nombre;
        _stock = stockInicial;
    }

    public void Suscribir(IObservador observador) => _observadores.Add(observador);
    public void Desuscribir(IObservador observador) => _observadores.Remove(observador);
    public void Notificar()
    {
        foreach (var o in _observadores)
        {
            o.Actualizar(this);
        }
    }
}

public class ModuloFacturacion : IObservador
{
    public void Actualizar(ProductoObservado producto)
    {
        Console.WriteLine($"[Facturación] Se actualizó el stock de {producto.Nombre} a {producto.Stock}");
    }
}

public class ModuloEstadisticas : IObservador
{
    public void Actualizar(ProductoObservado producto)
    {
        Console.WriteLine($"[Estadísticas] Registrando cambio de inventario de {producto.Nombre}...");
    }
}

public class ModuloNotificacionesClientes : IObservador
{
    public void Actualizar(ProductoObservado producto)
    {
        if (producto.Stock > 0)
            Console.WriteLine($"[Notificación] ¡{producto.Nombre} está disponible de nuevo!");
    }
}

