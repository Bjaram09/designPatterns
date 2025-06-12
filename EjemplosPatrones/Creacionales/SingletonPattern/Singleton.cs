namespace EjemplosPatrones.Creacionales.SingletonPatron;

/*
 * Necesitamos que sea sealed para que nadie herede de ella
 */
public sealed class Singleton
{
    private static Singleton _instance;
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Token { get; set; }

    private Singleton()
    {
        Token = "miSessionID_Unico";
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
    
}