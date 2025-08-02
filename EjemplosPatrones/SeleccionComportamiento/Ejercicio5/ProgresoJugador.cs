namespace EjemplosPatrones.SeleccionComportamiento.Ejercicio5;
public class MementoJugador
{
    public string Nombre { get; }
    public int Puntos { get; }

    public MementoJugador(string nombre, int puntos)
    {
        Nombre = nombre;
        Puntos = puntos;
    }
}

public class Jugador
{
    public string Nombre { get; private set; }
    public int Puntos { get; private set; }

    public Jugador(string nombre)
    {
        Nombre = nombre;
        Puntos = 0;
    }

    public void Jugar()
    {
        Puntos += 10;
        Console.WriteLine($"{Nombre} juega. Puntos actuales: {Puntos}");
    }

    public MementoJugador Guardar()
    {
        Console.WriteLine("Guardando progreso...");
        return new MementoJugador(Nombre, Puntos);
    }

    public void Restaurar(MementoJugador memento)
    {
        Nombre = memento.Nombre;
        Puntos = memento.Puntos;
        Console.WriteLine("Progreso restaurado.");
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"Jugador: {Nombre}, Puntos: {Puntos}");
    }
}

public class GestorGuardado
{
    private Stack<MementoJugador> _historial = new();

    public void GuardarEstado(MementoJugador memento)
    {
        _historial.Push(memento);
    }

    public MementoJugador RecuperarUltimoEstado()
    {
        return _historial.Count > 0 ? _historial.Pop() : null;
    }
}



