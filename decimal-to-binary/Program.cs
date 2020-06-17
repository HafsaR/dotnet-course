using System;

namespace decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decimal to Binary
            Console.WriteLine("Enter decimal number");
            string SNumber = Console.ReadLine();
            decimal number = Convert.ToDecimal(SNumber);
            
         // decimal number =33m;
          int intNumber = Convert.ToInt32(number);
         
          int dividen=intNumber/2,remainder = intNumber%2;
        string firstRemainder = Convert.ToString(remainder),
                firstDividen = Convert.ToString(dividen),
                stringBinaryNumber ="";

          string result = firstRemainder + "",stringRemainder = firstRemainder + "" ,finalResult = firstDividen + "" ;
       
          
          Console.WriteLine(number.GetType().FullName);
            
          
        
          while(dividen!=0){
            
             
             int i = dividen/2;
            remainder = dividen%2;
             stringRemainder= remainder.ToString();
             result += stringRemainder ;
             Console.WriteLine("Remainder: "+remainder);
          Console.WriteLine("dividen: "+dividen);
          dividen = i;
          }
        
            Console.WriteLine("result: "+result);
            int len = result.Length;
            Console.WriteLine(len);
           for(int j =len-1;j>=0;j--){
              stringBinaryNumber += result[j];
           }
        
           Console.WriteLine("Binary number : "+ stringBinaryNumber);
 }
    }

}
