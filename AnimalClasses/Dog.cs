using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Dog : Animal , IDomesticated
    {
        public Dog(bool isAlive, int w) : base(isAlive, w)
        {
        }

        public void Talk()
        {
            Console.WriteLine("Bark bark bark");
        }

        public void Sing()
        {
            Console.WriteLine("Ooooowwwwoooo");
        }

        public void Fetch(string thing)
        {
            Console.WriteLine("Here you go. Here is your " + thing + ". That was fun lets do it again!");
        }

        public void TouchMe()
        {
            Console.WriteLine("Please scratch behind my ears.");
        }

        public void FeedMe()
        {
            Console.WriteLine("Suppertime! Best time of the day.");
        }
    }
}
