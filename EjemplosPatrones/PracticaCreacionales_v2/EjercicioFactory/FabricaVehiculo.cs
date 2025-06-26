namespace EjemplosPatrones.PracticaCreacionales_v2.EjercicioFactory;

public abstract class FabricaVehiculo
{
    public abstract IVehiculo CrearVehiculo();
}

public class FabricaAuto : FabricaVehiculo
{
    public override IVehiculo CrearVehiculo()
    {
        return new Auto();
    }
}

public class FabricaMoto : FabricaVehiculo
{
    public override IVehiculo CrearVehiculo()
    {
        return new Moto();
    }
}

