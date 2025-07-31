namespace EjemplosPatrones.PracticaEstructurales_v2;

public class Peripheral
{
    public bool IsOn { get; set; }
    public virtual void SetUp()
    {
        Console.WriteLine("Configurando el periférico...");
        IsOn = true;
    }
    
    public virtual void ShutDown()
    {
        Console.WriteLine("Apagando el periférico...");
        IsOn = false;
    }
}
public class SoundSystem : Peripheral
{
    public override void SetUp()
    {
        Console.WriteLine("Configurando el sistema de sonido...");
        IsOn = true;
    }
}
public class ScreenSystem : Peripheral
{
    public override void SetUp()
    {
        Console.WriteLine("Configurando el sistema de pantalla...");
        IsOn = true;
    }
}
public class Projector : Peripheral
{
    public override void SetUp()
    {
        Console.WriteLine("Configurando el proyector...");
        IsOn = true;
    }
}

public class HomeTheaterFacade
{
    private readonly Peripheral _soundSystem;
    private readonly Peripheral _screenSystem;
    private readonly Peripheral _projector;

    public HomeTheaterFacade()
    {
        _soundSystem = new SoundSystem();
        _screenSystem = new ScreenSystem();
        _projector = new Projector();
    }

    public void StartMovie()
    {
        Console.WriteLine("Iniciando configuración del Home Theater...");
        _soundSystem.SetUp();
        _screenSystem.SetUp();
        _projector.SetUp();
        Console.WriteLine("Ya puedes disfrutar de tu película en el Home Theater!");
    }
    
    public void EndMovie()
    {
        Console.WriteLine("Cerrando el Home Theater...");
        _projector.ShutDown();
        _screenSystem.ShutDown();
        _soundSystem.ShutDown();
        Console.WriteLine("El Home Theater ha sido apagado.");
    }
}

public class FacadeCommand : ICommand
{
    public void Ejecutar()
    {
        var homeTheater = new HomeTheaterFacade();
        
        Console.WriteLine("=== Patrón Facade - Cine en Casa ===");
        homeTheater.StartMovie();
        
        Console.WriteLine("\nPresiona una tecla para finalizar la película...");
        Console.ReadKey();
        
        homeTheater.EndMovie();
        
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }
}