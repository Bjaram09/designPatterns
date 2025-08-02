namespace EjemplosPatrones.SeleccionComportamiento.Ejercicio10;

    public interface IVisitor
    {
        void Visitar(DocumentoTexto documento);
        void Visitar(DocumentoPDF documento);
    }

    public interface IDocumento
    {
        void Aceptar(IVisitor visitor);
    }

    public class DocumentoTexto : IDocumento
    {
        public string Contenido { get; } = "Este es un documento de texto con palabras clave como diseño y patrón.";

        public void Aceptar(IVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }

    public class DocumentoPDF : IDocumento
    {
        public string Contenido { get; } = "PDF que también tiene texto y requiere verificación ortográfica y análisis.";

        public void Aceptar(IVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }

    public class ContadorPalabras : IVisitor
    {
        public void Visitar(DocumentoTexto documento)
        {
            int cantidad = documento.Contenido.Split(' ').Length;
            Console.WriteLine($"DocumentoTexto tiene {cantidad} palabras.");
        }

        public void Visitar(DocumentoPDF documento)
        {
            int cantidad = documento.Contenido.Split(' ').Length;
            Console.WriteLine($"DocumentoPDF tiene {cantidad} palabras.");
        }
    }

    public class PalabrasClaveExtractor : IVisitor
    {
        public void Visitar(DocumentoTexto documento)
        {
            Console.WriteLine("Palabras clave encontradas en DocumentoTexto: diseño, patrón.");
        }

        public void Visitar(DocumentoPDF documento)
        {
            Console.WriteLine("Palabras clave encontradas en DocumentoPDF: texto, análisis.");
        }
    }

    public class CorrectorOrtografico : IVisitor
    {
        public void Visitar(DocumentoTexto documento)
        {
            Console.WriteLine("DocumentoTexto verificado ortográficamente: sin errores.");
        }

        public void Visitar(DocumentoPDF documento)
        {
            Console.WriteLine("DocumentoPDF verificado ortográficamente: 1 error encontrado.");
        }
    }
