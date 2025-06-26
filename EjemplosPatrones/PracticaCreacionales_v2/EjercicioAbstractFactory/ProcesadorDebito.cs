namespace EjemplosPatrones.PracticaCreacionales_v2.EjercicioAbstractFactory;

public class ProcesadorDebito : IProcesadorPago
{
    public void ProcesarPago()
    {
        Console.WriteLine("Procesando pago con Tarjeta de Debito");
    }
}