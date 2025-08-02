namespace EjemplosPatrones.SeleccionComportamiento.Ejercicio3;

public interface IIterador<T>
{
    bool TieneSiguiente();
    T Siguiente();
}

public interface IRecorrido<T>
{
    IIterador<T> CrearIterador(string tipoRecorrido);
}

public class IteradorPorCampo<T> : IIterador<T>
{
    private readonly List<T> _productos;
    private int _posicion = 0;

    public IteradorPorCampo(List<T> productos, Func<T, object> criterioOrden)
    {
        _productos = productos.OrderBy(criterioOrden).ToList();
    }

    public bool TieneSiguiente() => _posicion < _productos.Count;
    public T Siguiente() => _productos[_posicion++];
}

public class RecorrerProductos : IRecorrido<Producto>
{
    private readonly List<Producto> _productos;
    private IRecorrido<Producto> _recorridoImplementation;

    public RecorrerProductos(List<Producto> productos)
    {
       _productos = productos;
    }

    public IIterador<Producto> CrearIterador(string tipoRecorrido)
    {
        return tipoRecorrido switch
        {
            "alfabetico" => new IteradorPorCampo<Producto>(_productos, p => p.Nombre),
            "precio" => new IteradorPorCampo<Producto>(_productos, p => p.Precio),
            "categoria" => new IteradorPorCampo<Producto>(_productos, p => p.Categoria),
            _ => throw new ArgumentException("Tipo de recorrido no válido")
        };
    }
}

public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string Categoria { get; set; }

    public Producto(string nombre, decimal precio, string categoria)
    {
        Nombre = nombre;
        Precio = precio;
        Categoria = categoria;
    }

    public override string ToString() => $"{Nombre} - {Precio:C} ({Categoria})";
}


