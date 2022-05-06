using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Program
    {
        static void Main(string[] args)
        {
            string expenc = Drug.ExpensiveDrug();
            Console.WriteLine(expenc);
            Console.ReadKey();
        }
    }
}
