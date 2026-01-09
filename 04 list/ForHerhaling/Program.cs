namespace _04_list;

class Program
{
    static void Main(string[] args)
    {
        {
            double[] prijzen = { 0.99, 5.60, 10.11 };

            string[] artiekelen = { "snoepjes", "luxe broodje", "lunch menu" };

            Formulier[] Formulieren = new Formulier[2];
        }

    internal class Formulier
    {
        internal int Sterren { get; set; }
        internal string Feedback { get; set; }
    }

    Formulieren[1] = new Formulier()
    {
        Feedback = "prijzig maar lekker",
        Sterren = 5
    };
    Formulieren[2] = new Formulier()
    {
        Feedback = "te duur",
        Sterren = 3
    };
    for (int i = 0; i<prijzen.Length; i++)
    {
        Console.WriteLine(prijzen[i]);
    };
    }
}