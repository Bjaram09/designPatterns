namespace EjemplosPatrones.Creacionales.PrototypePattern;

public interface IPrototype<tipo>
{
    tipo Copy();
}

public class Arma : IPrototype<Arma>
{

    private string modeloArma;
    private float cantidadBalas;

    public Arma(string modeloArma, float cantidadBalas)
    {
        this.modeloArma = modeloArma;
        this.cantidadBalas = cantidadBalas;
    }
    
    public Arma Copy()
    {
        return new Arma(modeloArma, cantidadBalas);
    }
}