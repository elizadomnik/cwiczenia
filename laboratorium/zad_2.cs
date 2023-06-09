using System;

public class Zad2
{
    public static void Main(string[] args)
    {
        double p;

        Console.WriteLine("Podaj pole koła");
        p = inputValue();
        double r;

        r = Math.Sqrt(p / Math.PI);
        double o;

        o = 2 * Math.PI * r;
        Console.WriteLine(o);
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
