using System;

namespace print_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //print array
            int[] number = {1,25,35,25,100};
            string[] array = {"hafsa","raees","ikhlas"};
           print_array(number);
           print_array(array);

        }
        static void print_array(int[] n){
            for(int i=0;i<n.Length;i++){
                Console.WriteLine($"{n[i]}");
            }

        }
        static void print_array(string[] s){
             for(int i=0;i<s.Length;i++){
                Console.WriteLine($"{s[i]}");
            }
        }
    }
}
