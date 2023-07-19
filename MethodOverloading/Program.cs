using System;
using System.Net.NetworkInformation;

namespace MethodOverloading
{
    public class Program
    {
        //Create a method named Add, that accepts two integers and returns the sum of those two integers
        static void Main(string[] args)
        { 
            public static int Add(int numx, numy)

            {
                return numx + numy;
            }
           // Now create an overload of the Add method to account for being able to add two decimals together


            public static decimal Add(decimal numx, decimal numy)

            {
                return numx + numy;
            }
            // Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
            public static string Add(int num1, int num2, bool check)

                var sum = num1 + num2;

            if (checked == true && sum > 1 )
                {
                return $"{sum} dollars";

            }


            if (checked == true && sum == 1)
                {
                return $"{sum} dollar"; }



            if (checked == true && sum < 1)
                {
                return $"{sum} dollars";
            }


            else
            {
                return sum.ToString();

            }


            static void Main(string[] args)

            {


            }


        }
    }
}
