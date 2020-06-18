using System;

namespace multiples_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
           /*7. Write a function that takes in a number, and adds together all numbers between 1 and 50 that are multiples of that number.
    Example: Input is 12 -> Result = 12 + 24 + 36 + 48 = 120
           */
           Console.WriteLine("Enter number: ");
           int number =  Convert.ToInt32(Console.ReadLine());
         
           if(number>50 || number<=0){
               Console.WriteLine("Enter number between 1 to 50");
           }else{
               
            int result = multiples_of_number(number);
            Console.WriteLine($"Result: {result}");
           }
           
            
        }
        static int multiples_of_number(int n){
            int sum=0;

            for(int i=1;i<=50;i++){
                int mul = n*i;
              
                if(mul<=50){
                     
                    sum+=mul;
                    Console.WriteLine($"Result: {mul} ");
                }
            }
            return sum;
            
        }
        
    }
}
