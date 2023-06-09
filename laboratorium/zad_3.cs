using System;

public class Zad3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj wagę");
        double w;

        w = inputValue();
        Console.WriteLine("Podaj wzrost");
        double h;

        h = inputValue();
        if (h <= 2)
        {
        }
        else
        {
            Console.WriteLine("Wzrost nie może być większy niż 2 metry");
        }
        int bMI;

        bMI = (int)(w / (h * h));
        Console.WriteLine(bMI);
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
