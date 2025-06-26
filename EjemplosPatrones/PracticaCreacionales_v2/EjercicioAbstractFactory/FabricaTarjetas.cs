namespace EjemplosPatrones.PracticaCreacionales_v2.EjercicioAbstractFactory;

public class FabricaDebito : IFabricaTarjetas
{
    public ITarjeta CrearTarjeta() => new TarjetaDebito();
    
    public IProcesadorPago CrearProcesadorPago() => new ProcesadorDebito();
}

public class FabricaCredito : IFabricaTarjetas
{
    public ITarjeta CrearTarjeta() => new TarjetaCredito();
    
    public IProcesadorPago CrearProcesadorPago() => new ProcesadorCredito();
}

