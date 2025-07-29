// Menu.cs
namespace EjemplosPatrones;

public class Menu
{
    private string _title;
    private readonly List<MenuOption> _options = new();

    public void AddTitle(string title)
    {
        _title = title;
    }

    public void AddOption(string description, ICommand command)
    {
        _options.Add(new MenuOption(description, command));
    }

    // Overload to add submenu
    public void AddOption(string description, Menu submenu)
    {
        _options.Add(new MenuOption(description, submenu));
    }

    public void Show()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine(_title);
            for (int i = 0; i < _options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_options[i].Description}");
            }
            Console.WriteLine($"{_options.Count + 1}. Salir");
            Console.Write("Seleciona una opción (1-{0}): ", _options.Count + 1);

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > _options.Count + 1)
            {
                Console.WriteLine("Opcion Invalida. Por favor, intenta de nuevo.");
                Console.ReadKey();
                continue;
            }

            if (opcion == _options.Count + 1) break;

            var selected = _options[opcion - 1];
            if (selected.Command != null)
            {
                selected.Command.Ejecutar();
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
            }
            else if (selected.SubMenu != null)
            {
                selected.SubMenu.Show();
            }
        } while (true);
    }
}

public class MenuOption
{
    public string Description { get; }
    public ICommand Command { get; }
    public Menu SubMenu { get; }

    public MenuOption(string description, ICommand command)
    {
        Description = description;
        Command = command;
        SubMenu = null;
    }

    public MenuOption(string description, Menu submenu)
    {
        Description = description;
        SubMenu = submenu;
        Command = null;
    }
}


