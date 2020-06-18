using System;

namespace sum_number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*/5. Write a function that takes in two numbers, and returns the sum of all the numbers between them.
            Example: input is 7 and 12. Output would be 7 + 8 + 9 + 10 + 11 + 12 = 57*/
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result = sum_number(number1,number2);
            Console.WriteLine($"Rsult: {result}");

        }
        static int sum_number(int n1,int n2){
            int sum=0;
            for(int i=n1;i<=n2;i++){
                sum +=i;

            }
            return sum;
        }
    }
}
