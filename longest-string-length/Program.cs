using System;

namespace longest_string_length
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Challenge: Write a function 
           that takes two strings and returns the length of the longest string*/

           Console.WriteLine("Write string one: ");
           string string1 =Console.ReadLine();
           Console.WriteLine("Write string two: ");
           string string2 = Console.ReadLine();
           
           int longestStringLength=longest_string_length(string1,string2);
           Console.WriteLine($"Longest string length is : {longestStringLength}");

        }
        static int longest_string_length(string s1,string s2){
           
             if(s1.Length==s2.Length){
                Console.WriteLine($"String {s1} equal {s2}");
                return s1.Length;

            }
            else if(s1.Length>s2.Length){
                Console.WriteLine($"String {s1} is greater than {s2}");
                return s1.Length;

            }else{
                Console.WriteLine($"String {s2} is greater than {s1}");
                return s2.Length;

            }
           

        }
    }
}
