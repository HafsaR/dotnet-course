using System;

namespace challenge13
{
    class Program
    {
        static void Main(string[] args)
        {
                        /*
                13. Write a function similar to our cat-buying algorithm from unit 1. 
                    Input parameters: colour of the cat, gender of the cat, is the cat neutered/spayed
                    Return value: boolean - true if we will buy the cat, false if not
                    Rules: Cat must be one of the following
                    - A male cat that is neutered, and either white or orange
                    - A female cat that is neutered (spayed), any color but white
           */
           Console.WriteLine("Enter color of the cat: ");
           string color = Console.ReadLine();
           Console.WriteLine("Gender: ");
           string gender = Console.ReadLine();
           Console.WriteLine( "Is the cat spayed/neutered?");
           bool spayed = Convert.ToBoolean(Console.ReadLine());

           bool buycat = buyCat(color,gender,spayed);
           if(buycat == true){
               Console.WriteLine("We'll buy the cat");
           }else{
               Console.WriteLine("Won't buy the cat");
           }
        //    Console.WriteLine($"{buycat}");

        }
        static bool buyCat(string color, string gender, bool sp){
            if(gender == "male" && sp == true && (color == "white" || color == "orange")){
                return true;
            }else if(gender == "female" && sp == true && color !="white"){
                return true;
            }else{
                return false;
            }
        }
    }
}
