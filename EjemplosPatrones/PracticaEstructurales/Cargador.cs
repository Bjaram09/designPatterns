namespace EjemplosPatrones.PracticaEstructurales;

public interface ICharger 
{
    void Charge();
}

public class Charger : ICharger
{
    public void Charge()
    {
        Console.WriteLine("Cargando vehículo con 220V.");
    }
}

public class UsCharger
{
    public string Voltage { get; } = "110V";
    
    public void Charge110V()
    {
        Console.WriteLine($"Cargando con cargador estadounidense de {Voltage}.");
    }
}

public class UsChargerAdapter : ICharger
{
    public UsCharger usCharger = new UsCharger();
    
    public void Charge()
    {
        Console.WriteLine("Adaptador convierte 110V a 220V...");
        usCharger.Charge110V();
    }
}





