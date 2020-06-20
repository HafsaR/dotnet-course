using System;

namespace challenge11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*11. Write a function that takes in a number and a string. Return a substring of the original string of the size of the number.
        Example: Input is "Hello world" and 7. Output should be "Hello w".
        If the number is greater than then length of the string, pad the string with dots so that it matches the length
        Example: Input is "Hello" and 10. Output should be "Hello....."*/
        Console.WriteLine("Enter string: ");
        string inputString = Console.ReadLine();
        Console.WriteLine("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
       // Console.WriteLine($"Input string: {inputString}, number: {number}");
        getSubString(inputString,number);
        
        
        }
        static void getSubString(string str,int n){
            string concatStr = str, result = "";
            if(n>str.Length){
                for(int i=str.Length+1; i<=n;i++){
                    concatStr += ".";
                }
                for(int j=0;j<n;j++){
                    result += concatStr[j];
                }
                // Console.WriteLine($"concat str.....: {concatStr} length: {concatStr.Length} result : {result}");
                Console.WriteLine($"Sub string is: {result}");
            }else{
                for(int i=0; i<n;i++){
                    result += str[i];
                }
               // Console.WriteLine($"str: {str} length: {str.Length} result: {result}");
                Console.WriteLine($"Sub string is: {result}");

            }
        }

    }
}
