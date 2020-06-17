using System;

namespace binary_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary to decimal conversion

            Console.WriteLine("Enter Binary number");
            string inputNumber = Console.ReadLine();
            //int intNumber = Convert.ToInt32(inputNumber);
            int original = ConvertBinaryToBase10(inputNumber);
            Console.WriteLine("decimal  number of "+inputNumber+" is : "+original);
            
  }

  static int ConvertBinaryToBase10(string binary){
      int sum = 0;
      string reverseBinaryNumber = reverseString(binary);
      Console.WriteLine(reverseBinaryNumber);
      for(int i=0;i<binary.Length;i++){
          double powerOfTwo = Math.Pow(2,i);
          int intPowerofTwo = Convert.ToInt32(powerOfTwo);
          if(reverseBinaryNumber[i] == '1'){
              sum += intPowerofTwo;
          }

        Console.WriteLine($"{reverseBinaryNumber}-> {i}..........{powerOfTwo}..........{sum}");

      }
      return sum;
  }

  static string reverseString(string s){
      string result = "";
      for(int i=s.Length-1;i>=0;i--){
          result += s[i];

      }
      return result;
  }
        
   
    }
}
