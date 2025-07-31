using EjemplosPatrones.PracticaEstructurales_v2;
using EjemplosPatrones.PracticaEstructurales;

namespace EjemplosPatrones;

public class CargadorCommand : ICommand
{
    public void Ejecutar()
    {
        ICharger cargador220V = new Charger();
        cargador220V.Charge();
        
        ICharger cargador110V = new UsChargerAdapter();
        cargador110V.Charge();
    }
}

public class GestionFacturaCommand : ICommand
{
    public void Ejecutar()
    {
        Console.WriteLine("=== Crear Factura ===");
        Console.Write("Número de factura: ");
        var numero = Console.ReadLine();
        Console.Write("Nombre del cliente: ");
        var cliente = Console.ReadLine();

        var factura = new BasicInvoice(numero, DateTime.Now, cliente);
        
        while (true)
        {
            Console.Write("Agregar producto (dejar vacío para terminar): ");
            string nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombre)) break;

            Console.Write("Precio: ");
            if (!double.TryParse(Console.ReadLine(), out double precio)) continue;

            Console.Write("Cantidad: ");
            if (!int.TryParse(Console.ReadLine(), out int cantidad)) continue;

            factura.AgregarItem(nombre, precio, cantidad);
        }

        IFactura decorated = factura;
        
        while (true)
        {
            Console.WriteLine("\n¿Desea agregar un servicio?");
            Console.WriteLine("1. Envío");
            Console.WriteLine("2. Envoltura de regalo");
            Console.WriteLine("3. Descuento");
            Console.WriteLine("4. Finalizar");
            Console.Write("Opción: ");
            var opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Costo de envío: ");
                if (double.TryParse(Console.ReadLine(), out double envio))
                    decorated = new ShippingDecorator(decorated, envio);
            }
            else if (opcion == "2")
            {
                Console.Write("Costo de envoltura: ");
                if (double.TryParse(Console.ReadLine(), out double envoltura))
                    decorated = new GiftWrappingDecorator(decorated, envoltura);
            }
            else if (opcion == "3")
            {
                Console.Write("Monto de descuento: ");
                if (double.TryParse(Console.ReadLine(), out double descuento))
                    decorated = new DiscountDecorator(decorated, descuento);
            }
            else if (opcion == "4")
            {
                break;
            }
        }
        
        Console.WriteLine("\n=== Resumen de Factura ===");
        Console.WriteLine(decorated.GetDescription());
        Console.WriteLine($"Total a pagar: ₡{decorated.GetTotalCost():N2}");
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }
}

public class PagosCommand : ICommand
{
    public void Ejecutar()
    {
        Console.WriteLine("=== Sistema de Pagos ===");
        
        Console.Write("Ingrese el monto a pagar: ");
        if (!double.TryParse(Console.ReadLine(), out double amount) || amount <= 0)
        {
            Console.WriteLine("Monto inválido.");
            Console.ReadKey();
            return;
        }
        
        Console.WriteLine("Seleccione el método de pago:");
        Console.WriteLine("1. Tarjeta de crédito");
        Console.WriteLine("2. PayPal");
        Console.Write("Opción: ");
        var metodo = Console.ReadLine();

        IPaymentMethod? paymentMethod = metodo switch
        {
            "1" => new CreditCardPayment(),
            "2" => new PayPalPayment(),
            _ => null
        };

        if (paymentMethod == null)
        {
            Console.WriteLine("Método de pago inválido.");
            Console.ReadKey();
            return;
        }
        
        Console.WriteLine("Seleccione la plataforma:");
        Console.WriteLine("1. Tienda en línea");
        Console.WriteLine("2. Aplicación móvil");
        Console.Write("Opción: ");
        var plataforma = Console.ReadLine();

        PaymentProcesser? processor = plataforma switch
        {
            "1" => new OnlineStorePaymentProcesser(paymentMethod),
            "2" => new MobileAppPaymentProcessor(paymentMethod),
            _ => null
        };

        if (processor == null)
        {
            Console.WriteLine("Plataforma inválida.");
            Console.ReadKey();
            return;
        }
        
        Console.WriteLine();
        processor.ProcessPayment(amount);

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }
}

public class FlyweightCommand : ICommand
{
    public void Ejecutar()
    {
        Console.WriteLine("=== Patrón Flyweight ===");
        
        var soldierManager = new SoldierManager();
        
        soldierManager.AddSoldier("Infantería", "Rifle", 100, 10, 20);
        soldierManager.AddSoldier("Infantería", "Rifle", 90, 15, 25);
        soldierManager.AddSoldier("Tanque", "Cañón", 200, 30, 40);
        soldierManager.AddSoldier("Tanque", "Cañón", 180, 35, 45);
        soldierManager.AddSoldier("Infantería", "Pistola", 80, 5, 10);
        soldierManager.AddSoldier("Infantería", "Pistola", 70, 8, 12);
        
        soldierManager.DisplaySoldiers();

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }
}

public class FacadeCommand : ICommand
{
    public void Ejecutar()
    {
        throw new NotImplementedException("Este ejercicio aún no está implementado.");
    }
}

public class ProxyCommand : ICommand
{
    public void Ejecutar()
    {
        throw new NotImplementedException("Este ejercicio aún no está implementado.");
    }
}

