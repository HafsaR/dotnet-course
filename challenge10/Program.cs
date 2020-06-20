using System;

namespace challenge10
{
    class Program
    {
        static void Main(string[] args)
        {
           /*10. Write a function that takes in a temperature (Celsius) and a string listing one of 5 substances:
            Water, Helium, Mercury, Ethanol, and Carbon Dioxide. 
            Return the "state" of the given substance at that temperature ("Solid", "Liquid", "Gas")
              Example: Input is 250 and "Water" -> Output is "Gas"*/

              /*
              Helium (He), chemical element, inert gas of Group 18 (noble gases) of the periodic table. The second lightest element (only hydrogen is lighter), helium is a colourless, odourless, and tasteless gas that becomes liquid at −268.9 °C (−452 °F). The boiling and freezing points of helium are lower than those of any other known substance. Helium is the only element that cannot be solidified by sufficient cooling at normal atmospheric pressure; it is necessary to apply pressure of 25 atmospheres at a temperature of 1 K (−272 °C, or −458 °F) to convert it to its solid form
              */
            Console.WriteLine("Enter temprature: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter substance: ");
            string substance = Console.ReadLine();
            state(temp,substance);

            // Console.WriteLine($"substance: {substance}, temprature: {temp}");




        }
        static void state(double temp, string s){
            string lowercaseSubstance = s.ToLower();
            switch(lowercaseSubstance){
                case "water": 
                        if(temp<=0){
                            Console.WriteLine($"At {temp}, the water state is solid.");
                        }else if(temp>=100){
                            Console.WriteLine($"At {temp}, the water state is Gas.");

                        }else{
                            Console.WriteLine($"At {temp}, the water state is Liquid.");

                        }
                        break;
                case "helium":
                        if(temp == -269){
                            Console.WriteLine($"At {temp}, the water state is liquid.");
                        }else if(temp== -272){
                            Console.WriteLine($"At {temp}, the water state is solid.");

                        }else{
                            Console.WriteLine($"At {temp}, the water state is gas.");

                        }
                        break;
                default: Console.WriteLine("No state:");
                        break;


            }
            
        }
    }
}
