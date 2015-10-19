using System;

//Problem 6.	Least Common Multiple
//Find LCM(1234, 3456)



    class FindTheLCM
    {

        public static long GCD(long a, long b)
        {
            while (b != 0)
            {
                long tmp = b;
                b = a % b;
                a = tmp;
            }

            return a;
        }

     
        public static long LCM(long a, long b)
        {
            return (a * b) / GCD(a, b);
        }

        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            

            Console.WriteLine("The GCD of number {0} and number {1} is {2}", a, b, GCD(a, b));
            Console.WriteLine("The LCM of number {0} and number {1} is {2}", a, b, LCM(a, b));

        }
    }

