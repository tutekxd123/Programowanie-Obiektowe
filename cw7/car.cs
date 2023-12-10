using System.Runtime.InteropServices;
using System.Windows.Forms;
class Car
{
    private double pojemnoscSilnika;
    private string marka;
    private int iloscKol = 4;
   private Car()
    {
        this.pojemnoscSilnika = 0;
        this.marka = "";
    }

    private Car(double pojemnoscSilnika, string marka)
    {
        this.pojemnoscSilnika = pojemnoscSilnika;
        this.marka = marka;
    }
    static public Car Create(double pojemnoscSilnika,string marka)
    {
        return new Car(pojemnoscSilnika, marka);
    }
   ~Car()
    {
        MessageBox.Show("Zwalniam pamiec");
    }


}

class Program
{
    static void Main()
    {
        //Car stary = new(); nie mozna utworzyc obiektu :(
        //Car nowysamochod = new(1600, "Seat");
        //Console.WriteLine(nowysamochod.marka); //Pole marka jest prywatne
        //Stary posiada obiekt z klasy CAR ale jest posty a nowysamochod posiada swoje informacje
        Car test = Car.Create(2000, "Seat");
        Console.WriteLine("Test");
        //nie wystepuje jezeli nie wywolam garbage collect czyszczenie pamieci
        GC.Collect();

    }
}
