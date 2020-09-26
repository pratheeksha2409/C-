using System;

namespace SampleCoreApp
{
    /* variables in C# are based on the common Type system, of .NET Framework.
     All data types in .NET follow the guidelines defined in Common language specification
    Variables in .NET are of 2 types:Value types,references types.
    Value types:primitive and are structures.
    Integral types:byte(Byte),short(Int16),int(Int32),long(Int64)
    Floating Types:float(Single), short(Single),double(double)
    other types: char(Char),bool(boolean),decimal(decimal-128 Bit no).
    All data Types of C# are implicitly objects of their wrapper types created in .NET. Inplicitly they are all objects.
    The wrapper types provide the function to perform conversation from one type to another.
     */
    class Ex02
    {
        static void Main(string[] args)
        {
            int value = 123;
            Console.WriteLine("The value is " + value);

            double dVal = 234.345;
            Console.WriteLine("The double value is " + dVal);

            int bigInt = int.MaxValue; //U R using the wrapper class const value which gives the max value of int...
            Console.WriteLine("The max val of int is " + bigInt);
            Console.WriteLine("The Range of int is {0} to {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("The Range of float is {0} to {1}", float.MinValue,float.MaxValue);
            Console.WriteLine("The Range of short is {0} to {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("The Range of long is {0} to {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("The Range of double is {0} to {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("The Range of byte is {0} to {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("The Range of decimal is {0} to {1}", decimal.MinValue, decimal.MaxValue);

        }
    }
}
