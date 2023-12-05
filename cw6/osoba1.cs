using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Osoba
{
    public string imie;
    public string nazwisko;
    internal int rokUrodzenia;
    protected int waga;
    private int wzrost;
    public bool okulary;
    public enum plecenum { K,M }
    public plecenum plec;
    public int obliczWiek()
    {
        return DateTime.Now.Year - this.rokUrodzenia;
    }
    public Osoba(string imie, string nazwisko, int rokUrodzenia, int waga, int wzrost, bool okulary,plecenum plec)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.rokUrodzenia = rokUrodzenia;
        this.waga = waga;
        this.wzrost = wzrost;
        this.okulary = okulary;
        this.plec = plec;
    }
    public string przedrostek()
    {
        if (this.plec == Osoba.plecenum.K) return "Pani";
        else return "Pan";
    }
}
