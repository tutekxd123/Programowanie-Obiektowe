using System;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp3
{
    internal class Program
    {
        static void task31()
        {
            Console.WriteLine("Podaj rok: ");
            var year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 || year % 400 == 0) && year % 100 != 0) Console.WriteLine("Rok jest przestępny");
            else Console.WriteLine("Rok nie jest przestępny");
        }
        static void task32()
        {
            Console.WriteLine("Podaj liczbe1: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe2: ");
            var number2 = Convert.ToInt32(Console.ReadLine());
            if (number2 % number1 == 0) Console.WriteLine("Liczba nr.2 jest dzielnikiem liczby nr.1");
            else Console.WriteLine("Liczba nr.2 nie jest dzielnikiem liczby nr.1");
        }
        static void task33()
        {
            int[] array= {0,0,0};
            for(var i = 0; i < 3; i++)
            {
                Console.WriteLine("Podaj liczbe nr." + i+1);
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            //Mozna zastosowac algorytm sortowania lub same ify lub jakas gotowa funkcje do sortowania
            Array.Sort(array); //Rozwiazanie sortowaniem
            Console.WriteLine(array[2]);
        }
        static void task34()
        {
            Console.WriteLine("Podaj liczbe nr.1");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe nr.2");
            var number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj znak operacji +,-,*,/");
            var operation = Console.ReadLine(); //Normalnie powinno sie sprawdzic czy number1 i number2 jest liczba!
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Wynik operacji: " + (number1 + number2));
                    break;
                case "-":
                    Console.WriteLine("Wynik operacji: " + (number1 - number2));
                    break;
                case "*":
                    Console.WriteLine("Wynik operacji: " + (number1 * number2));
                    break;
                case "/":
                    if (number2 != 0) Console.WriteLine("Wynik operacji: " + (number1 / number2)); //Uwzglednic dzielenie przez 0
                    else Console.WriteLine("Nie można dzielić przez 0");
                    break;
                default:
                    Console.WriteLine("Wybraleś zły operator");
                    break;
            }
        }
        static void task35()
        {
            Console.WriteLine("Podaj współczynik a");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współczynik b");
            var number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współczynik c");
            var number3 = Convert.ToDouble(Console.ReadLine());
            double delta = Math.Pow(number2, 2) - (4*number1*number3);
            if (delta < 0) Console.WriteLine("Brak rozwiązan w liczbach rzeczywistych");
            else if (delta > 0) Console.WriteLine($"X1: {(-number2 - Math.Sqrt(delta)) / (2 * number1)} X2: {(-number2 + Math.Sqrt(delta)) / (2 * number1)}");
            else if (delta == 0) Console.WriteLine($"X0: {-number2 / (2 * number1)}");
        }
        static void task36()
        {
            Console.WriteLine("Podaj wage w kg");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w M");
            var number2 = Convert.ToDouble(Console.ReadLine());
            double bmi = number1/Math.Pow(number2, 2);
            if (bmi < 16) Console.WriteLine($"BMI:{bmi} Wygłodzenie");
            else if (bmi >= 16 && bmi<17) Console.WriteLine($"BMI:{bmi} wychudzenie");
            else if(bmi >= 17 && bmi < 18.5) Console.WriteLine($"BMI:{bmi} niedowaga");
            else if (bmi >= 18.5 && bmi < 25) Console.WriteLine($"BMI:{bmi} Pożadana masa ciała");
            else if (bmi >= 25 && bmi < 30) Console.WriteLine($"BMI:{bmi} nadwaga");
            else if (bmi >= 30 && bmi < 35) Console.WriteLine($"BMI:{bmi} Otyłość I stopnia");
            else if (bmi >= 35 && bmi < 40) Console.WriteLine($"BMI:{bmi} Otyłość II stopnia");
            else if (bmi >= 40) Console.WriteLine($"BMI:{bmi} Otyłość III stopnia");
        }
        static void task37()
        {
            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();
            switch (numer)
            {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;
                case "2":
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Środa");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piątek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;
            }
        }
        static void task38()
        {
            Console.WriteLine("Wpisz srednia ocen");
            double numer = Convert.ToDouble(Console.ReadLine());
            if (numer < 4) Console.WriteLine("Kwota stypendium: 0,00zł");
            else if (numer >= 4 && numer < 4.8) Console.WriteLine("Kwota stypendium: 350,00zł");
            else if( numer>=4.8 && numer <5) Console.WriteLine("Kwota stypendium: 550,00zł");
        }
        static void task39() //jedne z najgorszych :)
        {
            Console.WriteLine("Wpisz długość wierszy");
            double numer = Convert.ToDouble(Console.ReadLine());
            for (var i = 0; i <= numer; i++) //figura a
            {
                for(var k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write("\n");
            for (var i = numer; i >= 0; i--) //figura b (INVERT FOR)
            {
                for (var k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write("\n");
            for (var i = 0; i <=numer; i++) //figura c 
            {
                for (var k = 0; k < numer-i; k++)
                {
                    Console.Write(" ");
                }
                for (var x = 0; x < i ; x++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write("\n");

        }
        static int calcsilnia(int number)
        {
            if (number <= 1) return 1;
            else return number * calcsilnia(number - 1);
        }
        static void task30()
        {
            Console.WriteLine("Wpisz N: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calcsilnia(number));
        }
        static void task311()
        {
            int suma = 0;
            int licznik = 1;
            for (; suma <= 100; licznik++) suma += licznik;
            Console.WriteLine($"Suma: {suma} Ilosc liczb: {licznik-1}");
        }
        static void task312()
        {
            int suma = 0;
            for(; ; )
            {
                Console.WriteLine("Podaj liczbe: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0) break;
                suma += number;
            }
            Console.WriteLine($"SUMA TO: {suma}");
        }
        static void task313()
        {
            Console.WriteLine("Podaj liczbe: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            sum = -number / 2;
            if (number % 2 == 1) sum += number;
            //normalnie powinna tu byc petla ale mozna matematycznie uprościć to :)
            Console.WriteLine($"W({number}) = {sum}");
        }
        static void task314()
        {
            //Tutaj nie jest znany algorytm szybszy na poznanie dzielników od niej samej wiec zostaje bruteforce
            Console.WriteLine("Podaj liczbe: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++) //zlozonosc n^2
            {
                int pom = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        pom += j;
                    }
                }
                if (pom == i) Console.WriteLine($"Liczba Doskonała: {i}");

            }
        }
        static void FindCombinations(int amount, int[] denominations, List<int> currentCombination, List<List<int>> results)
        {
            if (amount == 0)
            {
                results.Add(new List<int>(currentCombination));
                return;
            }
            if (amount < 0 || (denominations.Length == 0 && amount > 0))
            {
                return;
            }

            for (int i = 0; i < denominations.Length; i++)
            {
                int currentDenomination = denominations[i];
                currentCombination.Add(currentDenomination);
                FindCombinations(amount - currentDenomination, denominations, currentCombination, results);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }

        public static void task315()
        {
            int[] denominations = { 1, 2, 5 };
            int amount = 10;
            List<List<int>> results = new List<List<int>>();
            List<int> currentCombination = new List<int>();

            FindCombinations(amount, denominations, currentCombination, results);
            foreach (var k in results)
            {
                Console.WriteLine(string.Join(", ", k));
            }
            Console.WriteLine($"Takich Wariacji jest: {results.Count}");
        }
        static void Main(string[] args)
        {
            task315();
        }
    }
}
