namespace EjemplosPatrones.SeleccionCreacionales.Ejercicio5;

public sealed class RegistroUsuarioUnico
{
    private static RegistroUsuarioUnico? _instance;

    private RegistroUsuarioUnico()
    {
        
    }
    
    public static RegistroUsuarioUnico GetInstance()
    {
        if (_instance == null)
        {
            _instance = new RegistroUsuarioUnico();
        }
        return _instance;
    }
}
