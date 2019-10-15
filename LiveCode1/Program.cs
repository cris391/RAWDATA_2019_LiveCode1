using System;
using System.Collections.Generic;

namespace LiveCode1
{

    static class MyExt
    {
        public static string AsString<T>(this IEnumerable<T> a)
        {
            return string.Join(", ", a);
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[]{1,12,3,4,5};

            var aAsString = string.Join(", ", a);

            Console.WriteLine(a.AsString());

        }
    }
}
