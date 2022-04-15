using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    internal class Constructors
    {
        public Constructors()
        {
            int sid = 1;
            string sname = "john";
            Console.WriteLine("No parameter constructor");
        }
        public Constructors(int a,int b)
        {
            Console.WriteLine("Two parameter constructor");
        }
        public Constructors(int a, int b,string c)
        {
            Console.WriteLine("Three parameter constructor");
        }
        public Constructors(int a, int b,int c,double d)
        {
            Console.WriteLine("four parameter constructor");
        }
        public static void Main()
        {
            //No argument Constructors
            Constructors c=new Constructors();
            // Two parameter constructor
            Constructors c1=new Constructors(10,20);
            // Three parameter constructor
            Constructors c2=new Constructors(10,20,"John");
            //four parameter constructor
            Constructors c3 = new Constructors(10, 20, 30, 25.25);

        }
    }
}
