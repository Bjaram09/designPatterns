namespace EjemplosPatrones.Comportamiento.State;

public interface IEstadoEnemigo
{
    //Esta interfaz debe tener todas o casi todas 
    //las variables que puede tener un objeto

    void DetectarJugador();
    void RecibirDamage(int damage);
    void Actualizar();
}

public class Enemigo
{
    public IEstadoEnemigo Estado { get; set; }
    public int Salud { get; set; }

    public Enemigo()
    {
        Estado = new EstadoPatrullando(this);
    }

    public void Actualizar()
    {
        Estado.Actualizar();
    }

    public void DetectarJugador()
    {
        Estado.DetectarJugador();
    }

    public void RecibirDamage(int damage)
    {
        Estado.RecibirDamage(damage);
    }
}

public class EstadoPatrullando : IEstadoEnemigo
{
    private Enemigo _enemigo;

    public EstadoPatrullando(Enemigo enemigo)
    {
        this._enemigo = enemigo;
    }

    public void DetectarJugador()
    {
        _enemigo.Estado = new EstadoAlerta(_enemigo);
    }

    public void RecibirDamage(int damage)
    {
        _enemigo.Salud -= damage;
        Console.WriteLine($"Recibiendo daño: {damage}. Salud actual: {_enemigo.Salud}");

        if (_enemigo.Salud <= 0)
        {
            _enemigo.Estado = new EstadoMuerto(_enemigo);
        }
    }

    public void Actualizar()
    {
        Console.WriteLine("Enemigo patrullando...");
    }
}

public class EstadoAlerta : IEstadoEnemigo
{
    private Enemigo _enemigo;

    public EstadoAlerta(Enemigo enemigo)
    {
        this._enemigo = enemigo;
    }

    public void DetectarJugador()
    {
        Console.WriteLine("Jugador confirmado, seguirlo!");
    }

    public void RecibirDamage(int damage)
    {
        _enemigo.Salud -= damage;
        Console.WriteLine($"Recibiendo daño: {damage}. Salud actual: {_enemigo.Salud}");

        if (_enemigo.Salud <= 0)
        {
            _enemigo.Estado = new EstadoMuerto(_enemigo);
        }
    }
    
    public void Actualizar()
    {
        Console.WriteLine("Enemigo alerta...");
    }
}

public class EstadoMuerto : IEstadoEnemigo
{
    private Enemigo _enemigo;

    public EstadoMuerto(Enemigo enemigo)
    {
        this._enemigo = enemigo;
    }

    public void DetectarJugador()
    {
        Console.WriteLine("No puede detectar al jugador, está muerto.");
    }

    public void RecibirDamage(int damage)
    {
        Console.WriteLine($"Enemigo ya está muerto, no puede recibir más daño.");
    }
    
    public void Actualizar()
    {
        Console.WriteLine("Enemigo muerto...");
    }
}