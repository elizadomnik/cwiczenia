using System;

public class Zad8
{
    public static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("Podaj pierwszą liczbę");
        a = inputValue();
        Console.WriteLine("Podaj drugą liczbę");
        b = inputValue();
        double @operator;

        Console.WriteLine("Podaj numer działania");
        @operator = inputValue();
        int wynik;

        if (@operator == 1)
        {
            wynik = (int)(a + b);
        }
        else
        {
            if (@operator == 2)
            {
                wynik = (int)(a - b);
            }
            else
            {
                if (@operator == 3)
                {
                    wynik = (int)(a * b);
                }
                else
                {
                    if (b == 0)
                    {
                        wynik = (int)(b / a);
                    }
                    else
                    {
                        wynik = (int)(a / b);
                    }
                }
            }
        }
        Console.WriteLine("Wynik: ");
        Console.WriteLine(wynik);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
