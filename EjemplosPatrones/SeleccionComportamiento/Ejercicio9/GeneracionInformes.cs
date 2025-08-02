namespace EjemplosPatrones.SeleccionComportamiento.Ejercicio9;

public abstract class GeneradorInforme
{
    public void Generar()
    {
        AbrirDocumento();
        PrepararDatos();
        GenerarContenido();
        Exportar();
    }

    protected void AbrirDocumento()
    {
        Console.WriteLine("Abriendo documento...");
    }

    protected abstract void PrepararDatos();
    protected abstract void GenerarContenido();

    protected void Exportar()
    {
        Console.WriteLine("Exportando informe como PDF...");
    }
}

public class InformeVentas : GeneradorInforme
{
    protected override void PrepararDatos()
    {
        Console.WriteLine("Preparando datos de ventas...");
    }

    protected override void GenerarContenido()
    {
        Console.WriteLine("Generando contenido del informe de ventas...");
    }
}

public class InformeInventario : GeneradorInforme
{
    protected override void PrepararDatos()
    {
        Console.WriteLine("Preparando datos de inventario...");
    }

    protected override void GenerarContenido()
    {
        Console.WriteLine("Generando contenido del informe de inventario...");
    }
}