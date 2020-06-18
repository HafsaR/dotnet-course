using System;

namespace sum_of_square_two_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes in two numbers and returns the sum of the squares of the two numbers.

            Console.WriteLine("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double result = sum_of_square_two_number(number1,number2);
            Console.WriteLine($"Result is : {result}");

        }
        static double sum_of_square_two_number(double n1,double n2){
            Double r = Math.Pow(n1,2) + Math.Pow(n2,2);
            return r;

        }
    }
}
