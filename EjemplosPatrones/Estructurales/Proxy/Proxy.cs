namespace EjemplosPatrones.Estructurales.Proxy;

public interface ILounge
{
    void ServiciosVIP();
}

public class SalaVIP: ILounge
{
    private List<string> _menu;
    private string _location;

    public SalaVIP()
    {
        _menu = new List<string>{ "Cafe", "Te", "Galletas", "Pintico"};
        _location = "Aeropuerto Internacional Juan Santamaría";
    }

    public void ServiciosVIP()
    {
        
    }
}

public class ProxySalaVIP : ILounge
{
    
    public void ServiciosVIP()
    {
        
    }
}

