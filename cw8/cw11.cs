using System.Text.Json;
using System.Text.Unicode;

public class Transakcja
{
    public Transakcja()
    {

    }
    private string[] Typytranskacji = { "Przelew", "Wypłata z bankomatu", "Płatność kartą" };
    public string Nadawca { get; set; }
    public string Odbiorca { get; set; }
    public string Tytul { get; set; }
    public decimal Kwota { get; set; }
    public DateTime Data { get; set; }
    public decimal Saldopoczatkowe { get; set; }
    public decimal Saldokoncowe { get; set; }
    public string Typtransakcji { get; set; }

    public Transakcja(Konto Nadawca, Konto Odbiorca, string Tytul, DateTime Data, decimal Kwota, decimal Saldopoczatkowe, decimal Saldokoncowe, int Typtransakcji)
    {
        this.Nadawca = Nadawca.getowner();
        this.Odbiorca = Odbiorca.getowner();
        this.Tytul = Tytul;
        this.Data = Data;
        this.Kwota = Kwota;
        this.Saldopoczatkowe = Saldopoczatkowe;
        this.Saldokoncowe = Saldokoncowe;
        this.Typtransakcji = Typytranskacji[Typtransakcji];
    }
    public void showinfo()
    {
        Console.WriteLine("Nadawca: {0}\nOdbiorca: {1}\nKwota:{2}zł\nTytuł:{3}\nSaldo początkowe: {4}zł\nSaldo Końcowe: {5}zł\nTyp Transakcji:{6}\nData:{7}\n", Nadawca, Odbiorca, Kwota, Tytul, Saldopoczatkowe, Saldokoncowe, Typtransakcji, Data);
    }

}

[Serializable]

public class Konto
{
    public decimal stankonta;
    public List<Transakcja> historia { get; set; }

    public Konto(decimal wplatafirst = 0)
    {
        this.stankonta = wplatafirst;
        this.historia = new List<Transakcja>();
    }

    public bool przelew(Konto konto2, string tytul, decimal kwota)
    {
        if (this.stankonta < kwota)
        {
            Console.WriteLine("Za mało środków do zrealizowania przelewu");
            return false;
        }
        else
        {
            this.historia.Add(new Transakcja(this, konto2, tytul, DateTime.Now, -kwota, this.stankonta, this.stankonta - kwota, 0));
            konto2.historia.Add(new Transakcja(this, konto2, tytul, DateTime.Now, kwota, konto2.stankonta, konto2.stankonta + kwota, 0));
            konto2.stankonta += kwota;
            this.stankonta -= kwota;
            return true;
        }
    }
    public void wyciagzkonta()
    {
        Console.WriteLine("Wyciag dla wlasciciela {0}", this.getowner());
        foreach (Transakcja transakcja in historia)
        {
            transakcja.showinfo();
        }
        Console.WriteLine("-------------------");
    }
    public decimal stankontashow()
    {
        return this.stankonta;
    }
    virtual public string getowner()
    {
        return "null";
    }
}
[Serializable]
class KontoPrywatne : Konto
{
    public string imie;
    public string nazwisko;
    public string pesel;
    private int getnumberaftercom(int number)
    {
        return int.Parse(number.ToString()[number.ToString().Length - 1].ToString());
    }
    public KontoPrywatne() : base()
    {
        imie = "test";
    }
    private bool validatepesel(string pesel)
    {
        if (pesel.Length != 11) return false; //Czy dlugosc sie zgadza
        int[] wages = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 }; //krok nr.2 Czy suma kontrolna sie zgadza
        int sumakontrolna = 0;
        for (var i = 0; i < 10; i++)
        {

            //Console.WriteLine("{0} * {1} = {2} Konwersja:{3}", pesel[i], wages[i], int.Parse(pesel[i].ToString()) * wages[i], getnumberaftercom(int.Parse(pesel[i].ToString()) * wages[i]));
            sumakontrolna += getnumberaftercom(int.Parse(pesel[i].ToString()) * wages[i]);


        }
        sumakontrolna = getnumberaftercom(sumakontrolna);
        sumakontrolna = 10 - sumakontrolna;
        if (int.Parse(pesel[10].ToString()) != sumakontrolna) return false; //suma kontrolna sie nie zgadza :) (ostatnia cyfra)
        // dalej mozna sprawdzac pesel ale powiedzmy na potrzeby tego programu wystarczy, nalezalo by sprawdzic czy data jest prawdziwa i czy data nie odnosi sie do przyszlosci!

        return true;
    }
    public KontoPrywatne(string imie, string nazwisko, string pesel, decimal pierwszawplata = 0) : base(pierwszawplata)
    {
        if (!validatepesel(pesel))
        {
            throw new ArgumentException("Numer PESEL jest nieprawidłowy");
        }
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.pesel = pesel;
    }
    override public string getowner()
    {
        return imie + " " + nazwisko;
    }



}
[Serializable]
class KontoFirmowe : KontoPrywatne
{
    public string nip;
    public string nazwafirmy;
    public KontoFirmowe()
    {

    }
    public KontoFirmowe(string imie, string nazwisko, string pesel, string nip, string nazwafirmy, decimal pierwszawplata = 0) : base(imie, nazwisko, pesel, pierwszawplata)
    {
        this.nip = nip;
        this.nazwafirmy = nazwafirmy;
    }

    override public string getowner()
    {
        return nazwafirmy;
    }

}

class Program
{
    static void runwithdata()
    {
        var options = new JsonSerializerOptions { IncludeFields = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(UnicodeRanges.All) };
        KontoPrywatne konto1 = JsonSerializer.Deserialize<KontoPrywatne>(File.ReadAllText("konto1.json"),options);
        KontoPrywatne konto2 = JsonSerializer.Deserialize<KontoPrywatne>(File.ReadAllText("konto2.json"), options);
        KontoFirmowe kontozus = JsonSerializer.Deserialize<KontoFirmowe>(File.ReadAllText("kontozus.json"), options);
        KontoFirmowe kontomichelin = JsonSerializer.Deserialize<KontoFirmowe>(File.ReadAllText("kontomichelin.json"), options);
        konto2.przelew(konto1, "Przelew za paliwo", 20);
        konto2.przelew(konto1, "Przelew za Kebaba", 0.20m);
        kontozus.przelew(konto2, "800+", 800);
        kontomichelin.przelew(konto1, "Wynagrodzenie z tytulu pracy", 4500);
        konto1.wyciagzkonta();
        konto2.wyciagzkonta();
        kontomichelin.wyciagzkonta();

        File.WriteAllText("konto1.json", JsonSerializer.Serialize(konto1, options));
        File.WriteAllText("konto2.json", JsonSerializer.Serialize(konto2, options));
        File.WriteAllText("kontozus.json", JsonSerializer.Serialize(kontozus, options));
        File.WriteAllText("kontomichelin.json", JsonSerializer.Serialize(kontomichelin, options));
    }
    static void Main(string[] args)
    {
        if (!File.Exists("konto1.json"))
        {
            KontoPrywatne konto1 = new("Tutek", "Marzec", "05270725749", 190);
            KontoPrywatne konto2 = new("Papek", "Marzec", "96051273319", 200);
            KontoFirmowe kontozus = new("Panstwo", "Polskie", "05270725749", "7623389344", "Zus", 99999999);
            KontoFirmowe kontomichelin = new("-", "-", "19260469955", "1241641793", "Michelin", 90804562);
            konto2.przelew(konto1, "Przelew za paliwo", 20);
            konto2.przelew(konto1, "Przelew za Kebaba", 0.20m);
            kontozus.przelew(konto2, "800+", 800);
            kontomichelin.przelew(konto1, "Wynagrodzenie z tytulu pracy", 4500);
            konto1.wyciagzkonta();
            konto2.wyciagzkonta();
            kontomichelin.wyciagzkonta();

            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(UnicodeRanges.All),
                IncludeFields = true
            };

            File.WriteAllText("konto1.json", JsonSerializer.Serialize(konto1, options));
            File.WriteAllText("konto2.json", JsonSerializer.Serialize(konto2, options));
            File.WriteAllText("kontozus.json", JsonSerializer.Serialize(kontozus, options));
            File.WriteAllText("kontomichelin.json", JsonSerializer.Serialize(kontomichelin, options));

        }
        else
        {
            runwithdata();
        }
    }
}
