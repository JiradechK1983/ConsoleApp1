using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;

            Console.WriteLine($"Number is {num1}"); // String Interpolation
            Console.WriteLine("Number is " +  num1); // String Concatetion

            Console.ReadKey();
        }
    }
}
