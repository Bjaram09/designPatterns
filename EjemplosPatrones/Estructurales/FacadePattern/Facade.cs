namespace EjemplosPatrones.Estructurales.FacadePattern;

/*
 * 1. smtp.Conectar()
 * 2. smtp.Autenticar()
 * 3. smtp.EnviarEmail()
 * 4. smtp.Desconectar()
*/

public class ValidorEmail
{
    public bool EsValido(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }
}

public class ServidorSMTP
{
    public void Conectar(string servidor)
    {
        Console.WriteLine("Conectando...");
    }

    public void Autenticar(string usuario, string contraseña)
    {
        Console.WriteLine($"Autenticando usuario: {usuario}...");
    }

    public void EnviarEmail(string destinatario, string email)
    {
        Console.WriteLine($"Enviando email a {destinatario} con mensaje {email}...");
    }
    
    public void Desconectar(string servidor)
    {
        Console.WriteLine("Desconectando...");
    }
}

public class CorreoFacade
{
    private CorreoFacade correoFacade = new CorreoFacade();
}