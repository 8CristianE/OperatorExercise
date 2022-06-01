using System;

namespace OperstorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var sum = a + b;
            Console.WriteLine($"a + b  = {sum}");

            var sub = a - b;
            Console.WriteLine($"a - b  = {sub}");

            var product = a * b;
            Console.WriteLine($"a * b = {product}");

            int division = a/b;
            int remainder = division % 17 / 4;
            Console.WriteLine($"{a}/{b} is {division} remainder {remainder}");

            Console.WriteLine();

            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}.");

        }
    }
}

