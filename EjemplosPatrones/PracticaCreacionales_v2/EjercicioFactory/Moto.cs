namespace EjemplosPatrones.PracticaCreacionales_v2.EjercicioFactory;

public class Moto : IVehiculo
{
    public void Conducir()
    {
        Console.WriteLine("Conduciendo una Moto (Imaginese un KTM!)");
    }
}