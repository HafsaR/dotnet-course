using System;

namespace datatypeEx
{
    class Program
    {
        static void Main(string[] args)
        {
               /*
            // Integral types
            byte a = 256;
            byte b = -1;
            sbyte c = 127;
            sbyte d = 128;
            sbyte e = -1;
            sbyte f = -127;
            sbyte f = -128;
            short g = 50000;
            short h = -50000;
            short i = 25000;
            short j = -25000;
            ushort k = 50000;
            ushort l = -50000;
            ushort m = 100000;
            ushort n = -100000;
            int o = 123456789;
            int p = -123456789;
            int q = 112233445566;
            int r = 3213213213;
            uint s = 3213213213;
            uint t = -123456789;
            uint u = 999999999
            long v = 1234567890123456789;
            long w = -1234567890123456789;
            long x = 12345678901234567890;
            ulong y = 12345678901234567890;
            ulong z = -123456789;
            */
            /*
            // Floating Point types
            float a = 1;
            float b = 1.5;
            float c = 1.5f;
            float d = 1234567890;
            float e = 1234567890;
            float f = 876543210;
            float g = 876543211;
            float h = 876543219;
            float i = 876543249;
            float j = 12.3456789f;
            float k = 123456.789f;
            float l = 12345678.9f;
            float l = 12345678.9f;
            float m = -12345678.9f;
            double n = 1.234567890;
            double o = 1.234567890123456;
            double p = 1.2345678901234567890;
            double p = -1.2345678901234567890;
            double q = 0.000000000000000000000000123;
            double r = 1.000000000000000000000000123;
            decimal s = 1.000000000000000000000000123m;
            decimal t = 1.23456789;
            decimal u = 123456789;
            */
            /*
            // Other types
            bool a = 1;
            bool b = "true";
            bool c = True;
            bool d = true;
            char e = "";
            char f = "f";
            char g = 'g';
            char h = '';
            char i = ' ';
            char j = '_';
            char k = '0';
            string l = 'abc';
            string m = "abc";
            string n = "";
            string o = '';
            string p = " ";
            string q = true;
            string r = "T";
            string s = 'T';
            */
            /*
            // Integral Conversions
            int a = 1;
            byte x = a;
            int a = 1;
            byte x = Convert.ToByte(a);
            int a = 500;
            byte x = Convert.ToByte(a);
            int a = 500;
            short x = Convert.ToInt16(a);
            int a = -500;
            ushort x = Convert.ToUInt16(a);
            int a = 500;
            long x = a;
            int a = 500;
            ulong x = a;
            int a = -500;
            ulong x = Convert.ToUInt64(a);
            int a = 500;
            long x = Convert.ToUInt64(a);
            long a = 500;
            int x = a;
            long a = 500;
            int x = Convert.ToInt32(a);
            long a = 500;
            sbyte x = Convert.ToSByte(a);
            */
            /*
            // Floating point conversions
            float a = 1.23456789f;
            double x = a;
            float a = 1.23456789f;
            decimal x = a;
            float a = 1.23456789f;
            decimal x = Convert.ToDecimal(a);
            double a = 1.23456789;
            float x = a;
            double a = 1.23456789;
            float x = Convert.ToSingle(a);
            double a = -1.23456789;
            decimal x = a;
            double a = -1.234567890123456789;
            decimal x = Convert.ToDecimal(a);
            decimal a = -1.23456789m;
            float x = a;
            decimal a = -1.23456789m;
            float x = Convert.ToSingle(a);
            decimal a = -1.23456789m;
            double x = a;
            decimal a = -1.23456789m;
            double x = Convert.ToDouble(a);
            */
            /*
            // Mixed conversions
            int a = -2;
            float x = a;
            int a = -30000001;
            float x = a;
            float a = 12345;
            int x = a; 
            float a = 12345.6f;
            int x = a; 
            float a = 12345.6f;
            int x = Convert.ToInt32(a);
            long a = 123456789;
            float x = a;
            long a = 123456789;
            double x = a;
            long a = 123456789;
            decimal x = a;
            decimal a = 12345;
            int x = a;
            decimal a = 12345;
            int x = Convert.ToInt32(a);
            decimal a = 1.234567890m;
            int x = Convert.ToInt32(a);
            int a = 1;
            string x = a;
            int a = 1;
            string x = Convert.ToString(a);
            string a = "hello";
            int x = Convert.ToInt32(a);
            string a = "1";
            int x = Convert.ToInt32(a);
            */
            bool a = true;
            Console.WriteLine(a.ToString().ToLower());
            int x = 5;
            Console.WriteLine(x>6);
            
            double result = Math.Pow(5,2);
            Console.WriteLine("Result is: "+result);
            double f = 3+4 *  -8 + 2 / 4 +(5-4);
            Console.WriteLine("formula result is : "+ f);

            //conditional
            //loops

            

        }
    }
}
