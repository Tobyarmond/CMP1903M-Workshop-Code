using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            //(-4, -5) and (-1, -1) describe two points. What is the distance between them?

            Vector vector1 = new Vector(4, 5);
            Vector vector2 = new Vector(1, 1);
            Vector vector3 = vector1 - vector2;
            Console.WriteLine(Vector.Distance(vector3));

            //Problem 2
            //What is the denominator of the slope between these points?

            Console.WriteLine(vector3.X);

            //Problem 3
            //What is the greatest common divisor (GCD) of 1124 and 136?
            
            Console.WriteLine(Stuff.Gcd(1124, 136));

            //Problem 4
            //What is the remainder, when you divide the square of the sum of the first ten natural numbers by ten?
            
            Console.WriteLine(Stuff.Sum(10) * Stuff.Sum(10) % 10);

        }
    }
}
