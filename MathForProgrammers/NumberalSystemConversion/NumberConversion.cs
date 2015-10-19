using System;


//Problem 5.	Numeral System Conversions
//Convert 1234d to binary and hexadecimal numeral systems.
//Convert 1100101b to decimal and hexadecimal numeral systems.
//Convert ABChex to decimal and binary numeral systems.



    class NumberConversion
    {
        static void Main(string[] args)
        {
            int someNumber = 1234;
            string hexSomeNumber = String.Format("0x{0:X}", someNumber);
            string binSomeNumber = Convert.ToString(someNumber, 2);
            Console.WriteLine("Decimal {0}; Hex {1}; Binary {2};", someNumber, hexSomeNumber, binSomeNumber );

            string binSecondNumber = "1100101";
            int decSecondNumber = Convert.ToInt32(binSecondNumber,2);
            string hexSecondNumber = String.Format("0x{0:X}", decSecondNumber);
            Console.WriteLine("Decimal {0}; Hex {1}; Binary {2};", decSecondNumber, hexSecondNumber, binSecondNumber);

            string hexThirdNumber = "ABC";
            int decThirdNumber = Convert.ToInt32(hexThirdNumber, 16);
            string binThirdNumber = Convert.ToString(decThirdNumber, 2);
            Console.WriteLine("Decimal {0}; Hex {1}; Binary {2};", decThirdNumber, hexThirdNumber, binThirdNumber);

        }
    }

