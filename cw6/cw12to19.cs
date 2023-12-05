using System.ComponentModel.Design;
class Zespolone
{
    public int a;
    public int b;

    public Zespolone(int a,int b=0) {
        this.a = a;
        this.b = b;
    }
    public void Dodawanie(Zespolone other)
    {
        this.a += other.a;
        this.b += other.b;
    }
    public void Odejmywanie(Zespolone other)
    {
        this.a = this.a - other.a;
        this.b = this.b -  other.b;
    }
    public void mnozenie(Zespolone other)
    {
        this.a = this.a * other.a;
        this.b = this.b * other.b;
    }
    public Zespolone sprzezenie()
    {
        return new Zespolone (this.a,-1*this.b);
    }
    public double modul()
    {
        return Math.Sqrt(Math.Pow(Convert.ToDouble(this.a),2) +  Math.Pow(Convert.ToDouble(this.b),2));
    }
    public void show()
    {
        Console.WriteLine("A: {0} B:{1}", this.a, this.b);
    }

}


class koszyk
{
    public List<product> Towary = new List<product>();
    public void additem(product product)
    {
        Towary.Add(product);
    }
    public double sumcena()
    {
        double suma = 0;
        for(int i=0;i<Towary.Count; i++)
        {
            suma += Towary[i].cena;
        }
        return suma;
    }
    public void podsumowanie()
    {
        Console.WriteLine("Ilosc towarów:{0} Cena: {1}", Towary.Count, sumcena());
    }
    public koszyk()
    {
        this.Towary = new List<product>();
    }
}
class product
{
    public string Nazwa;
    public double cena;
    public product(string nazwa,double cena) {
        this.Nazwa = nazwa;
        this.cena = cena;
    }
}

class pacjent
{
    public string imie;
    public string name;
    public int wzrost;
    public int waga;
    public string BMI()
    {
        double bmi = Convert.ToDouble(waga) / (Math.Pow((Convert.ToDouble(wzrost)/100),2));
        Console.WriteLine(bmi);
        if (bmi < 18.5) return "Niedowaga";
        else if (bmi >= 18.5 && bmi < 25) return "Prawidlowa waga";
        else if (bmi >= 25) return "nadwaga";

        return "ERROR";
    }
    public pacjent(string imie, string name, int wzrost, int waga)
    {
        this.imie = imie;
        this.name = name;
        this.wzrost = wzrost;
        this.waga = waga;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Osoba dyrektor = new("Dariusz", "Kowalski", 1997, 90,184, false,Osoba.plecenum.M);
        Console.WriteLine($"Imie: {dyrektor.imie} Nazwisko: {dyrektor.nazwisko} Wiek: {dyrektor.obliczWiek()}");
        //pkt 14 w tej chwili to nic sie nie zmienilo, bo polecenie niezbyt jasne, ale zmienia to ze ograniczony jest dostep do niektórych pól
        Console.WriteLine($"Dyrektorem jest {dyrektor.przedrostek()} {dyrektor.imie} {dyrektor.nazwisko}");
        pacjent testowy = new("Test", "test", 184, 100);
        Console.WriteLine(testowy.BMI());
        koszyk szybkiezakupy = new();
        szybkiezakupy.additem(new("Czekolada", 3.21));
        szybkiezakupy.additem(new("Zupka chinska", 3.00));
        szybkiezakupy.additem(new("GCC", 0.01));
        szybkiezakupy.podsumowanie();
        Zespolone liczba1 = new(1, 3);
        Zespolone liczba2 = new(2,8);
        liczba1.show();
        liczba1.Dodawanie(liczba2);
        liczba1.show();
        Console.WriteLine("Moduł liczby: {0}", liczba1.modul());
        liczba1.Odejmywanie(liczba2);
        liczba1.show();
        liczba1.mnozenie(liczba2);
        liczba1.show();
        liczba1.sprzezenie().show();
    }
}
