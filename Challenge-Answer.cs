using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the sum of each set of numbers.
            //Find the average of ALL the numbers.

            var numbers = new List<List<double>>
            {
                new List<double> {5,11,87,49,52,99},
                new List<double> {20,5,67,34,12},
                new List<double> {92,57,91,77,45,29,56,38,18,68,92,26,42,55,46},
                new List<double> {56,18,10,92,54,14,84,79},
                new List<double> {32,34,27,1.1,87,24,97},
                new List<double> {93,2,78,45,96,94,16,74,99,14,33},
                new List<double> {72,41,56,89,12,45,68,29,83,78,58,17,11,69},
                new List<double> {29,26,38,96,99,2,54},
                new List<double> {41,48,24,25,63,11,39},
                new List<double> {4,27,40,88,10,59,90}
            };


            double sumOFAllTheNumbers = 0;
            double count = 0;

            foreach (var row in numbers)
            {
                Console.WriteLine(row.Sum());
                count += row.Count();
                sumOFAllTheNumbers += row.Sum();
            }

            Console.WriteLine(sumOFAllTheNumbers);
            Console.WriteLine(count);
            Console.WriteLine(sumOFAllTheNumbers / count);

            //another way!
            sumOFAllTheNumbers = numbers.Sum(x => x.Sum());
            count = numbers.Sum(x => x.Count());
            Console.ReadLine();
        }
    }


}

