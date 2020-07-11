using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Animal
    {

        Boolean isAlive { get; set; }
        int weight { get; set; }

        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        public Animal(Boolean isAlive, int w)
        {
            this.isAlive = isAlive;
            this.weight = w;

            Console.WriteLine("Animal Constructor");
        }

        public void Greet()
        {
            Console.WriteLine("Animal says 'hello'");
        }

        public void Talk()
        {
            Console.WriteLine("Animal is talking");
        }

        public void Sing()
        {
            Console.WriteLine("Animal is singing");
        }

        override public string ToString()
        {
            return "Status: " + isAlive + " Weight: " + weight;
        }
    }
}
