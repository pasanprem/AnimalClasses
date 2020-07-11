using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Dog : Animal
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
    }
}
