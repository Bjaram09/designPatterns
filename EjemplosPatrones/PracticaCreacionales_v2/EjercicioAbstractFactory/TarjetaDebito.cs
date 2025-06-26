namespace EjemplosPatrones.PracticaCreacionales_v2.EjercicioAbstractFactory;

public class TarjetaDebito : ITarjeta
{
    public void ObtenerTipo()
    {
        Console.WriteLine("Se ha creado una Tarjeta de Debito");
    }
}