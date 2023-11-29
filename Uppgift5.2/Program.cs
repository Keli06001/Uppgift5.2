using System;

namespace Inlämningsuppgift5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heltalArray = new int[3];

            heltalArray[0] = 5;
            heltalArray[1] = 10;

            Console.Write("Ange det tredje talet: ");
            heltalArray[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"De tre heltalen är: {heltalArray[0]}, {heltalArray[1]}, {heltalArray[2]}");

        }
    }
}