namespace EjemplosPatrones.Comportamiento.Visitor;

public interface IDocumento
{
    void Aceptar(IDocumentVisitor visitor);
}

public interface IDocumentVisitor
{
    void Visitar(Texto texto);
    void Visitar(Imagen imagen);
    void Visitar(Tabla tabla);
}

public class Texto : IDocumento
{
    
    public string Contenido {get;}

    public Texto(string contenido)
    {
        Contenido = contenido;
    }
    
    public void Aceptar(IDocumentVisitor visitor)
    {
        visitor.Visitar(this);
    }
}

public class Imagen : IDocumento
{
    public string Url {get;}

    public Imagen(string url)
    {
        Url = url;
    }
    

    public void Aceptar(IDocumentVisitor visitor)
    {
        visitor.Visitar(this); 
    }
}

public class Tabla : IDocumento
{
    public int Filas {get;}
    public int Columnas {get;}

    public Tabla(int filas, int columna)
    {
        Filas = filas;
        Columnas = columna;
    }

    public void Aceptar(IDocumentVisitor visitor)
    {
        visitor.Visitar(this);
    }
    
}