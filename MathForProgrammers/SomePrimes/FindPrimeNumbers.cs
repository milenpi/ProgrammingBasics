using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 1.	Some Primes
//Find the 24th, 101st and 251st prime number.



class FindPrimeNumbers
{
    static void Main()
    {
        int number = 3;
        int numberPosition = 1; // 1 because we are skipping the first number - 2
        int counter = 2;

        

        while (true)
        {
            bool isPrime = true;

            for(counter = 2; counter <= (int)Math.Sqrt(number); counter ++)
            {
                if (number % counter == 0)
                {
                    isPrime = false;
                }

            }
            if (isPrime)
            {
                numberPosition += 1;
                if (numberPosition == 24 || numberPosition == 101)
                {
                    Console.WriteLine(number);
                }
                
                else if(numberPosition == 251)
                {
                    Console.WriteLine(number);
                    return;
                }
               
            }
            
            number += 2; //starting with uneven number and iterating by 2. Skipping all even numbers.

        }

    }
    }


