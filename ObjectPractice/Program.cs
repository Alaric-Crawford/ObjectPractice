using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var england = new Sword("claymore", "two-handed");
            Console.WriteLine("The " + england.SwordName + " is a lightweight " + england.SwordClass + " blade.");

            var german = new Sword("zweihander", "two-handed");
            Console.WriteLine("The " + german.SwordName + " is a heavy " + german.SwordClass + " blade.");

            var turkey = new Sword("tulwar", "one-handed");
            Console.WriteLine("The " + turkey.SwordName + " is a medium weight " + turkey.SwordClass + " blade.");

            Console.ReadKey();
        }
    }
}
