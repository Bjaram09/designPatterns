using EjemplosPatrones.SeleccionComportamiento.Ejercicio1;
using EjemplosPatrones.SeleccionComportamiento.Ejercicio10;
using EjemplosPatrones.SeleccionComportamiento.Ejercicio2;
using EjemplosPatrones.SeleccionComportamiento.Ejercicio3;
using EjemplosPatrones.SeleccionComportamiento.Ejercicio4;
using EjemplosPatrones.SeleccionComportamiento.Ejercicio5;
using EjemplosPatrones.SeleccionComportamiento.Ejercicio6;
using EjemplosPatrones.SeleccionComportamiento.Ejercicio7;
using EjemplosPatrones.SeleccionComportamiento.Ejercicio8;
using EjemplosPatrones.SeleccionComportamiento.Ejercicio9;
using Producto = EjemplosPatrones.SeleccionComportamiento.Ejercicio3.Producto;

namespace EjemplosPatrones;

public class ChainOfResponsabilityCommand : ICommand
{
    public void Ejecutar()
    {
        Console.WriteLine("=== Ejemplo patrón Chain of Responsibility ===\n");
        
        var gestor = new GestorDeSoporte();

        gestor.Procesar(new Solicitud("Básico", "No puedo iniciar sesión"));
        gestor.Procesar(new Solicitud("Avanzado", "Problema con el servidor"));
        gestor.Procesar(new Solicitud("Supervisor", "Reclamo por mal servicio"));
        gestor.Procesar(new Solicitud("Desconocido", "No sé qué hacer con esto"));
    }
}

public class CommandCommand : ICommand
{
    public void Ejecutar()
    {
        EditorTexto editor = new();
        HistorialComandos historial = new();
        
        do
        {
            Console.Clear();
            editor.Mostrar();
            Console.WriteLine("\n[Ctrl+Z: Deshacer | Ctrl+Y: Rehacer | Shift+ESC: Salir], NO se puede usar backspace.");
            Console.Write("Escribe texto o atajo: ");

            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Control))
            {
                if (keyInfo.Key == ConsoleKey.Z)
                {
                    historial.Deshacer();
                }
                else if (keyInfo.Key == ConsoleKey.Y)
                {
                    historial.Rehacer();
                }
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                break;
            }
            else
            {
                Console.Write(keyInfo.KeyChar);
                var texto = keyInfo.KeyChar.ToString();
                IComando escribir = new EscribirTexto(editor, texto);
                historial.Ejecutar(escribir);
            }

        } while (true);
    }
}

public class IteratorCommand : ICommand
{
    public void Ejecutar() 
    {
        Console.WriteLine("=== Ejemplo patrón Iterator ===\n");
        
        var productos = new List<Producto>
        {
            new Producto("Laptop", 1200.99m, "Electrónica"),
            new Producto("Auriculares", 89.50m, "Periféricos"),
            new Producto("Teclado", 45.00m, "Periféricos"),
            new Producto("Monitor", 210.75m, "Electrónica"),
            new Producto("Silla ergonómica", 350.00m, "Muebles")
        };
        
        var recorrido = new RecorrerProductos(productos);
        
        Console.WriteLine("Recorrido alfabético:");
        MostrarRecorrido(recorrido.CrearIterador("alfabetico"));
        
        Console.WriteLine("\nRecorrido por precio:");
        MostrarRecorrido(recorrido.CrearIterador("precio"));
        
        Console.WriteLine("\nRecorrido por categoría:");
        MostrarRecorrido(recorrido.CrearIterador("categoria"));
    }

    private static void MostrarRecorrido(IIterador<Producto> iterador)
    {
        while (iterador.TieneSiguiente())
        {
            var producto = iterador.Siguiente();
            Console.WriteLine(producto);
        }
    }
}

public class MediatorCommand : ICommand
{
    public void Ejecutar()
    {
        Console.WriteLine("=== Ejemplo patrón Mediator ===\n");
        var chat = new SistemaChat();

        var usuario1 = new Usuario("Bryan", chat);
        var usuario2 = new Usuario("Jose", chat);
        var usuario3 = new Usuario("Miguel", chat);

        chat.RegistrarUsuario(usuario1);
        chat.RegistrarUsuario(usuario2);
        chat.RegistrarUsuario(usuario3);

        usuario1.Enviar("¡Hola a todos!");
        usuario2.Enviar("¡Hola Bryan!");
        usuario3.Enviar("¡Hola Bryan y Jose, soy Miguel!");
    }
}

public class MementoCommand : ICommand
{
    public void Ejecutar()
    {
        Console.WriteLine("=== Ejemplo patrón Memento ===\n");
        
        var jugador = new Jugador("BJara09");
        var gestor = new GestorGuardado();

        jugador.Jugar();
        gestor.GuardarEstado(jugador.Guardar());

        jugador.Jugar();
        jugador.Jugar();
        jugador.MostrarEstado();
        
        var memento = gestor.RecuperarUltimoEstado();
        if (memento != null)
        {
            jugador.Restaurar(memento);
            jugador.MostrarEstado();
        }
    }
}

public class ObserverCommand : ICommand
{
    public void Ejecutar()
    {
        Console.WriteLine("=== Ejemplo patrón Observer ===\n");
        
        var producto = new ProductoObservado("Laptop", 10);
        
        var facturacion = new ModuloFacturacion();
        var estadisticas = new ModuloEstadisticas();
        var notificaciones = new ModuloNotificacionesClientes();

        producto.Suscribir(facturacion);
        producto.Suscribir(estadisticas);
        producto.Suscribir(notificaciones);
        
        Console.WriteLine("Reduciendo stock...");
        producto.Stock = 0;

        Console.WriteLine("\nReponiendo stock...");
        producto.Stock = 15;
    }
}

public class StateCommand : ICommand
{
    public void Ejecutar()
    {
        Console.WriteLine("=== Ejemplo patrón State ===\n");
        
        var pedido = new Pedido("Bryan Jara");

        pedido.MostrarEstado();
        pedido.Procesar();

        pedido.MostrarEstado();
        pedido.Procesar();

        pedido.MostrarEstado();
        pedido.Cancelar();
    }
}

public class StrategyCommand : ICommand
{
    public void Ejecutar()
    {
        Console.WriteLine("=== Ejemplo patrón Strategy ===\n");

        var procesador = new ProcesadorPago(new PagoConTarjeta());
        procesador.ProcesarPago(50.00m);

        Console.WriteLine("\n--- Cambiando a PayPal ---");
        procesador.CambiarMetodo(new PagoConPayPal());
        procesador.ProcesarPago(75.25m);

        Console.WriteLine("\n--- Cambiando a Criptomonedas ---");
        procesador.CambiarMetodo(new PagoConCripto());
        procesador.ProcesarPago(150.80m);
    }
}

public class TemplateMethodCommand : ICommand
{
    public void Ejecutar()
    {
        Console.WriteLine("=== Ejemplo patrón Template Method ===\n");
        
        GeneradorInforme informe1 = new InformeVentas();
        GeneradorInforme informe2 = new InformeInventario();

        Console.WriteLine("==== Generando Informe de Ventas ====");
        informe1.Generar();

        Console.WriteLine("\n==== Generando Informe de Inventario ====");
        informe2.Generar();
    }
}

public class VisitorCommand : ICommand
{
    public void Ejecutar()
    {
        List<IDocumento> documentos = new()
        {
            new DocumentoTexto(),
            new DocumentoPDF()
        };

        List<IVisitor> operaciones = new()
        {
            new ContadorPalabras(),
            new PalabrasClaveExtractor(),
            new CorrectorOrtografico()
        };

        foreach (var doc in documentos)
        {
            Console.WriteLine($"\nAnalizando nuevo documento...");
            foreach (var operacion in operaciones)
            {
                doc.Aceptar(operacion);
            }
        }
    }
}