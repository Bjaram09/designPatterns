namespace EjemplosPatrones.Comportamiento.TemplateMethod;

public abstract class RegistroUsuario
{
    public void Registrar(string nombre, string email)
    {
        if (Validar(nombre, email))
        {
            GuardarUsuario(nombre, email);
            EnviarMensajeBienvenida(email);
        }
        Console.WriteLine("Datos invalidos. Registro fallido");
    }
    
    protected abstract bool Validar(string nombre, string email);

    protected virtual void GuardarUsuario(string nombre, string email)
    {
        Console.WriteLine("Datos validos. Guardar");
    }
    
    protected abstract void EnviarMensajeBienvenida(string email);
}

public class RegistroUsuarioEstandar : RegistroUsuario
{
    protected override bool Validar(string nombre, string email)
    {
        return email.Contains("@") && nombre.Length > 2;
    }

    protected override void EnviarMensajeBienvenida(string email)
    {
        Console.WriteLine($"Hola {email}, bienvenido a nuestro servicio");
    }
}


public class RegistroUsuarioAdmin : RegistroUsuario
{
    protected override bool Validar(string nombre, string email)
    {
        return email.EndsWith("@dominio.com") && nombre.Length > 5;
    }

    protected override void EnviarMensajeBienvenida(string email)
    {
        Console.WriteLine($"Hola {email}, se le ha otorgado permisos de admin");
    }
}