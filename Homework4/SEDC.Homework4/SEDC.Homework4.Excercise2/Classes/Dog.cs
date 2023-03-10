using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework4.Excercise2.Classes
{
    public class Dog
    {
        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;

        }

        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public void Eat()
        {
            Console.WriteLine($"The dog {Name} is now eating");
        }

        public void Play()
        {
            Console.WriteLine($"The dog {Name} is now playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine($"The dog {Name} is now chasing it's tail");
        }

    }
}
