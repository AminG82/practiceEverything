using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nothing01
{
    public class AverageCalculator
    {
        public static float CaclulateAverageWithWhile()
        {
            float scour = 0;
            int count = 0;
            float sum = 0;

            while (scour != -1)
            {
                count++;
                Console.WriteLine("Enter a number to add to the average (or -1 to finish):");
                scour = Convert.ToSingle(Console.ReadLine());
                sum += scour;
            }
            return sum / count;
        }
    }
}
