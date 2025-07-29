namespace EjemplosPatrones.SeleccionCreacionales.Ejercicio4;

public interface IBuilder<T>
{
    void AgregarMotor(int cilindraje);
    void ElegirCarroceria(string carroceria);
    void AgregarAccesorio(string accesorio);
    T GetResult();
}


public class AutosPersonalizados
{
    public int Cilindraje { get; set; }
    public string Carroceria { get; set; }
    public List<string> Accesorios { get; set; }

    public AutosPersonalizados(int cilindraje, string carroceria, List<string> accesorios)
    {
        Cilindraje = cilindraje;
        Carroceria = carroceria;
        Accesorios = new List<string>();
    }

    public override string ToString()
    {
        return $"Cilindraje: {Cilindraje}, Carrocería: {Carroceria}, Accesorios: {string.Join(", ", Accesorios)}";
    }
}

public class BuilderAutosPersonalizados : IBuilder<AutosPersonalizados>
{
    private int _cilindraje;
    private string _carroceria;
    private List<string> _accesorios = new();

    public void AgregarMotor(int cilindraje)
    {
        _cilindraje = cilindraje;
    }

    public void ElegirCarroceria(string carroceria)
    {
        _carroceria = carroceria;
    }

    public void AgregarAccesorio(string accesorio)
    {
        _accesorios.Add(accesorio);
    }

    public AutosPersonalizados GetResult()
    {
        return new AutosPersonalizados(_cilindraje, _carroceria, _accesorios);
    }
}