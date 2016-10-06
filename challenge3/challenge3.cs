using System;
using System.Diagnostics;

public class randomnumber
{
    static int random(int min, int max)
    {
        Random r = new Random();

        double randomDouble = r.NextDouble() * (max - min) + min;

        return (int)randomDouble;

    }
    public static void Main()
    {
        Console.WriteLine(random(1, 2) <= 2 && random(1, 2) >= 1);
        Console.WriteLine(random(-11, 22) <= 22 && random(-11, 22) >= -11);
        Console.ReadLine();
    }
}