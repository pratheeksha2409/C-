using System;
using System.Globalization;

namespace SampleCoreApp
{
    class Ex04
    {
        static void Main(string[] args)
        {
            //string[] names = new string[2];
            //for (int i=0;i< names.Length; i++)
            //{
            //    Console.WriteLine("Enter the participant's name please");
            //    names[i] = Console.ReadLine();
            //}
            //foreach (string name in names)
            //    Console.WriteLine(name);

            //.......................two dimension array..........................
            // Another way of Creating an array
            //int[] data = { 234, 345, 567, 35, 267, 743 };
            //foreach (int val in data) Console.WriteLine(val);

            //// Muliti dimenstional array.....
            //int[,] TwoD = new int[,]
            //{
            //    {3,4,5 },{1,8,9},{1,5,7}
            //};
            //Console.WriteLine("dimention->" + TwoD.Rank);
            //Console.WriteLine("lenght of first->" + TwoD.GetLength(0));

            //for (int i = 0; i < TwoD.GetLength(0); i++)
            //{
            //    for (int j = 0; j < TwoD.GetLength(1); j++)
            //    {
            //        Console.Write(TwoD[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //..............................Jagged array...............................

            //Array of array

            int[][] School = new int[5][]; //row are 5
            School[0] = new int[] { 45, 55, 56, 76, 74 };
            School[1] = new int[] { 23, 45, 57 };
            School[2] = new int[] { 23, 56, 67, 14, 85 };
            School[3] = new int[] { 23, 77 };
            School[4] = new int[] { 34, 98, 07 };
            //Each row is an independent array...
            for(int i =0; i < School.Length; i++) 
            {
                foreach (int no in School[i])
                    Console.WriteLine(no + " ");
                Console.WriteLine();
            }







        }
    }
}
