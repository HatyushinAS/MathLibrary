using System;

namespace MathLibrary
{
    public class Numbers
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Division(int a, int b)
        {
            return a / b;
        }

        public static int Square(int a)
        {
            return a * a;
        }

        public static int Power(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; ++i)
            {
                result *= a;
            }
            return result;
        }
        
        public static double Sqrt(int a)
        {
            return Math.Sqrt(a);
        }
        
        public static int PerimeterTriangle(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double AreaCircle(double a)
        {
            return a * a * 3.14;
        }
        
        public static double Gravity(double a)
        {
            return a * 9.8;
        }
    }
}