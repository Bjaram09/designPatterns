namespace EjemplosPatrones.PracticaCreacionales_v2.EjercicioAbstractFactory;

public interface IFabricaTarjetas
{
    ITarjeta CrearTarjeta();
    IProcesadorPago CrearProcesadorPago();
}
