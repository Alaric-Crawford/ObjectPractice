using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Sword
    {
        public string SwordName { get; set; }
        public string SwordClass { get; set; }
        public string CountryOrigin { get; set; }

        public Sword(string title, string type, string country)
        {
            this.SwordName = title;
            this.SwordClass = type;
            this.CountryOrigin = country;
        }
    }
}
