using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dictionary met string als key en Room als value
        Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        // Kamers aanmaken
        Room kitchen = new Room(
            "Keuken",
            "Een keuken met een koelkast en een fornuis."
        );

        Room livingRoom = new Room(
            "Woonkamer",
            "Een gezellige woonkamer met een bank en tv."
        );

        Room bedroom = new Room(
            "Slaapkamer",
            "Een rustige slaapkamer met een bed."
        );

        // Kamers toevoegen aan dictionary
        rooms.Add("keuken", kitchen);
        rooms.Add("woonkamer", livingRoom);
        rooms.Add("slaapkamer", bedroom);

        // Alle kamers tonen
        Console.WriteLine("Alle kamers:\n");
        foreach (var room in rooms)
        {
            room.Value.ShowInfo();
            Console.WriteLine();
        }

        // Specifieke kamer ophalen
        Console.Write("Welke kamer wil je bekijken? ");
        string input = Console.ReadLine().ToLower();

        if (rooms.ContainsKey(input))
        {
            Console.WriteLine();
            rooms[input].ShowInfo();
        }
        else
        {
            Console.WriteLine("Deze kamer bestaat niet.");
        }
    }
}
class Room
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Room(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Kamer: " + Name);
        Console.WriteLine("Beschrijving: " + Description);
    }
}
