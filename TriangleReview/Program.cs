using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleReview
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            var b = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            var c = int.Parse(Console.ReadLine());

            var type = GetTriangleType(a, b, c);

            Console.WriteLine(type);

            Console.ReadKey();
        }

        public static TriangleTypes GetTriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
                return TriangleTypes.Equilateral;

            if (a != b && b != c && a != c)
                return TriangleTypes.Scalene;

            return TriangleTypes.Isosceles;
        }
    }
}
