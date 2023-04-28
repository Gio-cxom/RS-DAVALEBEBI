using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //Console.WriteLine("Enter any number:");
            //a = int.Parse(Console.ReadLine());

            //FIRST TASK
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}

            //SECOND TASK
            //int factorial = 1;
            //int number;
            //for (number = 1; number <= a; number++)
            //{
            //    factorial = factorial * number;
            //}
            //Console.WriteLine("Factorial of" + number + "is:" + factorial);

            // THIRD TASK
            //double  b, c, d;
            //d = double.Parse(Console.ReadLine());
            //b = double.Parse(Console.ReadLine());
            //c = double.Parse(Console.ReadLine());
            //if(d+b!=c & d + b > c & c>d & c>b)
            //{
            //    Console.WriteLine("Triangle");
            //}
            //else
            //{
            //    Console.WriteLine("not triangle");
            //}
            //FOURTH TASK
            //b = 43;
            //if (b % 1== b &  b % b==1)
            //{
            //    Console.WriteLine("EASY");
            //}
            //else
            //{
            //    Console.WriteLine("NOPE");
            //}
            //FIFTH TASK
            //int i;
            //int b;
            //b = 0;

            //for (i = 1; i < a; i++)
            //{

            //    if (a % i == 0)
            //    {
            //        b = b + i;
            //    }

            //}
            //if(b == a)
            //{
            //    Console.WriteLine("perfect");
            //}
            //else
            //{
            //    Console.WriteLine("FALSE");
            //}
            //SIXTH TASK
            //int[] myArray = { 2, 3, 5, 6, 8, 9, 10,556 };
            //int maxValue = myArray[0];
            //for(int i=1; i<myArray.Length; i++)
            //{
            //    if (myArray[i] > maxValue)
            //    {
            //        maxValue = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxValue);
            //SEVENTH TASK
            //int i, n, even = 0, odd = 0;
            //int[] b = { 1, 2, 3, 4, 5,6 };
            //for(i=0; i < b.Length; i++)
            //{
            //    if (b[i] % 2 == 0)
            //    {
            //        even = even;
            //        even++;
            //    }
            //    else
            //    {
            //        odd = odd;
            //        odd++;
            //    }

            //}
            //Console.WriteLine("Even terms are: " + even);
            //Console.WriteLine("Odd terms are: " + odd);
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c = double.Parse(Console.ReadLine());

            double x1, x2;
            var D = b*b-4*a*c;
            if (D < 0)
            {
                Console.WriteLine("Pesvi ar aq");
            }
            else
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }
        }
    }
}