namespace EjemplosPatrones.SeleccionComportamiento.Ejercicio4;

public interface IMediator
{
    void Enviar(string mensaje, Usuario remitente);
}

public class Usuario
{
    public string Nombre { get; }
    private IMediator _mediator;

    public Usuario(string nombre, IMediator mediator)
    {
        Nombre = nombre;
        _mediator = mediator;
    }

    public void Enviar(string mensaje)
    {
        _mediator.Enviar(mensaje, this);
    }

    public void Recibir(string mensaje, Usuario remitente)
    {
        Console.WriteLine($"{Nombre} recibió de {remitente.Nombre}: {mensaje}");
    }
}

public class SistemaChat : IMediator
{
    private List<Usuario> _usuarios = new List<Usuario>();

    public void RegistrarUsuario(Usuario usuario)
    {
        _usuarios.Add(usuario);
    }

    public void Enviar(string mensaje, Usuario remitente)
    {
        foreach (var usuario in _usuarios)
        {
            if (usuario != remitente)
            {
                usuario.Recibir(mensaje, remitente);
            }
        }
    }
}