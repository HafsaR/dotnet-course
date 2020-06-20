using System;

namespace challenge14
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 14. Write some code that accepts numbers from user input and adds it to a running sum.
            The program exits when the user enters a '0'.
            Example:
            Current Sum: 0
            Enter a number: 5
            Current Sum: 5
            Enter a number: 12
            Current Sum: 17
            Enter a number: -3
            Current Sum: 14
            Enter a number: 0
            Final result: 14   */
             double sum =0 ;
             Console.WriteLine($"Current sum: {sum}");
            Console.WriteLine("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());
           
           
           while (number!=0)
           {
              
               Console.WriteLine($"Current sum: { sum += number}");
               Console.WriteLine("Enter number: ");
                number = Convert.ToDouble(Console.ReadLine());
               
           }
           Console.WriteLine($"Final result: {sum}");
        }
    }
}
