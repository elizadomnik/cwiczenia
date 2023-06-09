using System;

public class Zad4
{
    public static void Main(string[] args)
    {
        int a, b, c, d;

        a = (int)inputValue();
        b = (int)inputValue();
        c = (int)inputValue();
        d = (int)inputValue();
        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        double x;

        x = a * d + b * c;
        double y;

        y = b * d;
        Console.Write("X=");
        Console.Write(x);
        Console.Write(", Y=");
        Console.WriteLine(y);
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
