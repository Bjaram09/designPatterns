namespace EjemplosPatrones.SeleccionComportamiento.Ejercicio2;

public interface IComando
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
        if (Texto.Length >= cantidad)
        {
            Texto = Texto.Substring(0, Texto.Length - cantidad);
        }
    }

    public void Mostrar()
    {
        Console.WriteLine($"[Texto Actual]: {Texto}");
    }
}

public class EscribirTexto : IComando
{
    private EditorTexto editorTexto;
    private string texto;

    public EscribirTexto(EditorTexto e, string t)
    {
        editorTexto = e;
        texto = t;
    }

    public void Ejecutar() => editorTexto.AgregarTexto(texto);
    public void Deshacer() => editorTexto.BorrarUltimo(texto.Length);
}

public class BorrarTexto : IComando
{
    private EditorTexto editorTexto;
    private int cantidad;

    public BorrarTexto(EditorTexto e, int c)
    {
        editorTexto = e;
        cantidad = c;
    }

    public void Ejecutar() => editorTexto.BorrarUltimo(cantidad);
    public void Deshacer() => editorTexto.AgregarTexto(new string(' ', cantidad));
}

public class HistorialComandos
{
    private Stack<IComando> comandos = new();
    private Stack<IComando> comandosDeshechos = new();

    public void Ejecutar(IComando comando)
    {
        comando.Ejecutar();
        comandos.Push(comando);
        comandosDeshechos.Clear();
    }

    public void Deshacer()
    {
        if (comandos.Count > 0)
        {
            IComando ultimo = comandos.Pop();
            ultimo.Deshacer();
            comandosDeshechos.Push(ultimo);
        }
    }

    public void Rehacer()
    {
        if (comandosDeshechos.Count > 0)
        {
            var comando = comandosDeshechos.Pop();
            comando.Ejecutar();
            comandos.Push(comando);
        }
    }

    public void MostrarHistorial()
    {
        Console.WriteLine("Historial de comandos:");
        foreach (var comando in comandos)
        {
            Console.WriteLine(comando.GetType().Name);
        }
    }
}


public class EdicionTextoCommand : ICommand
{
    public void Ejecutar()
    {
        EditorTexto editor = new();
        HistorialComandos historial = new();
        int opcion;

        do
        {
            Console.Clear();
            editor.Mostrar();
            Console.WriteLine("\n[Ctrl+Z: Deshacer | Ctrl+Y: Rehacer | ESC: Salir]");

            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Control))
            {
                if (keyInfo.Key == ConsoleKey.Z)
                {
                    historial.Deshacer();
                }
                else if (keyInfo.Key == ConsoleKey.Y)
                {
                    historial.Rehacer();
                }
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                break;
            }
            else
            {
                Console.Write(keyInfo.KeyChar);
                var texto = keyInfo.KeyChar.ToString();
                IComando escribir = new EscribirTexto(editor, texto);
                historial.Ejecutar(escribir);
            }

        } while (true);
    }
}