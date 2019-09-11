using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Solution
    {
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

            double total = meal_cost + (meal_cost * (tip_percent / 100.00)) + (meal_cost * (tax_percent / 100.00));

            int roundedTotal = Convert.ToInt32(Math.Round(total));
            Console.WriteLine(roundedTotal);
        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
