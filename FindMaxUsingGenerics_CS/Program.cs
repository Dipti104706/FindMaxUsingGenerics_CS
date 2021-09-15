using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics_CS
{/// <summary>
/// Template for displaying maximum number between three num
/// </summary>
    class Program
    {
        //UC2 to display maximum between three float
        static void Main(string[] args)
        {
            Console.WriteLine("The maximum value is:" + FindMaximum.FindMax(12f,30f,25f));
            Console.ReadLine();
        }
    }
}
