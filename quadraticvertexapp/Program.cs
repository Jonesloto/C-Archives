using System;

using System;

namespace myApp
{
    class Program 
    {
        public class Methods
        {
            public static double[] FindVertex(int a, int b, int c) 
            {
                double da = (double)(a * 2);
                double db = (double)(b * 1);

                /* equation should look like 2ax + b */

                double Xvertex = (double)((-db)/da);
                double Yvertex = (double)((a * (Xvertex) * (Xvertex)) + (b * (Xvertex)) + c);
                
                double[] results = {Xvertex, Yvertex};
                
                return results;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("x: {0}", Methods.FindVertex(1, 1, 1)[0]);
            Console.WriteLine("y: {0}", Methods.FindVertex(1, 1, 1)[1]);
        }
    }
}