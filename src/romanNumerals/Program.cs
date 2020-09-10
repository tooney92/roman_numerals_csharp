using System;
using System.Collections.Generic;

namespace roman_numerals_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please provide a number you want to convert: ");
            var userInput = Console.ReadLine();
            var s1 = new Converter();
            s1.convert(userInput);
           
        }
    }
}
