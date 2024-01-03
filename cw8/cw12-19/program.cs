class Vehicle {

}
interface IRideable
{
    public void Ride();
}
class Car : Vehicle,IRideable  {
    public void Ride()
    {
        Console.WriteLine("Jadę Samochodem");
    }

}
class Bicycle : Vehicle,IRideable
{
    public void Ride()
    {
        Console.WriteLine("Jadę rowerem");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        Bicycle bicycle1 = new Bicycle();
        car1.Ride();
        bicycle1.Ride();
        Osoba osoba1 = new Osoba();
        osoba1.Graj();
        ((ISkrzypek)osoba1).Graj();
        ((IGitarzysta)osoba1).Graj(); //albo ifami w metodzie Graj?
    }
}
