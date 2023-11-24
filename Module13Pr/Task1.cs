using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13Pr
{
    public class Task1
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 3,4,5,3,2,1,8,9,0,8 };
            FindAndPrintSecondMax(numbers);

            RemoveOddNumbers(numbers);
            Console.WriteLine("List after delete:");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.ReadKey();
        }
        static void FindAndPrintSecondMax(List<int> numbers)
        {
            if (numbers.Count < 2)
            {
                Console.WriteLine("There are not enough items in the collection to search for the second maximum value.");
                return;
            }
            int secondMax = numbers.OrderByDescending(n => n).Skip(1).First();
            Console.WriteLine($"Position and value of the second maximum element: {numbers.IndexOf(secondMax)}, {secondMax}");
        }

        static void RemoveOddNumbers(List<int> numbers)
        {
            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            numbers.Clear();
            numbers.AddRange(evenNumbers);
        }
    }
}
