using System;

class Osoba
{
    public string imie;
    public string nazwisko;
    public int rok_urodzenia;
    private string miejsceZamieszkania;
    public Osoba(string imie, string nazwisko, int rok_urodzenia, string miejsceZamieszkania)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.rok_urodzenia = rok_urodzenia;
        this.miejsceZamieszkania = miejsceZamieszkania;
    }

    public void WypiszInfo()
    {
        Console.WriteLine("Imie: {0}\nNazwisko: {1}\nRok Urodzenia: {2}", this.imie, this.nazwisko, this.rok_urodzenia);
    }
    public int ObliczWiek()
    {
        return DateTime.Now.Year - rok_urodzenia;
    }
}

class Student : Osoba
{
    public int rok;
    public int numerGrupy;
    public int numerAlbumu;

    public Student(string imie, string nazwisko, int rok_urodzenia, int rok, int numerGrupy, int numerAlbumu,string miejscezamieszkania): base(imie, nazwisko, rok_urodzenia,miejscezamieszkania)
    {
        this.rok = rok;
        this.numerGrupy = numerGrupy;
        this.numerAlbumu = numerAlbumu;
    }
}
class StudentPierwszegoRoku : Student
{
    public StudentPierwszegoRoku(string imie, string nazwisko, int rok_urodzenia, int rok, int numerGrupy, int numerAlbumu, string miejscezamieszkania) : base(imie, nazwisko, rok_urodzenia,rok,numerGrupy,numerAlbumu,miejscezamieszkania)
    {

    }
}
class Program
{
    static void Main(string[] args)
    {
        // Przykład użycia:
        Student student1 = new Student("John", "Doe", 1990, 2, 101, 12345,"Olsztyn");
        Student student2 = new Student("Piotr", "Marzec", 2000, 2, 1, 100731, "Warszawa");
        Osoba osoba1 = new Osoba("Roman", "Kwiatkowski", 1987, "Olimp");
        Osoba osoba2 = new Osoba("Czeladnik", "Marianowski", 1992, "Grodziask");
        osoba2 = student1;
        // student2 = (Student)osoba2; //Nie mozna jawnie konwersji zrobiic?(ze wzgledu na brakujace informacje?)
        osoba2.WypiszInfo();

    }
}
