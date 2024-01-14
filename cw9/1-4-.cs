using System.Runtime.Serialization;

class wyjatektutka : System.Exception
{

    public wyjatektutka() : base()
    {
    }

    public wyjatektutka(string message) : base(message)
    {

    }
    public wyjatektutka(string message, Exception inner) : base(message, inner)
    {

    }
    public wyjatektutka(SerializationInfo info, StreamingContext context) : base(info, context) { }


}

class Program
{
    static void metoda23()
    {
        throw new NotImplementedException();
    }
    static void Main()
    {
        try
        {
            int test = 1;
            int test2 = 0;
            Console.WriteLine(test / test2);
        }
        catch
        {
            Console.WriteLine("Erorr");
        }
        finally
        {
            Console.WriteLine("FINNALY");
        }
        try
        {
            metoda23();
        }
        catch
        {
           
        }

    }
    //StackOverFlowException - Przepełnienie stosu zakresu np int wielka liczba
    //NullReferenceException - Odwołanie sie do Nulla
    //FileNotFoundException - Odwolanie sie do pliku, który nie istnieje badz zla lokalizacja
    //AccessViolationException - Dostęp do pamieci nielegalny lub operacje ktore naruszaja integralnosc
    //IndexOutOfRangeException - Odwolanie sie do tablicy, poza jej zakresem

}
