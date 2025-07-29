using System.Data;

namespace EjemplosPatrones.Comportamiento.Memento;

public class Editor
{
    private string _contenido = "";

    public void Escribir(string contenido)
    {
        _contenido = contenido;
    }

    public string Leer()
    {
        return _contenido;
    }
    
    public void Restaurar(Memento memento)
    {
        _contenido = memento.ObtenerEstado();
    }
    
}

public class Memento
{
    private readonly string estado;

    public Memento(string estado)
    {
        this.estado = estado;
    }

    public string ObtenerEstado()
    {
        return estado;
    }
}

public class Historial
{
    private Stack<Memento> _historial = new Stack<Memento>();

    public void GuardarMemento(Memento memento)
    {
        _historial.Push(memento);
    }
    
    public Memento Deshacer()
    {
        if (_historial.Count == 0)
        {
            return null;
        }

        return _historial.Pop();
    }
}