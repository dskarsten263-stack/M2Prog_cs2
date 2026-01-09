using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {

            string[] characters =
            {
                "Pac-Man",
                "Samus",
                "Crash Bandicoot",
                "Spyro the Dragon",
                "Donkey Kong",
                "Mario",
                "Luigi",
                "Astro",
                "Solid Snake",
                "Master Chief",
                "Kratos",
                "Sonic the Hedgehog",
                "Link"
            };


            List<string> characterList = new List<string>();


            characterList.Add("BIG BOSS");

            foreach (string c in characters)
            {
                characterList.Add(c);
            }


            for (int i = 0; i < characterList.Count; i++)
            {
                Console.WriteLine(characterList[i]);
            }
            Console.WriteLine($"Total characters: {characterList.Count}");

            
        }
        
    }
}
