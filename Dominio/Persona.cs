namespace Dominio;

public class Persona : IComparable<Persona>
{
    private string Nombre;
    public int Edad { get; }

    public Persona(string nombre, int edad)
    {
        this.Nombre = nombre;
        this.Edad = edad;
    }


    // public static int ComparaPorEdad(Persona p1, Persona p2)
    // {
    //     return p1.Edad.CompareTo(p2.Edad);
    // }


    public override string ToString()
    {
        return $"Nombre: {Nombre}, Edad: {Edad}";
    }

    public int CompareTo(Persona? other)
    {
        if (other == null) return 1;
        return this.Nombre.CompareTo(other.Nombre);
    }
}
