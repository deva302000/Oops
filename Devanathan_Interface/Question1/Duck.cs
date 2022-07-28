using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Duck : IAnimal
    {
         public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }
        public Duck(string duck, string habitat,string eatingHabit)
        {
            Name=duck;
            Habitat=habitat;
            EatingHabit=eatingHabit;
        }
        public void DisplayName()
        {
            Console.WriteLine("Duck Name: "+Name);
            Console.WriteLine("Habitat: "+Habitat);
            Console.WriteLine("Eating Habit: "+EatingHabit);
        }
    }
}