using System.Runtime.InteropServices;
 
namespace RijSchool;
 
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
 
    Auto Auto1 = new Auto()
    {
        automaat = true,
        kenteken = "AB-123-CD",
        kilometerStand = 15000,
        merk = "BMW",
    };
 
    Auto Auto2 = new Auto()
    {
        automaat = false,
        kenteken = "PD-028-KL",
        kilometerStand = 2835189,
        merk = "Audi",
    };
 
    RijLeraar RijLeraar1 = new RijLeraar()
    {
        naam = "Jan",
        leeftijd = 45,
        zzp = false,
    };
 
    TheorieTest TheorieTest1 = new TheorieTest()
    {
        aantalFouten = 3,
        Gehaald = true,
        afnameDatum = new DateTime(2024, 11, 15),
    };
 
    RijTest RijTest1 = new RijTest()
    {
        Gehaald = false,
        AfnameDatum = new DateTime(2024, 12, 1),
    };
 
    LesPakket LesPakket1 = new LesPakket()
    {
        urenGekocht = 40,
        urenVerbruikt = 25,
        examenPogingen = 2,
        automaat = false,
    };
 
    void Run()
    {
        var student1 = new Student()
        {
            naam = "Pietje",
            leeftijd = 25,
            LesPakket = LesPakket,
            RijLeraar = rijleraar,
            TheorieTest = theorieTest,
            RijTest = RijTest,
        };
 
        var lesuur = new LesUur()
        {
            Auto = Auto,
            RijLeraar = RijLeraar,
            Student = Student,
            tijd = 1130,
        };
    }
}
 