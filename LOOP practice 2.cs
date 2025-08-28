using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the base number: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the positive integer exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        double result = 1.0;

        for (int i = 0; i < exponent; i++)
        {
            result *= baseNum;
        }

        Console.WriteLine("{0} raised to the power of {1} is: {2}", baseNum, exponent, result);
    }
}