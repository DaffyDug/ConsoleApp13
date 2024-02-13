using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            dateTime.print();
        }
    }
    class LevelManager
    {
        private int _n;

        public void NEWLevel(int n)
        {
            Console.WriteLine($"вы перешли на {n} уровень");
        }

    }

    public static class MyExtension
    {
        public static int Sum(this int a,int b)
        {
            int c = a + b;
            Console.WriteLine(c); 

            return c;
        }
        public static void print(this DateTime n)
        {
            
            Console.WriteLine(n);
        }
    }
    public class Telephone
    {
        private readonly string brand;
        private readonly string model;
        private readonly int price;
        private const string socket="Litnig";
    }

}
