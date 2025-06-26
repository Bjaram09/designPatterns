namespace EjemplosPatrones.PracticaCreacionales_v2.EjercicioAbstractFactory;

public class ProcesadorCredito : IProcesadorPago
{
    public void ProcesarPago()
    {
        Console.WriteLine("Procesando pago con Tarjeta de Credito");
    }
}