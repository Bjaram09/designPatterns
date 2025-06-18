namespace EjemplosPatrones.PracticaCreacionales.EjercicioBuilder;

public class Personaje
{
    public string Nombre { get; set; }
    public string Armadura { get; set; }
    public string Arma { get; set; }
    public List<string> Habilidades { get; set; }
    
    public override string ToString()
    {
        var partes = new List<string>();

        if (!string.IsNullOrWhiteSpace(Nombre))
            partes.Add($"Nombre: {Nombre}");
    
        if (!string.IsNullOrWhiteSpace(Armadura))
            partes.Add($"Armadura: {Armadura}");
    
        if (!string.IsNullOrWhiteSpace(Arma))
            partes.Add($"Arma: {Arma}");
    
        if (Habilidades != null && Habilidades.Any())
            partes.Add($"Habilidades: {string.Join(", ", Habilidades)}");
    
        return string.Join(" | ", partes);
    }
    
}