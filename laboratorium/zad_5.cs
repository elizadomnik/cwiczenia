using System;

public class Zad5
{
    public static void Main(string[] args)
    {
        double a, b;

        a = inputValue();
        b = inputValue();
        double liczba;

        if (a > b)
        {
            liczba = a;
        }
        else
        {
            liczba = b;
        }
        Console.Write(liczba);
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
