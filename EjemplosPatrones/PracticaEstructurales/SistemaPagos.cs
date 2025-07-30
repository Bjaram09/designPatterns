namespace EjemplosPatrones.PracticaEstructurales;

public interface IPaymentMethod
{
    void Pay(double amount);
}

public class CreditCardPayment : IPaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Pagando {amount:N2} con tarjeta de crédito.");
    }
}

public class PayPalPayment : IPaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Pagando {amount:N2} con PayPal.");
    }
}

public abstract class PaymentProcesser
{
    protected IPaymentMethod? PaymentMethod;

    public PaymentProcesser(IPaymentMethod? paymentMethod)
    {
        this.PaymentMethod = paymentMethod;
    }

    public abstract void ProcessPayment(double amount);
}

public class OnlineStorePaymentProcesser : PaymentProcesser
{
    public OnlineStorePaymentProcesser(IPaymentMethod? paymentMethod) : base(paymentMethod) { }

    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Procesando pago en la tienda en línea...");
        PaymentMethod.Pay(amount);
    }
}

public class MobileAppPaymentProcessor : PaymentProcesser
{
    public MobileAppPaymentProcessor(IPaymentMethod? paymentMethod) : base(paymentMethod) { }

    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Procesando pago en la aplicación móvil...");
        PaymentMethod.Pay(amount);
    }
}