class Program
{
    static void Main()
    {
        try
        {
            int liczba1;
            //liczba1 = 30 / 0; to sie nie uda,bo bedzie ze wykryto dzielenie przez 0 ale da sie inaczej
            int liczba2 = 0;
            liczba1 = 30 / liczba2;
            Console.WriteLine("TRY");
            //kod sie skompiluje i spróbuje sie wykonac ale wystapi wyjatek
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }
        finally
        {
            Console.WriteLine("FINALLY");
        }
        //CAtch wykona sie tylko w przypadku bledu, finally zawsze
        int[] table = new int[2];
        try
        {
            table[1] = 2;
            throw new IndexOutOfRangeException();
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("Liczba poza wykresem");
        }
        catch
        {
            Console.WriteLine("Jakis tam blad");
        }
    }
}
