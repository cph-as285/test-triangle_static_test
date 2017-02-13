using System;

namespace TriangleReview
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            do
            {
                Console.Clear();

                a = GetIntFromConsole("Enter a: ");
                b = GetIntFromConsole("Enter b: ");
                c = GetIntFromConsole("Enter c: ");

                Console.WriteLine(GetTriangleType(a, b, c));

                Console.WriteLine("Press 'y' to run again");

            } while (Console.ReadKey().KeyChar == 'y');
        }

        private static int GetIntFromConsole(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }

        private static TriangleTypes GetTriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
                return TriangleTypes.Equilateral;

            if (a != b && b != c && a != c)
                return TriangleTypes.Scalene;

            return TriangleTypes.Isosceles;
        }
    }
}
