using System.Runtime.InteropServices;

void task41()
{
    Console.WriteLine("Podaj ilosc elementow");
    var input = Convert.ToInt32(Console.ReadLine());
    int[] array= new int[input];
    for(int i = 0; i < input; i++) array[i]=Convert.ToInt32(Console.ReadLine());
    for(int i = 0;i<input;i++) Console.WriteLine(array[i]);
}
void task42()
{
    int[] tab1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] tab2 = new int[tab1.Length];
    for(int i = 0;i<tab1.Length;i++) tab2[i] = tab1[i];
}
void task43()
{
    Console.WriteLine("Podaj ilosc elementow");
    var input = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[input];
    for (int i = 0; i < input; i++) array[i] = Convert.ToInt32(Console.ReadLine());
    //mozna na dwa sposoby to zrobic
    Array.Sort(array);
    var min = array[0];
    var max = array[array.Length-1];
    float suma = 0;
    var countnumber = 0;
    for(int i = 0; i < input; i++)
    {
        if (array[i] > 0) countnumber++;
        suma += array[i];
    }
    suma = suma / input;
    Console.WriteLine("MAX ELEMENT: " + max);
    Console.WriteLine("MIN: " + min);
    Console.WriteLine("AVG: " + suma);
    Console.WriteLine("Dodatnie liczby: " + countnumber);
}
bool isprime(int number)
{
    number = Math.Abs(number); //W przypadku ujemnych
    if(number<=3) return true;
    for(int i = 4; i < number; i++) if (number % i == 0) return false;
    return true;
}
void task44()
{
   Random rand = new Random();
    int[] array = new int[100];
    for(int i = 0;i<100;i++) array[i]=rand.Next(1,1000);
    // algorytmy na sprawdzenie czy cos jest liczba pierwsza jest wiecej niz jeden
    // Najprostszy do napisania zeby sprawdzic to jest sprawdzenie wszystkich dzielnikow O(n) = n^2, ale są takze inne

    int count = 0;
    for(int i = 0;i<100 ; i++)
    {
        if (isprime(array[i])) count++;
    }
    Console.WriteLine("Liczby pierwsze: " + count);
}
void task45()
{
    int n = 100;
    int[] tab1 = new int[n];
    int[] tab2 = new int[n];
    for(int i = 0;i<n;i++) tab1[i] = i; //zapelniamy n elementowa 

    for(int i = 0; i < n; i++)
    {
        if (i == n - 1) tab2[0] = tab1[i];
        else tab2[i+1] = tab1[i];
    }

}
void task46()
{
    int[,] array = new int[5, 5];
    int suma = 0;
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            array[i, j] = i;
            Console.Write(array[i, j]+" ");
        }
        Console.Write("\n");
        suma += array[i, i];
    }
    Console.WriteLine("SUMA ELEMENTOW NA PRZEKATNEJ: " + suma);
}
void task47()
{
    int[,] tab1 = { {1,2,3},{4,5,6 } };
    int[,] tab2 = { {4,5,6 },{6,7,8 } };
    int[,] tab3= new int[2, 3];
    for(int i=0; i<2; i++)
    {
        for(int j=0; j<3; j++)
        {
            tab3[i,j] = tab1[i, j] + tab2[i,j];
            Console.Write(tab3[i,j] + " ");
        }
        Console.Write("\n");
    }
}
void task48()
{
    string[,] dniTygodnia;
    dniTygodnia = new string[7, 3];
    dniTygodnia[0, 0] = "poniedziałek";
    dniTygodnia[1, 0] = "wtorek";
    dniTygodnia[2, 0] = "środa";
    dniTygodnia[3, 0] = "czwartek";
    dniTygodnia[4, 0] = "piatek";
    dniTygodnia[5, 0] = "sobota";
    dniTygodnia[6, 0] = "niedziela";
    dniTygodnia[0, 1] = "monday";
    dniTygodnia[1, 1] = "tuesday";
    dniTygodnia[2, 1] = "wednesday";
    dniTygodnia[3, 1] = "thursday";
    dniTygodnia[4, 1] = "friday";
    dniTygodnia[5, 1] = "saturday";
    dniTygodnia[6, 1] = "sunday";

    dniTygodnia[0, 2] = "montag";
    dniTygodnia[1, 2] = "dienstag";
    dniTygodnia[2, 2] = "mittwoch";
    dniTygodnia[3, 2] = "donnerstag";
    dniTygodnia[4, 2] = "freitag";
    dniTygodnia[5, 2] = "samstag";
    dniTygodnia[6, 2] = "sonntag";
    for(int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 7; j++) Console.Write(dniTygodnia[j, i] + " ");
        Console.Write("\n");
    }
}
void task49()
{
    var input = Console.ReadLine();
    var count = input.Split(" ").Length;
    Console.WriteLine("Liczba wyrazow to: "+count);
}
void task410()
{
    var input = Console.ReadLine();
    int numberofmon = Convert.ToInt32(input.Split("-")[1]);
    //Tutaj mozna konwertowac za pomoca słownika(switch + 12 warunkow + default), ale mozna to inaczej zrobic
    var month = new DateTime(2023, numberofmon, 1).ToString("MMMM");
    Console.WriteLine(month);
}
void task411()
{
    string test = "abrakadabra";
    //Sposob na rozwiazanie tego jest kilka, mozna sortować i ucinac te wyrazy , mozna zrobic tablice obiektów ze znakami i z liczba jego wystepywania
    // Mozna tez bardziej algebraicznie zrobic to czyli nadac kazdej literze domyslny znak w tablicy i dodawac do niej liczby.
    // Ja zrobie w sposob algebraiczny
    int[] countletter = new int[27];
    for(int i=0; i < test.Length; i++)
    {
        countletter[Convert.ToInt32(test[i] - 97)]++;
    }
    for(int i=0;i < countletter.Length; i++)
    {
        if (countletter[i] != 0) Console.Write(Convert.ToChar(i + 97) + " - " + countletter[i]+" ");
    }
    Console.Write("\n");
}
void task412()
{
    string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
 "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
 "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
 "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
 "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
    Console.WriteLine(tekst);
    string[] rows = tekst.Split("\n");
    Console.WriteLine("Wystepuje: " + rows.Length + " wierszy");
    for(int i = 0; i < rows.Length; i++)  Console.WriteLine("Dla wiersza: " + (i + 1) + " Znajduje się: " + rows[i].Length + " Znaków");
}

bool checkarray(string[] array,string tester)
{
    for(var i = 0; i < array.Length; i++)
    {
        if (array[i]==tester) return true;
    }
    return false;
}
void task413()
{
    string tekst = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
    string[] words = tekst.Split(" ");
    string[] checkedwords = new string[words.Length];
    for(int i = 0; i < words.Length; i++)
    {
        if (!checkarray(checkedwords, words[i]))
        {
            int suma = 0;
            for(int j = i;j<words.Length;j++)
            {
                if (words[i] == words[j]) suma++;
            }
            checkedwords[i] = words[i];
            if (suma > 1) Console.Write(words[i] + " - " + suma + " razy, ");
        }
    }
    Console.Write('\n');
   
}
void task414()
{
    string[] items = { "KOMG-2002", "BH-2010", "PC-2023", "LABI-2007", "PEN-1997" };
    for(int i=0;i < items.Length; i++)
    {
        int year = Convert.ToInt32(items[i].Split("-")[items[i].Split("-").Length - 1]);
        Console.WriteLine("Mineło od zakupu: "+Convert.ToString(Convert.ToInt32(DateTime.Now.ToString("yyy"))-year) + "lat Dla przedmiotu: " + items[i]);
    }
}
task414();
