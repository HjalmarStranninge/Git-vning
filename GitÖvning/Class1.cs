using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitÖvning
{
    internal class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Cat(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says meow!");
        }
    }
}
