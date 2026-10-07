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


{
  "Namespace": "Dominio",
  "Class": {
    "Name": "Persona",
    "AccessModifier": "public",
    "Interfaces": [
      "IComparable<Persona>"
    ],
    "Fields": [
      {
        "Name": "Nombre",
        "Type": "string",
        "AccessModifier": "private"
      }
    ],
    "Properties": [
      {
        "Name": "Edad",
        "Type": "int",
        "AccessModifier": "public",
        "Accessors": ["get"]
      }
    ],
    "Constructors": [
      {
        "AccessModifier": "public",
        "Parameters": [
          { "Name": "nombre", "Type": "string" },
          { "Name": "edad", "Type": "int" }
        ],
        "Body": "this.Nombre = nombre; this.Edad = edad;"
      }
    ],
    "Methods": [
      {
        "Name": "ToString",
        "AccessModifier": "public",
        "Modifiers": ["override"],
        "ReturnType": "string",
        "Parameters": [],
        "Body": "return $\"Nombre: {Nombre}, Edad: {Edad}\";"
      },
      {
        "Name": "CompareTo",
        "AccessModifier": "public",
        "ReturnType": "int",
        "Parameters": [
          { "Name": "other", "Type": "Persona?" }
        ],
        "Body": "if (other == null) return 1; return this.Nombre.CompareTo(other.Nombre);"
      }
    ],
    "CommentedCode": [
      "public static int ComparaPorEdad(Persona p1, Persona p2) { return p1.Edad.CompareTo(p2.Edad); }"
    ]
  }
}
