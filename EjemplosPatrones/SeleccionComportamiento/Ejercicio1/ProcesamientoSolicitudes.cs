namespace EjemplosPatrones.SeleccionComportamiento.Ejercicio1;

public interface IHandlerSolicitudes
{
    IHandlerSolicitudes SetNext(IHandlerSolicitudes nextHandler);
    void ProcesarSolicitud(Solicitud solicitud);
}

public abstract class HandlerSolicitudesBase : IHandlerSolicitudes
{
    private IHandlerSolicitudes _nextHandler;

    public IHandlerSolicitudes SetNext(IHandlerSolicitudes nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public virtual void ProcesarSolicitud(Solicitud solicitud)
    {
        if (_nextHandler != null)
        {
            _nextHandler.ProcesarSolicitud(solicitud);
        }
    }
}

public class Solicitud
{
    public string Tipo { get; }
    public string Detalles { get; }

    public Solicitud(string tipo, string detalles)
    {
        Tipo = tipo;
        Detalles = detalles;
    }
}

public class SoporteBasicoHandler : HandlerSolicitudesBase
{
    public override void ProcesarSolicitud(Solicitud solicitud)
    {
        if (solicitud.Tipo == "Básico")
        {
            Console.WriteLine($"Soporte Básico: Procesando solicitud de tipo '{solicitud.Tipo}' con detalles: {solicitud.Detalles}");
        }
        else
        {
            base.ProcesarSolicitud(solicitud);
        }
    }
}

public class SoporteAvanzadoHandler : HandlerSolicitudesBase
{
    public override void ProcesarSolicitud(Solicitud solicitud)
    {
        if (solicitud.Tipo == "Avanzado")
        {
            Console.WriteLine($"Soporte Avanzado: Procesando solicitud de tipo '{solicitud.Tipo}' con detalles: {solicitud.Detalles}");
        }
        else
        {
            base.ProcesarSolicitud(solicitud);
        }
    }
}

public class SupervisorHandler : HandlerSolicitudesBase
{
    public override void ProcesarSolicitud(Solicitud solicitud)
    {
        if (solicitud.Tipo is "Supervisor" or "Desconocido")
        {
            Console.WriteLine($"Supervisor: Procesando solicitud de tipo '{solicitud.Tipo}' con detalles: {solicitud.Detalles}");
        }
        else
        {
            base.ProcesarSolicitud(solicitud);
        }
    }
}

public class GestorDeSoporte
{
    private readonly IHandlerSolicitudes _cadenaSoporte;

    public GestorDeSoporte()
    {
        var soporteBasico = new SoporteBasicoHandler();
        var soporteAvanzado = new SoporteAvanzadoHandler();
        var supervisor = new SupervisorHandler();
        
        soporteBasico.SetNext(soporteAvanzado).SetNext(supervisor);
        
        _cadenaSoporte = soporteBasico;
    }

    public void Procesar(Solicitud solicitud)
    {
        _cadenaSoporte.ProcesarSolicitud(solicitud);
    }
}
