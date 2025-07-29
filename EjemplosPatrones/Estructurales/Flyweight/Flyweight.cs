using System.Numerics;

namespace EjemplosPatrones.Estructurales.Flyweight;

public class MovingParticle
{
    public Particle particle;
    public Vector3 coords;
    public Vector3 vector;
    public float speed;
}

public class Particle
{
    public string color;
    public string nombreSprite;

    public Particle(string color, string nombreSprite)
    {
        this.color = color;
        this.nombreSprite = nombreSprite;
    }
}

public class ParticulaFactory
{
    private List<Particle> _particles = new List<Particle>();

    public string getKey(string color, string nombreSprite)
    {
        return $"{color}_{nombreSprite}";
    }

    public Particle addParticle(string color, string nombreSprite)
    {
        var particle = new Particle(color, nombreSprite);
        return particle;
    }
}



