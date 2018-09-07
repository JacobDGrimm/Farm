using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cow
    {
        public void speak()
        {
            Console.WriteLine($"I am a cow and sometimes I say 'moo' but sometimes I wish I \n" +
                $"could say something to farmer Ted about his roaming hands...\n");
        }
        public void Eat()
        {
            Console.WriteLine("Yum! I love eating grass, but sometimes I like to eat other\n" +
                "cows. Who wants mad cow disease?!");
        }
        public void Produce()
        {
            Console.WriteLine("I make milk, and that milk makes cheese so that's pretty great.");
        }
        public void move()
        {
            Console.WriteLine("As a cow I just mosey around, sometimes I move in a herd.");
        }
    }
}
