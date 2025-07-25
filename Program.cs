using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            var numberStr = Console.ReadLine();
            int num = 0;
            while (!Int32.TryParse(numberStr, out num) || num <= 0)
            {
                Console.WriteLine("Error: try again!");
                Console.Write("Enter an integer: ");
                numberStr = Console.ReadLine();
            }

            List<int> numbers = new List<int>();
            for (int i = 3; i <= num; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join("+", numbers) + " = " + numbers.Sum());
        }
    }
}
