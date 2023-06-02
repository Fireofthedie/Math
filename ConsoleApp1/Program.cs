using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary1;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GeometryClass1.SRectangle("4","7"));
            Console.WriteLine(GeometryClass1.SCircle("4"));
            Console.WriteLine(GeometryClass1.STrapezoid("7","8","9"));

            Console.ReadLine();
        }
    }
}
