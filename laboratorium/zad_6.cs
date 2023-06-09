using System;

public class Zad6
{
    public static void Main(string[] args)
    {
        double a, b, c;

        a = inputValue();
        b = inputValue();
        c = inputValue();
        if (a == b && b == c)
        {
            Console.WriteLine("Trójkąt o podanych bokach jest równoboczny");
        }
        else
        {
            Console.WriteLine("Trójkąt o podanych bokach NIE jest równoboczny");
        }
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
