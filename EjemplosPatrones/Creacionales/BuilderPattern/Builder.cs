namespace EjemplosPatrones.Creacionales.BuilderPattern; 
    
public interface IBuilder<Tipo>
{
    void AgregarMuros(int muros);
    void AgregarPuertas(int puertas);
    void AgregarTecho();
    void AgregarVentanas(int ventanas);
    Tipo GetResult();
}

public class Casa
{
    public int Muros { get; set; }
    public int Puertas { get; set; }
    public int Ventanas { get; set; }
    public bool Techo { get; set; }

    public Casa(int muros, int puertas, int ventanas, bool techo)
    {
        Muros = muros;
        Puertas = puertas;
        Ventanas = ventanas;
        Techo = techo;
    }
}

public class BuilderCasa : IBuilder<Casa> 
{
    public void AgregarMuros(int muros)
    {
        throw new NotImplementedException();
    }

    public void AgregarPuertas(int puertas)
    {
        throw new NotImplementedException();
    }

    public void AgregarTecho()
    {
        throw new NotImplementedException();
    }

    public void AgregarVentanas(int ventanas)
    {
        throw new NotImplementedException();
    }

    public Casa GetResult()
    {
        throw new NotImplementedException();
    }
}