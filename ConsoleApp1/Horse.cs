using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Horse
    {
        public void Speak(string horseName)
        {
            Console.WriteLine($"I am a horse named {horseName} and I say Neigh but also I might say other things. \n" +
                "Do you think it's weird that horses don't say Bud - Wies - er? Why do the frogs have all the fun?\n");
        }
    }
}
