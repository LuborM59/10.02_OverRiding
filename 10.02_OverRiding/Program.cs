using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._02_OverRiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            Cat cat = new Cat();

            Console.WriteLine("Ryba: "+fish.makeSound());
            Console.WriteLine("Cica: " + cat.makeSound());

        }

        class Animal
        {
            public virtual string makeSound()
            {
                return "";
            }
        }

        class Fish : Animal
        {

        }

        class Cat : Animal
        {
            public override string makeSound()
            {
                return "Mnau";
            }
        }
    }
}
