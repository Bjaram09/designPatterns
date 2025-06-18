namespace EjemplosPatrones.PracticaCreacionales.EjercicioBuilder;

public interface IBuilder<Tipo>
{
    void AgregarArmadura(string armadura);
    void AgregarArma(string arma);
    void AgregarHabilidad(string habilidad);
    void AgregarNombre(string nombre);
    Tipo GetResult();
}