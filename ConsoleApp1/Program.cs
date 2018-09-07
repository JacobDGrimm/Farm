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

            void Farm()
            {
                Horse MrEd = new Horse();
                Chicken ChickenJuan = new Chicken();
                Cow CowBetsy = new Cow();
                PIg PigBabe = new PIg();

                Console.WriteLine("All the animals on this farm are different so lets here from them starting with the horse.\n");
                MrEd.Speak("Mr Ed");
                MrEd.Produce();
                MrEd.Eat();
                MrEd.Move();
                Console.WriteLine("Now lets here from Chicken Juan\n");
                ChickenJuan.Speak();
                ChickenJuan.Produce();
                ChickenJuan.Eat();
                ChickenJuan.Move();
                Console.WriteLine("What about Babe the pig?\n");
                PigBabe.Speak();
                PigBabe.Produce();
                PigBabe.Eat();
                PigBabe.Move();
                Console.WriteLine("And finally lets here from Betsy the cow.\n");
                CowBetsy.speak();
                CowBetsy.Produce();
                CowBetsy.Eat();
                CowBetsy.move();
            }
            Farm();
        }
        
    }
}
