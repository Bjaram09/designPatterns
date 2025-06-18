namespace EjemplosPatrones.PracticaCreacionales.EjercicioBuilder;

public class PersonajeBuilder : IBuilder<Personaje>
{
    private Personaje _personaje = new Personaje();
    
    public void AgregarArmadura(string armadura)
    {
        _personaje.Armadura = armadura;
    }

    public void AgregarArma(string arma)
    {
        _personaje.Arma = arma;
    }

    public void AgregarHabilidad(string habilidad)
    {
        _personaje.Habilidades.Add(habilidad);
    }

    public void AgregarNombre(string nombre)
    {
       _personaje.Nombre = nombre;
    }

    public Personaje GetResult()
    {
        return _personaje;
    }
}