﻿using System;
using System.Net.NetworkInformation;

namespace MethodOverloading
{
    public class Program
    {
        //Create a method named Add, that accepts two integers and returns the sum of those two integers


        public static int Add(int numx, int numy)

        {
            return numx + numy;
        }
        // Now create an overload of the Add method to account for being able to add two decimals together


        public static decimal Add(decimal num1, decimal num2)

        {
            return num1 + num2;
        }
        // Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean


        public static string Add(int num1, int num2, bool check)
        {
            var sum = 0;
            var response = "";

            if (check)
            {
                sum = num1 + num2;

                if (sum == 1)
                {
                    response = ($"{sum} dollar.");
                }
                else
                {
                    response = ($"{sum} dollars.");
                }

            }
            return response;

        }
        static void Main(string[] args)
        {

            var a = 54.2m;
            var b = 33.3m;

            var decimalanswer = Add(a, b);
                
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine();
            Console.WriteLine(Add(5, 10, true));
            Console.WriteLine();
            Console.WriteLine(Add(-4, 8, true));
            Console.WriteLine();
            Console.WriteLine(decimalanswer);
            Console.WriteLine();


        }
    }
}


