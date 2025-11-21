using System;

namespace Functions
{
    internal class Program
    {
        string[] vragen = new string[]
        {
            "how long do you think you'd survive in a zombie apocalypse?",
            "Why do round pizzas come in square boxes?",
            "If you could have any superpower, what would it be?",
            "If you could live in any fictional universe, which one would you choose?",
            "What is the weirdest food you've ever eaten?",
            "If you could time travel, would you go to the past or the future?"     
            
        };

        internal string GetVraag(int vraagindex)
        {
            return vragen[vraagindex];
            string vraag0 = GetVraag(0);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.WriteLine("...");
        }

        //hier komt je function
         internal void Run()
        {
            Console.WriteLine("...");
            // gebruik AskRandomQuestion vier keer
            AskRandomQuestion();
            AskRandomQuestion();
            AskRandomQuestion();
            AskRandomQuestion();
            //vraag1(); 
            //vraag2();
            //vraag3();
            //vraag4();
            //vraag5();
            //vraag6();
            //vraag7(); 
        }


        internal void vraag1()
        {
            Console.WriteLine("how long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void vraag2()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void vraag3()
        {
            Console.WriteLine("If you could have any superpower, what would it be?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void vraag4()
        {
            Console.WriteLine("If you could live in any fictional universe, which one would you choose?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void vraag5()
        {
            Console.WriteLine("What is the weirdest food you've ever eaten?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void vraag6()
        {
            Console.WriteLine("If you could time travel, would you go to the past or the future?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal string Vraag7()
        {
            Console.WriteLine("how long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            return antwoord;
        }

        internal string GetRandomVraag()
        {
            //gebruik random 
            int random = new Random().Next(0, vragen.Length);
            return GetVraag(random);

        }

        internal void AskRandomQuestion()
        {
            // haal een willekeurige vraag op
            string vraag = GetRandomVraag();
            // toon vraag en vraag antwoord
            Console.WriteLine(vraag);
            string antwoord = Console.ReadLine();
            // toon antwoord
            Console.WriteLine(antwoord);
        }
    }
}


