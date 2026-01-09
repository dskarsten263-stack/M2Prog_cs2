namespace Remove;

class Program
{
    static void Main(string[] args)
    {
        List<double> prijzen = new List<double>() { 0.99, 4.68, 342.92, 12.2 };
        Console.WriteLine("Prijzen:");
        foreach (double prijs in prijzen)
        {
            Console.WriteLine(prijs);
        }

        List<Pickup> pickups = new List<Pickup>();
        for (int i = 0; i < 10; i++)
        {
            Pickup pickup = new Pickup()
            {
                x = i,
                y = 0
            };
        pickups.Add(pickup);
        }
    }
}

