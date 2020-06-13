using System;

namespace challenge1
{
    class Program
    {
        static void Main(string[] args)
        {


//             Challenge #1: Design a ticket-selling algorithm
// - the input is the age of the buyer
// - the output is the price of the ticket
// - Rules:
// -- Children aged 5 and younger: free
// -- Children aged 6-14: 8.99
// -- Adults: 12.99
// -- Seniors (65+): 7.99
// */

            Console.WriteLine("What is the age of the buyer? ");
            string age = Console.ReadLine();
            int intAge = Convert.ToInt32(age);

            if(intAge <= 5){
                Console.WriteLine("Ticket Price: Free");
            }
            else if(intAge>=6 && intAge <=14)
            {
                Console.WriteLine("Ticket Price: 8.99");
            } else if(intAge>14 && intAge<=65){
                Console.WriteLine("Ticket Price: 12.99");
            }else if(intAge>65 ) {
                Console.WriteLine("Ticket Price: 7.99");
            }else{
                Console.WriteLine("Enter valid number");
            }

            
        }
    }
}
