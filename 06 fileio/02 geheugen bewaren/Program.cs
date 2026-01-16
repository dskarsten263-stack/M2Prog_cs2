namespace _02_geheugen_bewaren;

using System;
using System.IO;

class Program
{
    static void Main()
    {
       
        string saveFile = "welkomState.txt";

        
        if (File.Exists(saveFile))
        {
            string oudeTekst = File.ReadAllText(saveFile);
            Console.WriteLine("Vorige tekst: " + oudeTekst);
        }
        else
        {
            Console.WriteLine("Geen bestaande tekst gevonden.");
        }

        
        Console.WriteLine("Typ een nieuwe tekst:");
        string nieuweTekst = Console.ReadLine();

        
        File.WriteAllText(saveFile, nieuweTekst);

        Console.WriteLine("Je tekst is opgeslagen!");
    }
}

