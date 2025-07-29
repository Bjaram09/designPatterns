namespace EjemplosPatrones.Estructurales.Composite;

public interface IEjercito
{
    void Disparar();
}

public class Soldado : IEjercito
{
    public void Disparar()
    {
        Console.WriteLine("Chick-a-plow");
    }
}

public class Composite : IEjercito
{
    private List<IEjercito> _ejercitos = new List<IEjercito>();

    public void Agregar(IEjercito ejercito)
    {
        _ejercitos.Add(ejercito);
    }

    public void Quitar(IEjercito ejercito)
    {
        _ejercitos.Remove(ejercito);
    }

    public List<IEjercito> ObtenerEjercitos()
    {
        return _ejercitos;
    }

    public void Disparar()
    {
        Console.WriteLine("Delegar orden");
        foreach (var ejercito in _ejercitos)
        {
            ejercito.Disparar();
        }
    }
}

public class Cliente
{
    public void Ejecutar()
    {
        var soldado1 = new Soldado();
        var soldado2 = new Soldado();
        var soldado3 = new Soldado();

        var ejercito = new Composite();
        ejercito.Agregar(soldado1);
        ejercito.Agregar(soldado2);

        var escuadron = new Composite();
        escuadron.Agregar(soldado3);

        var ejercitoTotal = new Composite();
        ejercitoTotal.Agregar(ejercito);
        ejercitoTotal.Agregar(escuadron);
        
        soldado1.Disparar();
        ejercitoTotal.Disparar();
    }
}