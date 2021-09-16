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
        //UC4 to Extent find Max method to take more than three parameter
        static void Main(string[] args)
        {
            int[] intArray = { 10, 55, 25, 5, 42 };
            GenericArrayMax<int> final = new GenericArrayMax<int>(intArray);
            final.PrintMax();
            Console.ReadLine();
        }
    }
}
