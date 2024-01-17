using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Runtime.CompilerServices;
public class Osoba
{
    private string imie;
    private int wiek;
    public Osoba()
    {
        this.imie = "";
        this.wiek = 0;
    }
    public Osoba(string imie, int wiek)
    {
        this.imie = imie;
        this.wiek = wiek;
    }
    public void setimie(string imie="")
    {
        this.imie = imie;
    }
    public void setwiek(int wiek = 0)
    {
        this.wiek = wiek;
    }
    public string getimie()
    {
        return this.imie;
    }
    public int getwiek()
    {
        return this.wiek;
    }
}
public abstract class CalculatorData
{
    public double liczba1 { get; set; }
    public double liczba2 { get; set; }
    public char Operator { get; set; }
    public double wynik { get; set; }
    public CalculatorData(double liczba1, double liczba2, char @operator, double wynik)
    {
        this.liczba1 = liczba1;
        this.liczba2 = liczba2;
        Operator = @operator;
        this.wynik = wynik;
    }
}
public class LogicCalculator : CalculatorData
{
    public LogicCalculator(double liczba1, double liczba2, char @operator, double wynik) : base(liczba1, liczba2, @operator, wynik){}
    public double performoperation(CalculatorData calculator)
    {
            try {
                switch (calculator.Operator)
                {
                    case '-':
                        calculator.wynik = calculator.liczba1 - calculator.liczba2;
                        break;
                    case '+':
                        calculator.wynik = calculator.liczba1 + calculator.liczba2;
                        break;
                    case '*':
                        calculator.wynik = calculator.liczba1 * calculator.liczba2;
                        break;
                    case '/':
                        calculator.wynik = calculator.liczba1 / calculator.liczba2;
                        break;
                    default:
                        return calculator.liczba1;
                }
                return calculator.wynik;
            }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            return 0;
        }
        }
} //C) nie da chyba rady bo intergalnosc bedzie problemem
public enum Karta
{
    dwa = 2,
    trzy = 3,
    cztery = 4,
    piec = 5,
    szesc = 6,
    siedem = 7,
    osiem = 8,
    dziewiec = 9,
    dziesiec = 10,
    walet = 11,
    dama=12,
    krol = 13,
    As = 14
}
class Gracz
{
    public string nick = "tutek";
    public int[] kartalist;
    public Gracz(string nick)
    {
        this.nick = nick;
        kartalist = new int[0];
    }
    public void addkarta(Karta karta)
    {
        Array.Resize(ref kartalist, kartalist.Length + 1);
        kartalist[kartalist.Length - 1] = (int)karta;
    }

    public double sumakart()
    {
        double suma = 0;
        for(int i = 0; i < kartalist.Length; i++)
        {
            suma += kartalist[i];
        }
        return suma;
    }

}

class Program
{
    static Karta[] UtworzTalie()
    {
        Array values = Enum.GetValues(typeof(Karta));
        Random random = new Random();
        Karta[] talia = new Karta[values.Length];
        for (int i = 0; i < talia.Length; i++)
        {
            talia[i] = (Karta)values.GetValue(random.Next(values.Length));
        }
        return talia;
    }
    static void grakarta()
    {
        Karta[] talia = UtworzTalie();
        Gracz gracz1 = new Gracz("tutek");
        Gracz gracz2 = new Gracz("Piotr");

        for (int i = 0; i < 3; i++)
        {
            gracz1.addkarta(talia[i]);
            gracz2.addkarta(talia[i + 3]);
        }

        Console.WriteLine($"Reka gracza 1: {string.Join(", ", gracz1.kartalist)}");
        Console.WriteLine($"Suma reki gracza 1: {gracz1.sumakart()}");
        Console.WriteLine($"Reka gracza 2: {string.Join(", ", gracz2.kartalist)}");
        Console.WriteLine($"Suma reki gracza 2: {gracz2.sumakart()}");

    }
    static void collections()
    {
        Stack test = new Stack();
        test.Push("Piotr");
        test.Push("Tutek");
        test.Push("Aleks");
        test.Push("Malenka");
        test.Push("Queue");
        SortedSet<int> sortowana = new SortedSet<int>();
        sortowana.Add(67);
        sortowana.Add(90);
        sortowana.Add(1);
        sortowana.Add(10);
        sortowana.Add(43);
        Queue<Osoba> kolejka = new Queue<Osoba>();
        kolejka.Enqueue(new Osoba("Piotr",24));
        kolejka.Enqueue(new Osoba("Tutek", 30));
        kolejka.Enqueue(new Osoba("Aleks", 60));
        kolejka.Enqueue(new Osoba("Malenka", 76));
        kolejka.Enqueue(new Osoba("Queue", 98));
        //kolejka.Enqueue(2); //nie mozliwe
        //Ale w przypadku Generycznych Typow danych jest to realne
        Console.WriteLine("Kolejka Osob:");
        foreach(Osoba o in kolejka)
        {
            Console.WriteLine("Imie: {0} Wiek:{1}",o.getimie(),o.getwiek());
        }
        Console.WriteLine("Zbior sortowany: ");
        foreach(int k in sortowana)
        {
            Console.WriteLine(k);
        }
        Console.WriteLine("Stack: (String)");
        foreach(var item in test)
        {
            Console.WriteLine(item);
        }
        //W SortedSet nic nie trzeba robic
        //W Kolejce i w stosie kolejnosc dodawania przedmiotow jest bardzo wazna
        //Wiec zeby posortowac to trzeba wrzucic to albo w liste, posortować
        //Nastepnie oproznic kolejke,stos i wrzucic w odpowiedniej kolejnosci
        //Ogolnie realne jest w kazdej lecz nie bezposrednio
        //W kolejce bez wzgledu na kolejnosc!
        Queue<Osoba> deletedkolejka =  new Queue<Osoba> ();

        for(int i = 0; i < 4; i++)
        {
            deletedkolejka.Enqueue(kolejka.Dequeue());
        }
        //0,1,2,3
        //3,2,1,0
        //0,1,2,3
        deletedkolejka = new Queue<Osoba>(deletedkolejka.Reverse()); //reverse
        deletedkolejka.Dequeue();
        for(int i = 0; i < 3; i++)
        {
            kolejka.Enqueue(deletedkolejka.Dequeue());
        }
        kolejka = new Queue<Osoba>(kolejka.Reverse()); //Zeby kolejnosc sie zgadzala :D
        Console.WriteLine("Kolejka: (Osoba) po usunieciu");
        foreach (Osoba o in kolejka)
        {
            Console.WriteLine("Imie: {0} Wiek:{1}", o.getimie(), o.getwiek());
        }
        //Jak widac w Kolejce jest to realne
        //Przejdzmy do stack :D
        //Jest to realne bez uwzgledniania kolejnosc
        //zwrocmy uwage
        Stack deletedstack = new Stack ();
        for( int i = 0;i < 3;i++) deletedstack.Push(test.Pop()); //0,1,2,3 -> 0,1,2,3
        test.Pop();
        for (int i = 0; i < 3; i++) test.Push(deletedstack.Pop());
        Console.WriteLine("Stack: po usunieciu");
        foreach (var item in test)
        {
            Console.WriteLine(item);
        }
        //Przejdmy do Sortowany Zbior
        sortowana.Remove(67);
        Console.WriteLine("Sortowany Zbiór: (int) po usunieciu");
        foreach (int k in sortowana)
        {
            Console.WriteLine(k);
        }


    }
    static void Licz()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("watek1:{0}", i);
        }
    }
    static void Main()
    {
        grakarta();
        collections();
        //Thread thr = new Thread(Licz);
        //thr.Start();
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Program1:{0}", i);
        }
        Console.WriteLine("\n");
        ListDictionary liczby = new ListDictionary();
        liczby.Add(1, "I");
        liczby.Add(2, "II");
        liczby.Add(3, "III");
        Console.WriteLine(liczby[1]);

    }
}
