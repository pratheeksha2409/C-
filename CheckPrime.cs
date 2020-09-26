using System;
namespace SampleCoreApp
{
    class CheckPrime
    {
        static bool isPrime(int n)
        {

            if (n <= 1)
                return false;

            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        static void Main()
        {
            if (isPrime(11))
                Console.Write(" true");

            else
                Console.Write(" false");
        }
    }
}