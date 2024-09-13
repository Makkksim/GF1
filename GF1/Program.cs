using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            string name = "Kornienko Maxim";
            int age = 24;
            Console.WriteLine("Hello,my name is  {0}, I'm  {1} years old !", name, age);
            


            // task 2
            int a = 3;
            int b = 5;
            double result;
            result = (a - b) / (Math.Pow(a - b, 3) - (Math.Pow(a, 3) - 3 * Math.Pow(a, 2)) * b / (Math.Pow(b, 3) - 3 * Math.Pow(a, 2) * b));
            Console.WriteLine("result = {0}", result);
            

            // task 3
            int input, output;
            Console.Write("Введіть трьохцифрове число:" );
            input = Convert.ToInt32(Console.ReadLine());
            output = (input % 10 * 100 + (input % 100 / 10 * 10) + (input / 100));
            Console.WriteLine ($"{input} -- > {output}");
            Console.ReadKey();
            

        }   
    }
}
