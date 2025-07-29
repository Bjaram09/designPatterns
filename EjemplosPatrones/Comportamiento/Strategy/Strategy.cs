namespace EjemplosPatrones.Comportamiento.Strategy;

public interface IAtaque
{
    void Atacar();
}

public class AtaqueMachete : IAtaque
{
    public void Atacar()
    {
        Console.WriteLine("Atacando con un machete!");
    }
}

public class AtaqueSandalia : IAtaque 
{
    public void Atacar()
    {
        Console.WriteLine("Atacando con una sandalia!");
    }
}

public class Personaje
{
    public IAtaque EstrategiaAtaque { get; set; }
    public void EjecutarAtaque() => EstrategiaAtaque.Atacar();

    public Personaje(IAtaque estrategiaAtaque)
    {
        this.EstrategiaAtaque = estrategiaAtaque;
    }
    
}