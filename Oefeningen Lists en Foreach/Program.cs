using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_Lists_en_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prijzen = new double[20];
            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.Write("Geef een prijs in: ");
                prijzen[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Clear();
            foreach (var item in prijzen)
            {
                if (item >= 5.00)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine($"Het gemidelde is: {prijzen.Average()}");
            Console.ReadLine();
        }
    }
}
