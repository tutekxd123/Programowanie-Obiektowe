class Obliczenia
{
    static public double Dodawanie(double x, double y)
    {
        try
        {
            return x + y;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }
    static public double Odejmywanie(double x,double y)
    {
        try
        {
            return x - y;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }
    static public double Mnożenie(double x, double y)
    {
        try
        {
            return x * y;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }
    static public double potęgowanie(double x, double y)
    {
        try
        {
            return Math.Pow(x, y);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }
    static public double Pierwiastkowanie(double x,double y = 2)
    {
        try
        {
            return Math.Pow(x, 1 / y);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }
    static public double Dzielenie(double x,double y)
    {
        try
        {
            return x / y;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }

    }
}
class Program
{
    static public void Main()
    {
        Console.WriteLine("Mnozenie(2*3): " + Obliczenia.Mnożenie(2, 3));
        Console.WriteLine("Pierwiastek trzeciego stopnia z 9: " + Obliczenia.Pierwiastkowanie(9,3));
        Console.WriteLine("Pierwiastek z 2: " + Obliczenia.Pierwiastkowanie(2));
        Console.WriteLine("Dodawnaie(2.5+2.5): " + Obliczenia.Dodawanie(2.5,2.5));
        Console.WriteLine("Dzielenie 2/0: " + Obliczenia.Dzielenie(2,0));
    }
}
