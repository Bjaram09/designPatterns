using EjemplosPatrones.SeleccionCreacionales.Ejercicio1;
using EjemplosPatrones.SeleccionCreacionales.Ejercicio2;
using EjemplosPatrones.SeleccionCreacionales.Ejercicio3;
using EjemplosPatrones.SeleccionCreacionales.Ejercicio4;
using EjemplosPatrones.SeleccionCreacionales.Ejercicio5;

namespace EjemplosPatrones;

public class CreacionDeDocumentosCommand : ICommand
{
    public void Ejecutar()
    {
        IDocumento doc1 = DocumentoFactory.CrearDocumento(TipoDocumento.Pdf, "Informe Anual", "Contenido del informe anual", "Juan Perez", DateTime.Now);
        IDocumento doc2 = DocumentoFactory.CrearDocumento(TipoDocumento.Word, "Plan de Proyecto", "Contenido del plan de proyecto", "Ana Gomez", DateTime.Now);
        IDocumento doc3 = DocumentoFactory.CrearDocumento(TipoDocumento.Excel, "Presupuesto 2024", "Contenido del presupuesto 2024", "Luis Martinez", DateTime.Now);

        Console.WriteLine(doc1.Exportar());
        Console.WriteLine(doc2.Exportar());
        Console.WriteLine(doc3.Exportar());}
}

public class GeneracionUiCommand : ICommand
{
    public void Ejecutar()
    {
        ISistemaOperativoFactory factory;

        Console.WriteLine("Seleccione el sistema operativo (1: Windows, 2: MacOS, 3: Linux): ");
        var opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                factory = new WindowsFactory();
                break;
            case "2":
                factory = new MacOsFactory();
                break;
            case "3":
                factory = new LinuxFactory();
                break;
            default:
                Console.WriteLine("Opción no válida. Usando Windows por defecto.");
                factory = new WindowsFactory();
                break;
        }

        var client = new Client(factory);
        client.Ejecutar();
    }
}

public class PersonajesVideojuegoCommand : ICommand
{
    public void Ejecutar()
    {
        var nonPlayableCharacters = new List<PersonajeVideojuego>();
        var habilidades = new List<string> { "Fuerza", "Velocidad" };
        var personaje1 = new PersonajeVideojuego("Rubio", "Armadura de Hierro", habilidades);

        Console.WriteLine(
            $"Personaje Original: " +
            $"Color de Pelo: {personaje1.ColorPelo}, " +
            $"Armadura: {personaje1.Armadura}, " +
            $"Habilidades: {string.Join(", ", personaje1.HabilidadesEspeciales)}"
        );

        int numeroDeClones = 5;
        for (int i = 0; i < numeroDeClones; i++)
        {
            nonPlayableCharacters.Add(personaje1.Copy());
        }
        
        PersonajeVideojuego npc1 = nonPlayableCharacters[0];
        npc1.AgregarHabilidad("Sigilo");
        
        PersonajeVideojuego npc2 = nonPlayableCharacters[1];
        npc2.QuitarHabilidad("Fuerza");
        
        PersonajeVideojuego npc3 = nonPlayableCharacters[3];
        npc3.QuitarHabilidad("Fuerza");
        
        PersonajeVideojuego npc4 = nonPlayableCharacters[4];
        npc4.QuitarHabilidad("Velocidad");
        npc4.QuitarHabilidad("Fuerza");
        npc4.AgregarHabilidad("Inteligencia");
        

        Console.WriteLine("Clones:");
        foreach (var personaje in nonPlayableCharacters)
        {
            Console.WriteLine(
                $"\tNPC Copiado: " +
                $"Color de Pelo: {personaje.ColorPelo}, " +
                $"Armadura: {personaje.Armadura}, " +
                $"Habilidades: {string.Join(", ", personaje.HabilidadesEspeciales)}"
            );
        }
    }
}

public class AutosPersonalizadosCommand : ICommand
{
    public void Ejecutar()
    {
        IBuilder<AutosPersonalizados> builder = new BuilderAutosPersonalizados();
        
        builder.AgregarMotor(2000);
        builder.ElegirCarroceria("Sedán");
        builder.AgregarAccesorio("Aire acondicionado");
        builder.AgregarAccesorio("Sistema de sonido premium");
        
        AutosPersonalizados auto = builder.GetResult();
        
        Console.WriteLine(auto);
    }
}

public class RegistroUsuarioCommand : ICommand
{
    public void Ejecutar()
    {
        RegistroUsuarioUnico registro1 = RegistroUsuarioUnico.GetInstance();
        RegistroUsuarioUnico registro2 = RegistroUsuarioUnico.GetInstance();
        
        Console.WriteLine(ReferenceEquals(registro1, registro2) ? "Ambas referencias son iguales." : "Las referencias son diferentes.");
    }
}