using System;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a function that checks if a string contains the substring "abc".
            Input: string
            Output: bool
            */

            Console.WriteLine("Enter string: ");
            string inputString = Console.ReadLine();
           
            bool result = checkSubString(inputString);
            Console.WriteLine(result);

        }
        static bool checkSubString(string str){
             string substr="abc";
            if(str.Contains(substr)){
                return true;
            }else{
                return false;
            }

        }
    }
}
