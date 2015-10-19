using System;
using System.Numerics;

//Problem 3.	Some Factorials
//Find 100!, 171! and 250! Give all digits.


class CalculateFactorials
{
    static void Main()
    {

        int n = 171;

        BigInteger result = 1;

        for (int i = 1; i <= n; i++)
        {
            result = result * i;
        }
        Console.WriteLine(result);
    }
}

