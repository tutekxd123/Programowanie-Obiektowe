using System;
interface IGitarzysta
{
    public void Graj();
}
interface ISkrzypek
{
    public void Graj();
}

class Osoba : IGitarzysta, ISkrzypek
{
    public void Graj()
    {
        Console.WriteLine("Gram ale nie wiem na czym");
    }
    void IGitarzysta.Graj()
    {
        Console.WriteLine("Gram na gitarze");
    }
    void ISkrzypek.Graj()
    {
        Console.WriteLine("Gram na skrzypcach");
    }

}
