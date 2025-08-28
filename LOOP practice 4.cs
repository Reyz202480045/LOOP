using System;

class Program
{
    static void Main(string[] args)
    {
        int sumOfSquares = 0;
        for (int i = 1; i <= 10; i++)
        {
            sumOfSquares += (i * i);
        }
        Console.WriteLine("The sum of the squares of the first 10 natural numbers is: " + sumOfSquares);
    }
}