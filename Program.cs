using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace VariableSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first variable");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second variable");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before Swapping \nThe value of a = {a}\nThe value of b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine($"After Swapping \nThe value of a = {a}\nThe value of b = {b}");
        }
    }
}
