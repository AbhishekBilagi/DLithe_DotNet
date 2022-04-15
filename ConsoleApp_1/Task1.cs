using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    internal class Task1
    {
        public static void Main()
        {
            //getTraineeDetails();
            //if_elseConcept();
            calculator();
            //sumOfNaturalNum();
            //breakAndContinue();

        }
        public static void getTraineeDetails() 
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter City");
            string city=Console.ReadLine();

            Console.WriteLine($"Name is:{name} Age is:{age} City is:{city}");
        }
        public static void if_elseConcept()
        {
            int sub1 = 95;
            int sub2 = 98;
            int sub3 = 85;
            int total = 0;
            int avg = 0;
            if (sub1 > 90)
            {
                total = sub1+sub2 + sub3;

            }
            else
            {
                avg = total / 3;
            }
            Console.WriteLine($"Total is {total}");
        }
        public static void calculator()
        {
            Console.WriteLine("Enter first number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2=Convert.ToInt32(Console.ReadLine());
            int num3 = 0;
            Console.WriteLine("1.Add\n2.Substract\n3.Multiplication\n4.Division");
            Console.WriteLine("Enter your choice");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:  num3 = num1 + num2;
                    Console.WriteLine(num3);
                       break;
                case 2: num3 = num1 - num2;
                    Console.WriteLine(num3);
                    break;
                case 3: num3 = num1 * num2;
                    Console.WriteLine(num3);
                    break;
                case 4: num3= num1 / num2;
                    Console.WriteLine(num3);
                    break;
                 default: Console.WriteLine("Please Enter correct choice");
                    break;

            }
           
        }
        public static void sumOfNaturalNum()
        {
            Console.WriteLine("Please enter range");
            int num = Convert.ToInt32(Console.ReadLine());
            int i=0;
            int sum = 0;
            while (i <= num)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"Sum of natural number is :{sum}");
        }
        public static void breakAndContinue()
        {
            for (int i = 0; i < 5; i++) 
            {
              Console.WriteLine(i);
                break;
            }
            Console.WriteLine("--------------------------------------");
            for (int j = 0; j < 5; j++)
            {
                if (j == 2)
                {
                    continue;
                }
                Console.WriteLine(j);
            }

        }
    }
}
