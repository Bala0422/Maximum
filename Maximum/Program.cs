using System;
using System.Collections;
using System.Transactions;
using Microsoft.VisualBasic;

namespace Maximun 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter the 3 integers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());   
            int c = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("the Maximum Number is {0}", MaxComparerInt(a, b, c));

            Console.WriteLine("Enter 3 float values");
            decimal x = Convert.ToDecimal(Console.ReadLine());
            decimal y = Convert.ToDecimal(Console.ReadLine());
            decimal z = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("the Maximum Number is {0}", MaxCompareFloat(x, y, z));


            Console.WriteLine("Enter 3 strings");
            string x1 = Console.ReadLine();
            string y1 = Console.ReadLine();
            string z1 = Console.ReadLine();

            Console.WriteLine("the Max string is {0}", MaxCompareString(x1, y1, z1));


            Console.WriteLine("Results from Generic Method");
            GenericMethod(a, b, c);
            GenericMethod(x, y, z);
            GenericMethod(x1, y1, z1);*/


            Console.WriteLine("Generic Method which takes multiple parameter and of any number of variables");

            int[] inp = { 1, 2, 3, 5, 6, -5, -7 };
            string[] strings = { "aa", "bala", "waedw", "waewae" };
            double[] floats = { 1.2, 1.222, 12.12321, 312.33};
 
            Generic(inp);
            Generic(floats);
            Generic(strings);

        }

        public static void Generic<T>(T[] args)
        {
            var max = args[0];
            foreach(T t in args)
            {
                if (Comparer<T>.Default.Compare(max, t) < 0)
                {
                    max = t;
                }
            }

            Console.WriteLine(max);

        }
        public static void GenericMethod<T>(T a, T b, T c)
        {
             if (Comparer<T>.Default.Compare(a, b) > 0 && Comparer<T>.Default.Compare(a, c) > 0)
            {
                Console.WriteLine(a);
            }else if (Comparer<T>.Default.Compare(b, a) > 0 && Comparer<T>.Default.Compare(b, c) > 0)
                {
                    Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }

        }
        public static int MaxComparerInt(int a, int b, int c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                return a;
            }
            else if (b.CompareTo(c) > 0 && b.CompareTo(a) > 0)
            {
                return b;

            }
            else  
            {
                return c;
            }
            
        }

        public static decimal MaxCompareFloat(decimal a, decimal b, decimal c)
        {

            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                return a;
            }
            else if (b.CompareTo(c) > 0 && b.CompareTo(a) > 0)
            {
                return b;

            }
            else
            {
                return c;
            }
        }


        public static string MaxCompareString(string a, string b, string c) {

            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                return a;
            }
            else if (b.CompareTo(c) > 0 && b.CompareTo(a) > 0)
            {
                return b;

            }
            else
            {
                return c;
            }
        }

    }
}