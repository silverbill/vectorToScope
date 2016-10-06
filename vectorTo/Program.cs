
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

public class Program
{
    static float vectorLength(float[,] vecs)
    {
        double deltaX = ((vecs[0, 0]) - (vecs[1, 0]));
        double deltaY = ((vecs[0, 1]) - (vecs[1, 1]));
        double xSquared = Math.Pow(deltaX, 2);
        double ySquared = Math.Pow(deltaY, 2);
        double sumSquares = xSquared + ySquared;
        double SqrtSumSquares = Math.Sqrt(sumSquares);
        return (float)(SqrtSumSquares);
    }
    public static void Main()
    {
        Console.WriteLine(vectorLength(new float[2, 2] { { 0, 3 }, { 4, 0 } }) == 5);
        Console.WriteLine(vectorLength(new float[2, 2] { { 1, -1 }, { 1, -1 } }) == 0);
        Console.WriteLine(vectorLength(new float[2, 2] { { 0, 1 }, { 0, 0 } }) == 1);
        Console.ReadLine();
    }
}
