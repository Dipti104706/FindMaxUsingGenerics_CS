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
        //UC1 to display maximum between three integer
        static void Main(string[] args)
        {
            Console.WriteLine("The maximum value is:" + FindMaximum.FindMax(21,10,28));
            Console.ReadLine();
        }
    }
}
