using System;

namespace leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
           /*8. Write a function to check if a given year is a leap year. You may need to look up the rules for what counts as a leap year.
           
           How to determine whether a year is a leap year
            To determine whether a year is a leap year, follow these steps:

                if year is divisible by 400 then is_leap_year
                else if year is divisible by 100 then not_leap_year
                else if year is divisible by 4 then is_leap_year
                else not_leap_year
           */
           Console.WriteLine("Enter year: ");
           int year = Convert.ToInt32(Console.ReadLine());
           bool result = leap_year(year);
          Console.WriteLine(result?"Leap year": "Not a leap year");
           
        }
        static bool leap_year(int year){
        // If a year is multiple of 400, 
		// then it is a leap year 
		if (year % 400 == 0) 
			return true; 
	
		// Else If a year is muliplt of 100, 
		// then it is not a leap year 
		if (year % 100 == 0) 
			return false; 
	
		// Else If a year is muliplt of 4, 
		// then it is a leap year 
		if (year % 4 == 0) 
			return true; 
		return false; 
            
        }
    }
}
