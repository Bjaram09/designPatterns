namespace EjemplosPatrones.SeleccionCreacionales.Ejercicio1;

public interface IDocumento
{
    string Titulo { get; set; }
    string Contenido { get; set; }
    string Autor { get; set; }
    DateTime FechaCreacion { get; set; }
    string Exportar();
}

public enum TipoDocumento
{
    Pdf,
    Word,
    Excel
}

public class DocumentoPdf : IDocumento
{
    public string Titulo { get; set; }
    public string Contenido { get; set; }
    public string Autor { get; set; }
    public DateTime FechaCreacion { get; set; }

    public DocumentoPdf(string titulo, string contenido, string autor, DateTime fechaCreacion)
    {
        Titulo = titulo;
        Contenido = contenido;
        Autor = autor;
        FechaCreacion = fechaCreacion;
    }

    public string Exportar()
    {
        return $"[PDF] {Titulo}\n" +
               $"Autor: {Autor} | Fecha: {FechaCreacion:dd/MM/yyyy HH:mm}\n" +
               $"Contenido: {Contenido}\n";
    }
}

public class DocumentoWord : IDocumento
{
    public string Titulo { get; set; }
    public string Contenido { get; set; }
    public string Autor { get; set; }
    public DateTime FechaCreacion { get; set; }

    public DocumentoWord(string titulo, string contenido, string autor, DateTime fechaCreacion)
    {
        Titulo = titulo;
        Contenido = contenido;
        Autor = autor;
        FechaCreacion = fechaCreacion;
        
    }

    public string Exportar()
    {
        return $"[DOCX] {Titulo}\n" +
               $"Autor: {Autor} | Fecha: {FechaCreacion:dd/MM/yyyy HH:mm}\n" +
               $"Contenido: {Contenido}\n";
    }
}

public class DocumentoExcel : IDocumento
{
    public string Titulo { get; set; }
    public string Contenido { get; set; }
    public string Autor { get; set; }
    public DateTime FechaCreacion { get; set; }

    public DocumentoExcel(string titulo, string contenido, string autor, DateTime fechaCreacion)
    {
        Titulo = titulo;
        Contenido = contenido;
        Autor = autor;
        FechaCreacion = fechaCreacion;
    }
    
    public string Exportar()
    {
        return $"[XLSX] {Titulo}\n" +
               $"Autor: {Autor} | Fecha: {FechaCreacion:dd/MM/yyyy HH:mm}\n" +
               $"Contenido: {Contenido}\n";
    }
}

public abstract class DocumentoFactory
{
    public static IDocumento CrearDocumento(TipoDocumento tipo, string titulo, string contenido, string autor, DateTime fecha)
    {
        return tipo switch
        {
            TipoDocumento.Pdf => new DocumentoPdf(titulo, contenido, autor, fecha),
            TipoDocumento.Word => new DocumentoWord(titulo, contenido, autor, fecha),
            TipoDocumento.Excel => new DocumentoExcel(titulo, contenido, autor, fecha),
            _ => throw new NotSupportedException("Tipo de documento no soportado")
        };
    }
}




