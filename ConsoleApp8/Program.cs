using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] { new Dog("Mickeeey"), new Cat("Garfield"), new Horse("Patrick"), new Pig("Porky"),};
            foreach (Animal animal in animals)
            {
                // Code review: how do you know if Mickeeey is a Dog?
                animal.MakeSound();
            
            }




        }

    }
}
