namespace EjemplosPatrones;

public class Program
{
    public static void Main(string[] args)
    {
        RunMainMenu();
    }

    public static void RunMainMenu()
    {
        var mainMenu = new Menu();
        mainMenu.AddTitle("Practicas - Patrones de Diseño");
        mainMenu.AddOption("Practica Creacionales", new PracticaCreacionalesMenuCommand());
        mainMenu.AddOption("Practica Creacionales II", new PracticaCreacionalesV2MenuCommand());
        mainMenu.AddOption("Practica Estructurales", new PracticaEstructuralesMenuCommand());
        mainMenu.AddOption("Practica Estructurales II", new PracticaEstructuralesV2MenuCommand());
        mainMenu.AddOption("Seleccion Creacionales", new SeleccionCreacionalesMenuCommand());
        mainMenu.AddOption("Seleccion Comportamiento", new SeleccionComportamientoCommand());
        mainMenu.Show();
    }
}