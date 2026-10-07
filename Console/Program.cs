namespace Console
{
    using Dominio;
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new();
            personas.Add(new Persona("Juan", 30));
            personas.Add(new Persona("María", 20));
            personas.Add(new Persona("Pedro", 40));
            personas.Add(new Persona("Silvana", 36));

            personas.Sort();
            Console.WriteLine("Ordenando por nombre...");

            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.ToString());
            }

        }
    }
}