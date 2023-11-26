using System.Numerics;

class Program
{
    static double convertemp(double x)
    {
        return (x - 32) * (Convert.ToDouble(5) / Convert.ToDouble(9));
    }
    static bool checknumber(int a, int b, int x)
    {
        return x > a && x < b;
    }
    static void przesun(double[] test,ref double x,ref double y)
    {
        test[0] = test[0] + x;
        test[1] = test[1] + x;
    }
    static int[] mnozenieskalar2(int[] test,int scalar)
    {
        int[] result = new int[test.Length];
        for(int x=0;x<result.Length;x++) result[x] = test[x]*scalar;
        return result;
    }
    static void mnozenieskalar(int[] test,int scalar)
    {
        for (int i = 0; i < test.Length; i++) test[i] *= scalar;
    }
    static void rysujprostokat(int width, int height, string test)
    {
        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write(test);
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }
    static void rysujprostokat(int width,int height)
    {
        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }
    static string[] mnozenieskalar2(string[] test, int scalar)
    {
        string[] result = new string[test.Length];
        for (int x = 0; x < result.Length; x++)
        {
            for (int k = 0; k < scalar; k++) result[x] += test[x];
        }
        return result;
    }
    static void task55(int width,int height)
    {
        rysujprostokat(width, height);
        rysujprostokat(height, width);
    }
    static double wyrazenie(int x,int n)
    {
        return (((2 * Convert.ToDouble(x)) + (Convert.ToDouble(n) - 1)) / 2) * n;
    }
    static int sumacyfr(int x)
    {
        string temp = Convert.ToString(x);
        int result = 0;
        for(int k = 0; k < temp.Length; k++)
        {
           result+=Convert.ToInt32(temp[k].ToString());
        }
        return result;
    }
    static int ciagfibbocianyrek(int x)
    {
        if (x <= 1) return x;
        else return ciagfibbocianyrek(x - 1) + ciagfibbocianyrek(x - 2);
    }
    static int ciagfibbocianyfor(int x)
    {
        int a=0;
        int b = 1;
        x--;
        for(int i = 0; i < x; i++)
        {
            b = a+b;
            a = b - a;
        }
        return b;
    }
    static int Oblicz(int x)
    {
        if (x <= 1) return x;
        else return (x + Oblicz(x - 1));
    }
    static void Main()
    {
        int[] task52 = new int[3];
        double temp = convertemp(0.0);
        Console.WriteLine("Podaj a,b,x");
        task52[0] = Convert.ToInt32(Console.ReadLine());
        task52[1] = Convert.ToInt32(Console.ReadLine());
        task52[2] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(checknumber(task52[0], task52[1], task52[2]));
        double[] vector = { 3, 2 };
        double xvector = 0;
        double yvector = 0;
        Console.WriteLine("Przesuwanie vectora\n Podaj x a nastepnie y:");
        xvector = Convert.ToDouble(Console.ReadLine());
        yvector = Convert.ToDouble(Console.ReadLine());

        przesun(vector,ref xvector,ref yvector);
        Console.WriteLine("Vector po przesunieciu \n"+vector[0] + "," + vector[1]);
        Console.WriteLine("Tablica do mnozenia przez skalar: \n" + string.Join(",", task52));
        mnozenieskalar(task52,2);
        Console.WriteLine("Tablica po wymnozeniu przez skalar(2): \n" + string.Join(",",task52)+"\n Drugi wariant,że bez referencji: \n"+string.Join(",", mnozenieskalar2(task52, 2)));
        task55(5,10);
        string[] test = { "ala", "ma" };
        test = mnozenieskalar2(test, 3);
        Console.WriteLine(string.Join(",", test));
        Console.WriteLine("Obliczanie wyrazenia (x+1)+(x+2)..(x+n)");
        Console.WriteLine("Podaj x i y: ");
        Console.WriteLine("Wynik to: " + wyrazenie(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
        Console.WriteLine("Suma Cyfr\nPodaj x: ");
        Console.WriteLine("Suma wynosi: " + sumacyfr(Convert.ToInt32(Console.ReadLine())));
        Console.WriteLine(ciagfibbocianyfor(7));

        //w zadaniu bedzie ciag 5+4+3+2+1
        Console.WriteLine(Oblicz(5));
    }
}
