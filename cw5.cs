using System.Data;

struct KandytatNaStudia
{
    public string nazwisko;
    int punktyMatematyka;
    int punktyInformatyka;
    int punktyJezykObcy;
    public KandytatNaStudia(string n,int a,int b,int c)
    {
        this.nazwisko = n;
        this.punktyMatematyka = a;
        this.punktyInformatyka = b;
        this.punktyJezykObcy = c;
    }
    public double calcpoints()
    {
        return (0.6 * punktyMatematyka) + (0.5*punktyInformatyka) + (0.2*punktyJezykObcy);
    }
    //normalnie metody bym zrobil ale w zadaniu nie ma ;(
}


class Prostopadloscian
{
    float dlugosc;
    float szerokosc;
    float wysokosc;
    public Prostopadloscian(int x,int y,int z)
    {
        this.dlugosc = x;
        this.szerokosc = y;
        this.wysokosc = z;
    }
    public float objetosc()
    {
        return dlugosc * szerokosc * wysokosc;
    }
    public bool porownaj(Prostopadloscian drugi)
    {
        //jezeli tru to znaczy ze to wieksze
        return this.objetosc() > drugi.objetosc();
    }
}

class Odcinek
{
    Punkt punkt1, punkt2;
    public Odcinek(Punkt punkt1, Punkt punkt2)
    {
        this.punkt1 = punkt1;
        this.punkt2 = punkt2;
    }   
    public float getlength()
    {

        return MathF.Abs(this.punkt2.x-this.punkt1.x)+ MathF.Abs(this.punkt2.y - this.punkt1.y);
    }
}
class Punkt
{
    public float x {set;get;}
    public float y { set; get; }
    public Punkt(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public void Przesun(int x=0,int y=0)
    {
        this.x += x;
        this.y += y;
    }
    public void Wyswietl()
    {
        Console.WriteLine("X: {0} Y:{0}", this.x, this.y);
    }
}
class licznikpradu
{
    private int rejestracjazuzycia;
    public int obecnezuzycie;
    public int zuzytaenergia()
    {
        return rejestracjazuzycia - obecnezuzycie;
    }
    public void informacje()
    {
        Console.WriteLine("Startowe zuzycie: {0}\nObecne zuzycie:{1}\nZuzyta energia: {2}", rejestracjazuzycia, obecnezuzycie, zuzytaenergia());
    }

}

struct prostokat2
{
    private int dlugosc;
    private int szerokosc;
    public prostokat2(int dlugosc, int szerokosc)
    {
        this.dlugosc = dlugosc;
        this.szerokosc = szerokosc;
    }
    int powierzchnia()
    {
        return dlugosc * szerokosc;
    }
    private int obwod()
    {
        return (2 * dlugosc) + (2 * szerokosc);
    }
    public void prezentuj()
    {
        Console.WriteLine("Długość: " + this.dlugosc + "\nSzerokość: " + this.szerokosc + "\n Obwód: " + obwod() + "\npowierzchnia: " + powierzchnia());
    }
}


class prostokat
{
    private int dlugosc;
    private int szerokosc;
    public prostokat(int dlugosc,int szerokosc)
    {
        this.dlugosc = dlugosc;
        this.szerokosc = szerokosc;
    }
    public int powierzchnia()
    {
        return dlugosc * szerokosc;
    }
    private int obwod()
    {
        return (2 * dlugosc) + (2 * szerokosc);
    }
    public void prezentuj()
    {
        Console.WriteLine("Długość: " + this.dlugosc + "\nSzerokość: "+this.szerokosc+"\n Obwód: "+obwod()+"\npowierzchnia: "+powierzchnia());
    }
}

class Program
{
    static bool checkonline(Punkt[] punkty)
    {
        if (punkty.Length < 3) return false;
        float deltax = MathF.Abs(punkty[0].x - punkty[1].x);
        float deltay = MathF.Abs(punkty[0].y - punkty[1].y);
        float nachylenie = deltay / deltax;
        deltax = MathF.Abs(punkty[1].x - punkty[2].x);
        deltay = MathF.Abs(punkty[1].y - punkty[2].y);

        return nachylenie == (deltay / deltax);
        // Prosta: ax+b zdabadzmy samo równanie a i b i porównac :)

    }
    static void Main()
    {
        prostokat test = new(3, 2);
        test.prezentuj();
        prostokat[] test2 = {new(3,2),new(4,2),new(7,9),new(4,3)};
        foreach(prostokat p in test2)
        {
            p.prezentuj();
        }
        int powierzchnia = test2[0].powierzchnia();
        foreach(prostokat p in test2)
        {
            if (powierzchnia < p.powierzchnia())
            {
                powierzchnia = p.powierzchnia();
            }
        }
        Console.WriteLine("Powierzchnia najwiekszego prostokata to: {0}", powierzchnia);
        Punkt[] punkciki = { new(1, 1),new(2,2),new(3,3) };
        Console.WriteLine(checkonline(punkciki));
        prostokat2 nowyprostokat = new(3,2);
        prostokat2[] noweprostokaty = { new(3, 2), new(4, 2), new(7, 9), new(4, 3) };
        foreach (prostokat2 p in noweprostokaty)
        {
            p.prezentuj();
        }
        Console.Write('\n');
        KandytatNaStudia[] testowy = { new("Marzec", 1, 20, 30),new("Marzec",20,30,40),new("Kowalski",10,30,60),new("Gralis",20,5,30)};
        foreach(KandytatNaStudia student in testowy)
        {
            Console.WriteLine("{0} {1}", student.nazwisko, student.calcpoints());
        }

    }
}
