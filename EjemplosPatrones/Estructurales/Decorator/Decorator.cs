namespace EjemplosPatrones.Estructurales.Decorator;

public class ImpresoraVieja
{
    public string Imprimir(string texto)
    {
        return $"Impriendo: {texto}";
    }
}

public interface IImpresora
{
    string Imprimir (string texto);
}

public class DecoradorImpresora : IImpresora
{
    private ImpresoraVieja impresora;

    public DecoradorImpresora(ImpresoraVieja impresora)
    {
        this.impresora = impresora;
    }

    public string Imprimir(string texto)
    {
        return impresora.Imprimir(texto);
    }
}

public class ImpresoraColor : IImpresora
{
   private IImpresora impresora;

   public ImpresoraColor(IImpresora impresora)
   {
       this.impresora = impresora;
   }

   public string Imprimir(string texto)
   {
       Console.ForegroundColor = ConsoleColor.Green;
       Console.WriteLine(impresora.Imprimir(texto));
       return $"Imprimir: {texto}";
   }
}