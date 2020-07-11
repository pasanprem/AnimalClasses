using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Program
    {
        static void Main(string[] args)
        { 
            Animal beast = new Animal(true, 100);

            beast.Greet();
            beast.Talk();
            beast.Sing();

            Console.WriteLine(beast.ToString());

            Dog fido = new Dog(false, 25);
            fido.Greet();
            fido.Talk();
            fido.Sing();
            fido.Fetch("stick");

            Console.WriteLine(fido.ToString());

            Console.ReadLine();
        }
    }
}
