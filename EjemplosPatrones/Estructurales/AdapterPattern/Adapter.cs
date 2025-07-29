namespace EjemplosPatrones.Estructurales.AdapterPattern;

public interface ISensorTemperatura
{
    double ObtenerTemperaturaCelsius();
}

public class SensorFahrenheit
{
    public double LeerTemperatura()
    {
        var random = new Random();
        double grados = 32 + (random.NextDouble() * (90-32));
        return grados;
    }
}

public class AdaptadorFahrenheit : ISensorTemperatura
{
    public SensorFahrenheit sensor = new SensorFahrenheit();

    public double ObtenerTemperaturaCelsius()
    {
        double gradosFahrenheit = sensor.LeerTemperatura();
        return (gradosFahrenheit - 32) * 5 / 9;
    }
}

public class Cliente
{
    private AdaptadorFahrenheit adaptador = new AdaptadorFahrenheit();

    public void ObtenerTemperaturaCelsius()
    {
        double f = adaptador.ObtenerTemperaturaCelsius();
        Console.WriteLine($"La temperatura en Celsius es: {f}");
    }
}

