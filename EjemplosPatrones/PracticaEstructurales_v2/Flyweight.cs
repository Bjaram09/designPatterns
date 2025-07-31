namespace EjemplosPatrones.PracticaEstructurales_v2;

public class SoldierType
{
    public string Nombre { get; private set; }
    public string Arma { get; private set; }
    
    public SoldierType(string nombre, string arma)
    {
        Nombre = nombre;
        Arma = arma;
    }
}

public class Soldier
{
    private SoldierType Tipo { get; }
    private int Vida { get; set; }
    private int PosicionX { get; set; }
    private int PosicionY { get; set; }

    public Soldier(SoldierType tipo, int vida, int posicionX, int posicionY)
    {
        Tipo = tipo;
        Vida = vida;
        PosicionX = posicionX;
        PosicionY = posicionY;
    }

    public void Display()
    {
        Console.WriteLine($"Soldado: {Tipo.Nombre}, Vida: {Vida}, Posición: ({PosicionX}, {PosicionY})");
    }
}

public class SoldierFactory
{
    private readonly List<SoldierType> _soldiersTypes = new();
    
    public SoldierType GetSoldierType(string nombre, string arma)
    {
        var soldierType = _soldiersTypes.FirstOrDefault(type => type.Nombre == nombre && type.Arma == arma);
        if (soldierType != null) return soldierType;
        
        soldierType = new SoldierType(nombre, arma);
        _soldiersTypes.Add(soldierType);
        return soldierType;
    }
}

public class SoldierManager
{
    private readonly SoldierFactory _soldierFactory = new();
    private readonly List<Soldier> _soldiers = new();

    public void AddSoldier(string nombre, string arma, int vida, int posicionX, int posicionY)
    {
        var soldierType = _soldierFactory.GetSoldierType(nombre, arma);
        var soldier = new Soldier(soldierType, vida, posicionX, posicionY);
        _soldiers.Add(soldier);
    }

    public void DisplaySoldiers()
    {
        foreach (var soldier in _soldiers)
        {
            soldier.Display();
        }
    }
}

