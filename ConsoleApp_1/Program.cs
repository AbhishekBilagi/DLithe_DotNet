using System;
//commite ctr+k+C
//uncommite ctr+k+u

namespace Test
{
    public class Demo
    {
        public static void Main()
        {
            int a = 25;
            //string formatter
            Console.WriteLine("Int value is: {0}",a);

            float b = 45.25f;
            double c = 56.25635;
            Console.WriteLine("Float value is:{0} Double value is {1}", b,c);

            string s = "Abhi";
            //String Interpolation
            Console.WriteLine( $"String value is {s}");

            bool e=true;
            char ch = 'A';
            Console.WriteLine($"Boolean is:{e} char is:{ch}");
        }
    }
}
