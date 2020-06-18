using System;

namespace discount_flag
{
    class Program
    {
        static void Main(string[] args)
        {
                /*
        9. Write a function that takes in the price of an item and a "discount" flag.
        Apply a 15% tax to the price. If the discount flag is toggled, then take $2 off the price.
        */

        Console.WriteLine("Enter price: ");
        double itemCost = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter flag");
        string flag = Console.ReadLine();
        Console.WriteLine($"Item cost is ${itemCost}");
        double totalCost = discount_flag(itemCost,flag);
        Console.WriteLine($"Total cost of item is {totalCost}");

        }
        static double discount_flag(double cost,string flag){
            if(flag.Equals("discount")){
                double salesTax=15;
                double tax = salesTax/100;
            
                double totalSalesTax = cost * tax;
            
                double total = cost + totalSalesTax;
               
                return total;

            }else if(flag.Equals("toggled")){
                double total = cost - 2;
                Console.WriteLine("total: "+total);
                return total;
            }else{
                return cost;
            }

           
        }
    }
}
