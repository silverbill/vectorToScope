using System;

    public class Addition
    {
        static Func<int, int, int> sum = (a, b) => (a + b);
        public static void Main()
        {
            Console.WriteLine(sum(1, 2) == 3);
            Console.ReadLine();
        }
    }



