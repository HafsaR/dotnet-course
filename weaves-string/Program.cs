using System;

namespace weaves_string
{
    class Program
    {
        static void Main(string[] args)
        {
           /*6. Write a function that "weaves" two strings of equal length with dashes between each letter. Make one string uppercase and one lowercase.
            Example: Input is "Hello" and "World". Result should be "H-w-E-o-L-r-L-l-O-d"*/

            Console.WriteLine("Enter first string: ");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter second string: ");
            string string2 = Console.ReadLine();
            if(string1.Length == string2.Length){
                string rsult = weaves_string(string1,string2);
                Console.WriteLine(rsult);

            }else{
                Console.WriteLine("Input strings are not equal.");
            }
        }
        static string weaves_string(string s1, string s2){
            string uppercases1 = s1.ToUpper();
            string lowercases2 = s2.ToLower();
            string weaves = "";
            for(int i=0;i<s1.Length;i++){
                string s1Char = uppercases1[i].ToString();
                string s2Char = lowercases2[i].ToString();
                if(i==s1.Length-1){ weaves += string.Join("-",s1Char,s2Char);}
                else{ weaves += string.Join("-",s1Char,s2Char,"");}
               
               // Console.WriteLine($"weaves-->{weaves}");

               // Console.WriteLine($"{uppercases1[i]} {uppercases1.GetType()}");

            }
            
            return weaves;
        }
    }
}
