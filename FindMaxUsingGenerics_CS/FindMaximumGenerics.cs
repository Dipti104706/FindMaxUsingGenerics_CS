using System;
using System.Collections.Generic;

namespace FindMaxUsingGenerics_CS
{
    class FindMaximumGenerics<T> where T:IComparable
    {
        public T first, second, third;
        public FindMaximumGenerics(T first,T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static T FindMax(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("two or more numbers are equal");
                return default;
            }
        }
    }
}
