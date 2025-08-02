namespace EjemplosPatrones.SeleccionComportamiento.Ejercicio7;

public interface IEstadoPedido
{
    void Procesar(Pedido pedido);
    void Cancelar(Pedido pedido);
    void MostrarEstado();
}

public class Pedido
{
    public string Cliente { get; }
    public IEstadoPedido Estado { get; set; }

    public Pedido(string cliente)
    {
        Cliente = cliente;
        Estado = new EstadoPendiente();
    }

    public void Procesar() => Estado.Procesar(this);
    public void Cancelar() => Estado.Cancelar(this);
    public void MostrarEstado() => Estado.MostrarEstado();
}

public class EstadoPendiente : IEstadoPedido
{
    public void Procesar(Pedido pedido)
    {
        Console.WriteLine("Procesando pedido...");
        pedido.Estado = new EstadoEnviado();
    }

    public void Cancelar(Pedido pedido)
    {
        Console.WriteLine("Pedido cancelado.");
        pedido.Estado = new EstadoCancelado();
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Estado actual: Pendiente");
    }
}

public class EstadoEnviado : IEstadoPedido
{
    public void Procesar(Pedido pedido)
    {
        Console.WriteLine("Entregando pedido...");
        pedido.Estado = new EstadoEntregado();
    }

    public void Cancelar(Pedido pedido)
    {
        Console.WriteLine("No se puede cancelar. El pedido ya fue enviado.");
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Estado actual: Enviado");
    }
}

public class EstadoEntregado : IEstadoPedido
{
    public void Procesar(Pedido pedido)
    {
        Console.WriteLine("El pedido ya fue entregado.");
    }

    public void Cancelar(Pedido pedido)
    {
        Console.WriteLine("No se puede cancelar. El pedido ya fue entregado.");
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Estado actual: Entregado");
    }
}

public class EstadoCancelado : IEstadoPedido
{
    public void Procesar(Pedido pedido)
    {
        Console.WriteLine("El pedido fue cancelado y no puede procesarse.");
    }

    public void Cancelar(Pedido pedido)
    {
        Console.WriteLine("El pedido ya está cancelado.");
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Estado actual: Cancelado");
    }
}