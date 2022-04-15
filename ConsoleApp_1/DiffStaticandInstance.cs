using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    internal class DiffStaticandInstance
    {
        public static void Main()
        {
            static_method();
            DiffStaticandInstance a=new DiffStaticandInstance();
            a.instance_method();
        }
        public static void static_method()
        {
            Console.WriteLine("Welcome to static method");
        }
        public void instance_method()
        {
            Console.WriteLine("Welcome to instance method");
        }
    }
}
