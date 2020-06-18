using System;

namespace remove_vowels
{
    class Program
    {
        static void Main(string[] args)
        {
           //Write a function that takes a string as input and removes the vowels from the string.
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();
            string result = remove_vowels(input);
            Console.WriteLine($"final string: {result}");

        }
        static string remove_vowels(string str){
            string[] vowels ={"a","e","i","o","u"};
           string lowercaseString = str.ToLower(); 

           for(int i=0;i<lowercaseString.Length;i++){
               foreach(string x in vowels){
                    if(lowercaseString.Contains(x)){
                   int index = lowercaseString.IndexOf(x);
                 lowercaseString = lowercaseString.Remove(index,1);
              //  Console.WriteLine($"remove vowel: {lowercaseString}");
               }
               }
           }
        return lowercaseString;
        }
    }
    }
