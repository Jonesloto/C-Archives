using System;

namespace quadraticSolutionsApp
{
    class Program
    {
        public class quadratics
        {
            public static double[] FindSolutions(dynamic a, dynamic b, dynamic c)
            {
                a = (double)a;
                b = (double)b;
                c = (double)c;

                double x1 = (-b + Math.Sqrt(b * b - (4 * a * c))) / (2 * a);
                double x2 = (-b - Math.Sqrt(b * b - (4 * a * c))) / (2 * a);

                double[] solutionSet = {x1, x2};

                return solutionSet;
            }
        }
        

        static void Main(string[] args)
        {
            double a = -0.2;
            double b = -5.8;
            double c = 10;

            Console.WriteLine(quadratics.FindSolutions(a, b, c)[0]);
            Console.WriteLine(quadratics.FindSolutions(a, b, c)[1]);
            Console.Read();
        }
    }
}
