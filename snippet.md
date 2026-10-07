"Ejemplo de Lista de Personas Ordenada": {
    "prefix": "listapersonas",
    "body": [
        "List<Persona> personas = new();",
        "personas.Add(new Persona(\"Juan\", 30));",
        "personas.Add(new Persona(\"María\", 20));",
        "personas.Add(new Persona(\"Pedro\", 40));",
        "personas.Add(new Persona(\"Silvana\", 36));",
        "",
        "personas.Sort();",
        "Console.WriteLine(\"Ordenando por nombre...\");",
        "",
        "foreach (Persona persona in personas)",
        "{",
        "    Console.WriteLine(persona.ToString());",
        "}"
    ],
    "description": "Crea una lista de objetos Persona, la ordena y la muestra en consola."
}