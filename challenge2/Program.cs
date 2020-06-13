using System;

namespace challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
//             Challenge #2: Count the number of vowels in a string
// - Input: a string
// - Output: a number 


        string str;
		int i, len, vowel;
		Console.Write("Input the string : ");
		str = Console.ReadLine().ToLower();
		vowel = 0;
		len = str.Length;
		
		for(i=0; i<len; i++) {
        if(str[i] =='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u')
        {
            vowel++;
        }
    }
   Console.Write("\nThe total number of vowels in the input is : {0}\n", vowel);

        }
    }
}
