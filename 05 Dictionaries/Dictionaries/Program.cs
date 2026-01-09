using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Maak een nieuwe dictionary
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        // 2. Voeg items toe
        myDictionary.Add("Alice", 25);
        myDictionary.Add("Bob", 32);
        myDictionary.Add("Tim", 40);

        // 3. Ophalen van 1 item via key
        Console.WriteLine("Leeftijd van Bob: " + myDictionary["Bob"]);

        // 4. Loop door alle keys en values
        Console.WriteLine("\nAlle personen en leeftijden:");
        foreach (var item in myDictionary)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }

        // 5. Alleen keys
        Console.WriteLine("\nAlle keys:");
        foreach (var key in myDictionary.Keys)
        {
            Console.WriteLine(key);
        }

        // 6. Alleen values
        Console.WriteLine("\nAlle values:");
        foreach (var value in myDictionary.Values)
        {
            Console.WriteLine(value);
        }
    }
}
