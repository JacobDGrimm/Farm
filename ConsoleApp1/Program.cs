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
            var MrEd = new Horse();
            var ChickenJuan = new Chicken();
            var CowBetsy = new Cow();
            var PigBabe = new PIg();

            MrEd.Speak("Mr Ed");
            ChickenJuan.Speak();
            CowBetsy.speak();
            PigBabe.Speak();
        }
    }
}
