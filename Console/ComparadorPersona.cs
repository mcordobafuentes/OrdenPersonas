using System.Collections.Generic;
using System.Reflection;
using Dominio;

public class ComparadorPorEdad : IComparer<Persona>
{
    public int Compare(Persona? p1, Persona? p2)
    {
        if (p1 == null && p2 == null) return 0;
        if (p1 == null) return -1;
        if (p2 == null) return 1;

        var edadPropiedad = typeof(Persona).GetProperty("Edad", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        if (edadPropiedad == null) throw new InvalidOperationException("La propiedad 'Edad' no existe en Persona.");

        var edad1 = edadPropiedad.GetValue(p1);
        var edad2 = edadPropiedad.GetValue(p2);

        return ((IComparable)edad1!).CompareTo(edad2);
    }


}

public class ComparadorPorEdadDescendente : IComparer<Persona>
{
    public int Compare(Persona? p1, Persona? p2)
    {
        if (p1 == null && p2 == null) return 0;
        if (p1 == null) return -1;
        if (p2 == null) return 1;

        return p2.Edad.CompareTo(p1.Edad);
    }
}