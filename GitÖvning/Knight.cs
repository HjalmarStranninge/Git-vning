using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitÖvning
{
    internal class Knight
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public int Strength { get; set; }

        public void BattleSound()
        {
            Console.WriteLine("For Demacia!!!");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nHP: {HP}\nStrength: {Strength}");
        }
    }
}
