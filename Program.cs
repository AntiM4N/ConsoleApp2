using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp2
{
    public class Program
    {

        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());

            int temp = a % 2;


            Console.WriteLine($"temp --- {temp}");
        }

    }
}
