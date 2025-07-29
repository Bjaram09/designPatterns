namespace EjemplosPatrones.Comportamiento.Observer;

public interface IObserver
{
    void Update(IPublisher publisher);
}

public interface IPublisher
{
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void Notify();
}

public class Publisher : IPublisher
{
    public int State { get; set; } = 0;
    private List<IObserver> _observers = new ();
    public void Subscribe(IObserver observer)
    {
        this._observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        this._observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }
}

public class Observer : IObserver
{
    public string Name { get; }

    public Observer(string name)
    {
        this.Name = name;
    }

    public void Update(IPublisher publisher)
    {
        if (((Publisher)publisher).State >= 5)
        {
            Console.WriteLine("Hola mayor que 5");
        }
    }
}