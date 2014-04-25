using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Sword
    {
        public string TwoHanded { get; set; }
        public string OneHanded { get; set; }
        public string DualBladed { get; set; }

        public void TwoHands(string swordName)
        {
            this.TwoHanded = swordName;
        }
        public void OneHand(string bladeName)
        {
            this.OneHanded = bladeName;
        }
        public void DualWield(string dualNames)
        {
            this.DualBladed = dualNames;
        }
    }
}
