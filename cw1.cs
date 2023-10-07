namespace ConsoleApp3
{
    internal class Program
    {
        static double task21(double value)
        {
            return Math.Round(32+(1.8*value),3);
        }
        static double task22(double a,double b,double c)
        {
            return (b * b) - 4 * a * c;
        }
        static double task23(double waga,double wzrost)
        {
            return (waga / (wzrost * wzrost)) * 100; //bmi
        }
        static void task24() //Odpowiedz A (poniewaz ++x dodaje x=x+1 czyli 101*2 = 202)
        {
            int x = 100;
            Console.WriteLine(++x * 2);
        }
        static void task25() // Odpowiedz D, bo najpierw wykona sie y*2 a potem x* 6
        {
            int x = 2, y = 3;
            x *= y * 2;
            Console.WriteLine(x);
        }
        static void task26()
        {
            int x, y = 4;
            x = (y -= 2);//x=2 y=2
            x = y++; //x=2 y=3
            x = y--; //x=3 y=2
            Console.WriteLine("X: "+x +" Y:"+y);
        }
        static void task27()
        {
            int x, y = 5; //x=0 y=5
            x = ++y * 2;//x =12 y=6
            x = y++; //x = 6 y=7
            x = y--; // x=7 y=6
           Console.WriteLine("X: "+x +" Y: " + ++y); // x=7 y=7
        }
        static void task28()
        {
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1); // x=true,y=1,z=2
            Console.WriteLine("X: "+x+" Y: "+y+" Z: "+z);
        }
        static void task29()
        {
            /*
            metoda na szybko to poprostu powiem
            Punkt A)
            wynik = false x=2,y=5,z=1
            Punkt B)
            wynik = false, x=2,y=5,z=1
            Punkt C)
            wynik= false?, x=2 y==5, z=1
            Punkt D)
            wynik = true , x=1 y=4,z=5
            Punkt E)
            wynik = true , x=1 y=4 z=4
            Punkt f)
            wynik = true x=1 y=4 z=5
            */

        }
        static void task210()
        {
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = Convert.ToDouble(osoby) / Convert.ToDouble(powierzchnia);
            Console.WriteLine(gestoscZaludnienia); // Wyjdzie 0 poniewaz dzielimy inta przez INTA wystarczy conversja
        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Podaj stopnie w C: ");
            var test = Convert.ToDouble(Console.ReadLine());
            double[] delta = {0,0,0};
            test = task21(test);
            Console.WriteLine("F: "+test);
            Console.WriteLine("Podaj współczynik a:");
            delta[0]=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współczynik b:");
            delta[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współczynik c:");
            delta[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Delta: " + task22(delta[0], delta[1], delta[2]));
            Console.WriteLine("Podaj swoj wzrost(cm) do BMI: ");
            double wzrost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj swoja wage do BMI: ");
            double waga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("TWOJE BMI: " + task23(waga, wzrost));
            */
            task24();
            task25();
            task26();
            task27();
            task28();
            task29();
            task210();
        }
    }
}