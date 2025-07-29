namespace EjemplosPatrones.Comportamiento.Command;

public interface ICommand
{
    void Ejecutar();
    void Deshacer();
}

public class EditorTexto
{
    public string Texto { get; private set; } = "";

    public void AgregarTexto(string texto)
    {
        Texto += texto;
    }

    public void BorrarUltimo(int cantidad)
    {
        if(Texto.Length >= cantidad)
        {
            Texto = Texto.Substring(0,Texto.Length - cantidad);
        }
    }

    public void Mostrar()
    {
        Console.WriteLine($"[Texto Actual]: {Texto}");
    }
}

public class EscribirTexto : ICommand
{
    private EditorTexto editorTexto;
    private string texto;

    public EscribirTexto(EditorTexto e, string t)
    {
        editorTexto = e;
        texto = t;
    }

    public void Ejecutar() => editorTexto.AgregarTexto(texto);
    public void Deshacer() => editorTexto.BorrarUltimo(editorTexto.Texto.Length);
}

public class HistorialComandos
{
    private Stack<ICommand> comandos = new();

    public void Ejecutar(ICommand comando)
    {
        comando.Ejecutar();
        comandos.Push(comando);
    }

    public void Deshacer()
    {
        if (comandos.Count > 0)
        {
            var ultimoComando = comandos.Pop();
            ultimoComando.Deshacer();
        }
    }
}

public class Cliente
{
    void Main()
    {
        var editor = new EditorTexto();
        var historial = new HistorialComandos();
        
        historial.Ejecutar(new EscribirTexto(editor, "Hola"));
        historial.Ejecutar(new EscribirTexto(editor, "Mundo"));
        editor.Mostrar();
    }
}