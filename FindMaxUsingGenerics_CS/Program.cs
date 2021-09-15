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
        //UC3 to display maximum between three strings
        static void Main(string[] args)
        {
            Console.WriteLine("The maximum value is:" + FindMaximum.FindMax("Apple", "Peach", "Banana"));
            Console.ReadLine();
        }
    }
}
