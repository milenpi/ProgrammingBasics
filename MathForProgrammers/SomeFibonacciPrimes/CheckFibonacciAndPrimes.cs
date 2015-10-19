using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 2.	Some Fibonacci Primes
//Check if the 24th, 101st and 251st prime numbers are part of the base Fibonacci number set. What is their position?

class CheckFibonacciAndPrimes
{
    static void Main()
    {
        int a = 0;
        int b = 1;
        int temp = 0;

        int countPosition = 2;

        int firstPrime = 89;
        int secondPrime = 547;
        int thirdPrime = 1597;

        while (temp <= thirdPrime)
        {
            temp = a + b;
            a = b;
            b = temp;

            countPosition += 1;

            if (temp == firstPrime || temp == secondPrime || temp == thirdPrime)
            {
                Console.WriteLine(temp + " is at position {0}", countPosition);
            }
        }

    }
}


