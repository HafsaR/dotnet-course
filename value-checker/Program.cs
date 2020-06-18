using System;

namespace value_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a function that checks if a number is both greater than 0 AND a multiple of 3.
                    Input: int
                    Output: bool
            */

            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool result = valueChecker(number);
            
            Console.WriteLine($"Result is {result}");
        }
        static bool valueChecker(int number){
            if(number>0 && number%3 == 0){
                return true;
            }else{
                return false;
            }
        }
    }
}
