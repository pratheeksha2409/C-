using System;


namespace SampleCoreApp
{
    class RangeOfPrime
    {

        public int sumOfPrimes(int from, int to)
        {

            int[] array = new int[to + 1];
            for (int i = from; i <= to; i++)
            {
                if (i == 1 || i == 0)
                    continue;

                int flag = 1;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                if (flag == 1)
                    array[i] = i;
            }
            int sum = 0;
            foreach (int elem in array)
            {
                sum = sum + elem;
            }
            return sum;
        }

        static void Main()
        {
            Console.WriteLine("Enter starting range of prime numbers:");
            int from = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting range of prime numbers:");
            int to = int.Parse(Console.ReadLine());

            RangeOfPrime p = new RangeOfPrime();
            int value = p.sumOfPrimes(from, to);
            Console.WriteLine("Sum of prime numbers:" + value);


        }
    }
}