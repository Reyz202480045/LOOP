using System;

class Program
{
    static void Main(String[] Args)
    {
        Console.Write("Enter a Number: ");
        int Num = Convert.ToInt32(Console.ReadLine());

        int sumOdd = 0;
        for (int i = 1; i <= Num; i++)
        {
            if (i % 2 == 1)
            {
                sumOdd += i;
            }
        }
        Console.WriteLine("The Sum of Odd Numbers is: {0}", sumOdd);
    }
}