namespace _03_json;

using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


class Persoon
{
    public string Naam { get; set; }
    public int Leeftijd { get; set; }
    public string Woonplaats { get; set; }
}

class Program
{
    static void Main()
    {
        
        Persoon p = new Persoon
        {
            Naam = "Alice",
            Leeftijd = 25,
            Woonplaats = "Amsterdam"
        };

        
        string jsonBestand = "persoon.json";
        string jsonString = JsonSerializer.Serialize(p, new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText(jsonBestand, jsonString);
        Console.WriteLine("Data is opgeslagen in JSON!");

        
        if (File.Exists(jsonBestand))
        {
            string gelezenJson = File.ReadAllText(jsonBestand);

            Persoon p2 = JsonSerializer.Deserialize<Persoon>(gelezenJson);

            Console.WriteLine("\nGelezen uit JSON:");
            Console.WriteLine("Naam: " + p2.Naam);
            Console.WriteLine("Leeftijd: " + p2.Leeftijd);
            Console.WriteLine("Woonplaats: " + p2.Woonplaats);
        }
        else
        {
            Console.WriteLine("JSON bestand niet gevonden!");
        }
    }
}
