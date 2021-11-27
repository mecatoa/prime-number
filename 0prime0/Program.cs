using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0prime0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int n = int.Parse(Console.ReadLine());
            bool Prime = true;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Prime = false;
                    break;
                }
            }
            if (Prime)
            {
                Console.WriteLine("This Number Is Prime");
            }
            else
            {
                Console.WriteLine("This Number Isn't Prime");
            }
        }
    }
}
