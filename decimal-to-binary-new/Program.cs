using System;

namespace decimal_to_binary_new
{
    class Program
    {
        static void Main(string[] args)
        {
            //dicimal to binary
            Console.WriteLine("enter decimal number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            string result = "";

            while(number>0){
                int remainder = number % 2;
                number /=number;
                result = remainder.ToString() + result;
            }
           Console.WriteLine($"The binary number of {number} is {result}");
        }
    }
}
