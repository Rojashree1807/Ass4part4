using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppAss4part4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter integer #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int inputValue))
                {
                    numbers[i] = inputValue;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    i--; 
                }
            }

            Console.WriteLine("Array: [" + string.Join(", ", numbers) + "]");

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"\nSum of the elements: {sum}");
            Console.WriteLine($"Average of the elements: {average:F2}");
            Console.ReadKey();
        }
    }
}
