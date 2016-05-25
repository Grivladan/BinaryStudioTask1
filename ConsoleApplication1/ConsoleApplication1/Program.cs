using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Calculator
{
    public static double Sum(double x, double y)
    {
        return x + y;
    }

    public static double Dif(double x, double y)
    {
        return x - y;
    }

}

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum is:");
            Console.WriteLine(Calculator.Sum(10,5));
            Console.WriteLine("Difference is:");
            Console.WriteLine(Calculator.Dif(10,5));
            SayHello();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello world");
        }
    }
}
