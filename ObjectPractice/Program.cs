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
            //var england = new Sword("claymore", "two-handed", "English");
            //Console.WriteLine("The " + england.SwordName + " is a lightweight " + england.SwordClass + england.CountryOrigin + " blade.");

            //var germany = new Sword("zweihander", "two-handed", "German");
            //Console.WriteLine("The " + germany.SwordName + " is a heavy " + germany.SwordClass + germany.CountryOrigin + " blade.");

            //var turkey = new Sword("tulwar", "one-handed", "Turkish");
            //Console.WriteLine("The " + turkey.SwordName + " is a medium weight " + turkey.SwordClass + turkey.CountryOrigin + " blade.");

            
            VideoGame EverQuest = new VideoGame("Everquest", "MMORPG", "We got code here!");
            EverQuest.Play();
            EverQuest.Awesomeness = 9;
            EverQuest.Rating = "T";
            EverQuest.Code = "Better code!";
            EverQuest.Play();

            Console.ReadKey();
        }
    }
}
