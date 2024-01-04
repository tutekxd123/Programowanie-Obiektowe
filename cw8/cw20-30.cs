
interface IClonable
{

}
class Test : IClonable
{
    public int liczba;
    public Test2 poleTestowe;
    public Test()
    {
        poleTestowe = new Test2();
    }
    public Object Clone()
    {
        return MemberwiseClone();
    }
    public Test GlebokaKopia()
    {
        Test tempTest = new Test();
        tempTest.liczba = this.liczba;
        tempTest.poleTestowe.słowo = this.poleTestowe.słowo;
        return tempTest;

    }
}
class Test2
{
    public string słowo;
}
//----------------------------
interface IInfoabout
{
    public void JakSiePoruszam();
    public void CoJem();

}
class Zwierze : IInfoabout
{
    public void JakSiePoruszam()
    {
        Console.WriteLine("Nie wiem");
    }
    public void CoJem()
    {
        Console.WriteLine("Nie wiem");
    }
}
class Pies: Zwierze
{
    public string Imie;
    public int Waga;
    public string Rozmiar;
    public new void CoJem()
    {
        Console.WriteLine("Jem Kości");
    }
    public new void JakSiePoruszam()
    {
        Console.WriteLine("Poruszam sie na czterech łapach");
    }
    public Pies(string imie, int waga, string Rozmiar)
    {
        this.Imie = imie;
        this.Waga = waga;
        this.Rozmiar = Rozmiar;
    }
}
class Wilk : Zwierze
{
    public string Imie;
    public int Waga;
    public string Rozmiar;
    public new void CoJem()
    {
        Console.WriteLine("Jem Kości i mięso");
    }
    public new void JakSiePoruszam()
    {
        Console.WriteLine("Poruszam sie na czterech łapach");
    }
    public Wilk(string imie, int waga, string Rozmiar)
    {
        this.Imie = imie;
        this.Waga = waga;
        this.Rozmiar = Rozmiar;
    }
}
class Rekin: Zwierze
{
    public string Imie;
    public int Waga;
    public string Rozmiar;
    public new void CoJem()
    {
        Console.WriteLine("Jem Ryby");
    }
    public new void JakSiePoruszam()
    {
        Console.WriteLine("Pływam w morzu");
    }
    public Rekin(string imie, int waga, string Rozmiar)
    {
        this.Imie = imie;
        this.Waga = waga;
        this.Rozmiar = Rozmiar;
    }
}
class Orzel : Zwierze
{
    public string Imie;
    public int Waga;
    public string Rozmiar;
    public new void CoJem()
    {
        Console.WriteLine("Jem mała zwierzyne");
    }
    public new void JakSiePoruszam()
    {
        Console.WriteLine("Latam za pomocą skrzydeł");
    }
    public Orzel(string imie, int waga, string Rozmiar)
    {
        this.Imie = imie;
        this.Waga = waga;
        this.Rozmiar = Rozmiar;
    }
}
class Krokodyl : Zwierze
{

    public string Imie;
    public int Waga;
    public string Rozmiar;
    public new void CoJem()
    {
        Console.WriteLine("Jem Ryby,Ptaki");
    }
    public new void JakSiePoruszam()
    {
        Console.WriteLine("Pływam w bajorach :D"); //XD
    }
    public Krokodyl(string imie,int waga,string Rozmiar)
    {
        this.Imie = imie;
        this.Waga = waga;
        this.Rozmiar = Rozmiar;
    }
}
//-------------------------------
interface Figury
{
    public double LiczObwod();
    public void PobierzDaneZklawiatury();
    public void Wyswietl();
};
class Punkt : IClonable, Figury
{
    public string nazwa;
    public double x;
    public double y;
    public Punkt(double x, double y) {this.x = x; this.y = y;}
    public Punkt() {x = 0; y = 0;}
    public Object Clone()
    {
        return MemberwiseClone();
    }
    public double LiczObwod() { return 0; }
    public void PobierzDaneZklawiatury()
    {
        Console.Write("Podaj X: ");
        this.x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj Y: ");
        this.y = Convert.ToDouble(Console.ReadLine());
    }
    public void Wyswietl()
    {
        Console.WriteLine("--Punkt--");
        Console.WriteLine("Punkt x:{0} y:{1}", this.x, this.y);
        Console.WriteLine("---------");
    }
    public override string ToString()
    {
        return string.Format("x: {0}, y:{1}", this.x, this.y);
    }


}

class Kolo : IClonable,Figury
{
    public string nazwa;
    public Punkt Srodek;
    public double r;
    public Kolo()
    {
        this.Srodek = new();
        this.r = 1;
    }
    public Kolo(Punkt srodek, double r)
    {
        Srodek = srodek;
        this.r = r;
    }
    public Object Clone()
    {
        Kolo kolo = new Kolo();
        kolo.Srodek = (Punkt)this.Srodek.Clone();
        kolo.r = this.r;
        return kolo;
    }
    public void Wyswietl()
    {
        Console.Write("------Koło------\nSrodek znajduje się na:\n");
        Srodek.Wyswietl();
        Console.Write("r: {0}\n",this.r);
        Console.WriteLine("----------------");
    }
    public void PobierzDaneZklawiatury()
    {
        Console.WriteLine("Definicja srodku koła");
        Srodek.PobierzDaneZklawiatury();
        Console.Write("Podaj promień: ");
        this.r = Convert.ToDouble(Console.ReadLine());
    }
    public double LiczObwod()
    {
        return (2 * this.r * Math.PI);
    }
    public override string ToString()
    {
        return string.Format("s({0},{1}) r:{2}", this.Srodek.x, this.Srodek.y, this.r);
    }
}
class Kwadrat : IClonable, Figury //zdaje sobie sprawe, że jest to słabe bo użytkownik moze podac linie prosta :)
{
    public string nazwa;
    public Punkt x1;
    public Punkt x2; //wlasciwie mozna by podac 2 punkty dla lini prostych i odbijac je zeby tworzyc te kwadraty
    public Punkt x3;
    public Punkt x4;
    public Kwadrat()
    {
        this.x1 = new();
        this.x2=new();
        this.x3=new();
        this.x4=new();
    }
    public Kwadrat(Punkt x1, Punkt x2, Punkt x3, Punkt x4)
    {
        this.x1 = x1;
        this.x2 = x2;
        this.x3 = x3;
        this.x4 = x4;
    }
    public Object Clone()
    {
        Kwadrat kwadrat = new Kwadrat();
        kwadrat.x1 = (Punkt)this.x1.Clone();
        kwadrat.x2 = (Punkt)this.x2.Clone();
        kwadrat.x3 = (Punkt)this.x3.Clone();
        kwadrat.x4 = (Punkt)this.x4.Clone();
        return kwadrat;
    }
    public void Wyswietl()
    {
        Console.WriteLine("Punkty dla kwadratu");
        this.x1.Wyswietl();
        this.x2.Wyswietl();
        this.x3.Wyswietl();
        this.x4.Wyswietl();
        Console.WriteLine("--------------------");
    }
    public void PobierzDaneZklawiatury()
    {
        Console.WriteLine("Zdefinuj 4 punkty dla kwadratu");
        this.x1.PobierzDaneZklawiatury();
        this.x2.PobierzDaneZklawiatury();
        this.x3.PobierzDaneZklawiatury();
        this.x4.PobierzDaneZklawiatury();
        //mozna by sprawdzac czy to kwadrat
    }
    public double LiczObwod()
    {
        return 4*(Math.Sqrt(Math.Pow(this.x1.x-this.x2.x,2)+Math.Pow(this.x1.y-this.x2.y,2))); //(Math.abs(x1-x2) + Math.abs(y1-y2))
    }
    public override string ToString()
    {
        return string.Format("x1:{0} y1:{1} x2:{2} y2:{3} x3:{4} y3:{5} x4:{6} y5:{7}", this.x1.x, this.x1.y, this.x2.x, this.x2.y, this.x3.x, this.x3.y, this.x4.x, this.x4.y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Test obiekt1 = new Test(); //zakladam ze bedzie tak obiekt1=347,obiekt2=347,obiekt3=255 tak :)
        Test obiekt2 = new Test();
        Test obiekt3 = new Test();
        obiekt1.liczba = 255;
        obiekt1.poleTestowe.słowo = "słowo";
        obiekt2 = obiekt1;
        obiekt3 = obiekt1.GlebokaKopia();
        obiekt1.liczba = 347;
        obiekt1.poleTestowe.słowo = "kaczka"; //Tutaj nie zrobi sie klonowanie zapewne :) bo klonowe tamto pewnie na glebokosci 1?
        Console.WriteLine("1:{0} 2:{1} 3:{2}",obiekt1.liczba,obiekt2.liczba,obiekt3.liczba);
        Console.WriteLine("1:{0} 2:{1} 3:{2}", obiekt1.poleTestowe.słowo, obiekt2.poleTestowe.słowo, obiekt3.poleTestowe.słowo); //zgodnie z przewidywaniami
        Pies pies1 = new("Pipek", 50, "xxl");Pies pies2 = new("reksiu", 32, "m");
        Wilk wilk1 = new("niewiem", 37, "s"); Wilk wilk2 = new("krol", 65, "xl");
        Rekin rekin1 = new("alex", 46, "s");Rekin rekin2 = new("Malus", 300, "xxl");
        Orzel orzel1 = new("Aloy", 10, "m");Orzel orzel2 = new("tutus", 7, "m");
        Krokodyl krokodyl1 = new("marti",40,"s");Krokodyl krokodyl2 = new("Gloria", 63, "m");
        //Nie była by potrzebna metoda glebokiej kopii
        //Copy() płytka metoda moze byc tylko w klasie rodzica, w przypadku kopii głębokiej w kazdej
        //Oszdzedze moze pisania z klawiatury :)
        Kwadrat kwadrat1 = new(new(0, 0), new(0, 5), new(5, 0), new(5, 5));
        Kolo kolo1 = new(new(0, 0), 5);
        Punkt punkt1 = new(0, 10);
        Console.WriteLine("Gotowe figury: ");
        kwadrat1.Wyswietl();
        Console.Write('\n');
        kolo1.Wyswietl();
        Console.Write('\n');
        punkt1.Wyswietl();
        Console.WriteLine("Obwód kwadratu kwadratu: {0}\nObwod kola:{1}\nObwod Punktu:{2}", kwadrat1.LiczObwod(), kolo1.LiczObwod(), punkt1.LiczObwod());

    }
}
