namespace EjemplosPatrones.SeleccionComportamiento.Ejercicio8;
public interface IMetodoPago
{
    void Pagar(decimal monto);
}
public class PagoConTarjeta : IMetodoPago
{
    public void Pagar(decimal monto)
    {
        Console.WriteLine($"Pagando {monto:N2} con tarjeta de crédito...");
    }
}

public class PagoConPayPal : IMetodoPago
{
    public void Pagar(decimal monto)
    {
        Console.WriteLine($"Pagando {monto:N2} con PayPal...");
    }
}

public class PagoConCripto : IMetodoPago
{
    public void Pagar(decimal monto)
    {
        Console.WriteLine($"Pagando {monto:N2} con criptomonedas...");
    }
}
public class ProcesadorPago
{
    private IMetodoPago _metodoPago;

    public ProcesadorPago(IMetodoPago metodoPago)
    {
        _metodoPago = metodoPago;
    }

    public void CambiarMetodo(IMetodoPago nuevoMetodo)
    {
        _metodoPago = nuevoMetodo;
    }

    public void ProcesarPago(decimal monto)
    {
        _metodoPago.Pagar(monto);
    }
}