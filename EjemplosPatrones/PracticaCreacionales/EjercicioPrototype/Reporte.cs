namespace EjemplosPatrones.PracticaCreacionales.EjercicioPrototype;

public class Reporte : IPrototype<Reporte>
{
    public string Titulo { get; set; }
    public string Contenido { get; set; }
    public string Autor { get; set; }
    public DateTime FechaCreacion { get; set; }

    public Reporte(string titulo, string contenido, string autor, DateTime fechaCreacion)
    {
        Titulo = titulo;
        Contenido = contenido;
        Autor = autor;
        FechaCreacion = fechaCreacion;
    }

    public Reporte Clone()
    {
        return new Reporte(Titulo, Contenido, Autor, FechaCreacion);
    }

    public string ImprimirReporte()
    {
        return $"[REPORTE] {Titulo}\n" +
               $"Autor: {Autor} | Fecha: {FechaCreacion:dd/MM/yyyy HH:mm}\n" +
               $"Contenido: {Contenido}\n";
    }
}