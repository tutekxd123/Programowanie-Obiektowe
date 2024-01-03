class BaseClass
{
    public int x;
    public BaseClass(int x)
    {
        this.x = x;
    }
}
class DerrivedClass : BaseClass
{
    public int y;
    public DerrivedClass(int x,int y) : base(x)
    {
        this.y = y;
    }
}
class NextDerrivedClass : DerrivedClass
{
    public int z;
    public NextDerrivedClass(int x,int y,int z): base(x,y)
    {
        this.z = z;
    }
}
class Program
{
    static void Main(string[] args)
    {
        //System.InvalidCastException: Unable to cast object of type 'BaseClass' to type 'DerrivedClass'.
        /*
        BaseClass myObj = new BaseClass();
        DerrivedClass derObj1 = (DerrivedClass)myObj;
        NextDerrivedClass NxtObj1 = (NextDerrivedClass)myObj;
        */
        // Ale da Sie rzutować w drugą strona z "wyzszej" klasy na nizszą, ponieważ te "nizsze" klasy nie maja cech "wyzszych", ale odwrotnie w pełni sie da
        NextDerrivedClass myObj = new NextDerrivedClass(3,2,1);
        DerrivedClass myObj2 = (DerrivedClass)myObj;
        BaseClass baseobj = (BaseClass)myObj;
        //Console.WriteLine(baseobj.y);
        //oczywiscie powinno to spowodować utrate danych, a wlasciwe niemoznoscia odwolania sie

    }
}
