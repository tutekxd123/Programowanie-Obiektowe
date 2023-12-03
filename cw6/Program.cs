using ConsoleApp3;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Car car1 = new ("Volvo",1600);
        //Car car2 = new("Seat", 2001);
        var carName = "Mój samochód"; //nie rozumiem sensu
        Console.WriteLine(carName);
        car1.wyswietl();
        //car1 = car2;
        car1.wyswietl();
    }
}
