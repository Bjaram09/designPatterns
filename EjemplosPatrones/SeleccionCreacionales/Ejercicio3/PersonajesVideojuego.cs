namespace EjemplosPatrones.SeleccionCreacionales.Ejercicio3;

public interface IPrototype<T>
{
    T Copy();
}

public class PersonajeVideojuego : IPrototype<PersonajeVideojuego>
{
    public string ColorPelo { get; }
    public string Armadura { get; }
    
    public List<string> HabilidadesEspeciales;

    public PersonajeVideojuego(string colorPelo, string armadura, List<string> habilidadesEspeciales)
    {
        ColorPelo = colorPelo;
        Armadura = armadura;
        HabilidadesEspeciales = new List<string>(habilidadesEspeciales);
    }

    public PersonajeVideojuego Copy()
    {
        return new PersonajeVideojuego(ColorPelo, Armadura, HabilidadesEspeciales);
    }

    public void AgregarHabilidad(string habilidad)
    {
        if (!HabilidadesEspeciales.Contains(habilidad))
        {
            HabilidadesEspeciales.Add(habilidad);
        }
        else
        {
            Console.WriteLine($"La habilidad '{habilidad}' ya existe en el personaje.");
        }
        
    }

    public bool QuitarHabilidad(string habilidad)
    {
        return HabilidadesEspeciales.Remove(habilidad);
    }
}