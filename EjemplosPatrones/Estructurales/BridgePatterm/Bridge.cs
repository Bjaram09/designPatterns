namespace EjemplosPatrones.Estructurales.BridgePatterm;

public interface IColor
{
    string Pintar();
}

public class Rojo : IColor
{
    public string Pintar()
    {
        return "Rojo";
    }
}

public class Azul : IColor
{
    public string Pintar()
    {
        return "Azul";
    }
}

public class Verde : IColor
{
    public string Pintar()
    {
        return "Verde";
    }
}

public abstract class FormaGeometrica
{
    protected IColor color;

    public FormaGeometrica(IColor color)
    {
        this.color = color;
    }

    public abstract void Dibujar();
}

public class Circulo : FormaGeometrica
{
    public Circulo(IColor color) : base(color) { }

    public override void Dibujar()
    {
        Console.WriteLine($"Dibujando un circulo de color {color.Pintar()}");
    }
}

public class Cuadrado : FormaGeometrica
{
    public Cuadrado(IColor color) : base(color) { }

    public override void Dibujar()
    {
        Console.WriteLine($"Dibujando un circulo de color {color.Pintar()}");
    }
}

public class Cliente
{
    public void Main()
    {
        FormaGeometrica f1 = new Circulo(new Rojo());
        FormaGeometrica f2 = new Cuadrado(new Azul());
        FormaGeometrica f3 = new Circulo(new Verde());
    }
}


