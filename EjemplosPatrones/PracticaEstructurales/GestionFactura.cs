namespace EjemplosPatrones.PracticaEstructurales;

public interface IFactura
{
    string GetDescription();
    double GetTotalCost();
}
public class ItemFactura
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }

    public double GetTotal() => Precio * Cantidad;
}
public class BasicInvoice : IFactura
{
    public string NumeroFactura { get; set; }
    public DateTime FechaFactura { get; set; }
    public string NombreCliente { get; set; }
    public List<ItemFactura> Items { get; set; }
    private double _TasaIVA { get; set; } = 0.13;
    
    public BasicInvoice(string numeroFactura, DateTime fechaFactura, string nombreCliente)
    {
        NumeroFactura = numeroFactura;
        FechaFactura = fechaFactura;
        NombreCliente = nombreCliente;
        FechaFactura = DateTime.Now;
        Items = new List<ItemFactura>();
    }
    
    public void AgregarItem(string nombre, double precio, int cantidad)
    {
        var item = new ItemFactura
        {
            Nombre = nombre,
            Precio = precio,
            Cantidad = cantidad
        };
        Items.Add(item);
    }
    
    private double GetSubtotal() => Items.Sum(item => item.GetTotal());

    private double GetImpuesto() => GetSubtotal() * _TasaIVA;

    public double GetTotalCost() => GetSubtotal() + GetImpuesto();

    public string GetDescription()
    {
        return $"Factura #{NumeroFactura} - Cliente: {NombreCliente} - Total: {GetTotalCost():N2}";
    }
}
public class InvoiceDecorator : IFactura
{
    private readonly IFactura _factura;

    public InvoiceDecorator(IFactura factura)
    {
        _factura = factura;
    }

    public virtual string GetDescription()
    {
        return _factura.GetDescription();
    }

    public virtual double GetTotalCost()
    {
        return _factura.GetTotalCost();
    }
}
public class ShippingDecorator : InvoiceDecorator
{
    private double _shippingCost;

    public ShippingDecorator(IFactura factura, double shippingCost) : base(factura)
    {
        _shippingCost = shippingCost;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()} - Envío: {_shippingCost:N2}";
    }

    public override double GetTotalCost()
    {
        return base.GetTotalCost() + _shippingCost;
    }
}
public class GiftWrappingDecorator : InvoiceDecorator
{
    private double _wrappingCost;

    public GiftWrappingDecorator(IFactura factura, double wrappingCost) : base(factura)
    {
        _wrappingCost = wrappingCost;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()} - Envoltura de regalo: {_wrappingCost:N2}";
    }

    public override double GetTotalCost()
    {
        return base.GetTotalCost() + _wrappingCost;
    }
}
public class DiscountDecorator : InvoiceDecorator
{
    private double _discountPercentage;

    public DiscountDecorator(IFactura factura, double discountPercentage) : base(factura)
    {
        _discountPercentage = discountPercentage;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()} - Descuento: {_discountPercentage:N2}%";
    }

    public override double GetTotalCost()
    {
        var total = base.GetTotalCost();
        var discountAmount = total * (_discountPercentage / 100.0);
        return Math.Max(0, total - discountAmount);
    }
}

