namespace EjemplosPatrones.Comportamiento.ChainOfResponsability;

public interface IHandler
{
    IHandler SetNext(IHandler nextHandler);
    object ProcessRequest(object request);
}

public abstract class BaseHandler : IHandler
{
    protected IHandler nextHandler;

    public IHandler SetNext(IHandler nextHandler)
    {
        //Le asignamos un nuevo handler al nextHandler pero retornamos el que ahora es el actual handler. 
        this.nextHandler = nextHandler;
        return nextHandler;
    }
    
    public abstract object ProcessRequest(object request);
}