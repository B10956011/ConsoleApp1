using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            int total = (int)(meal_cost + tip_percent + tax_percent);
            Console.WriteLine("用餐費用：" + meal_cost);
            Console.WriteLine("服務費：" + tip_percent);
            Console.WriteLine("稅率：" + tax_percent);
            Console.WriteLine("總共：" + total);

        }
    }
}
