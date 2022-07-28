using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }
        public Dog(string dog, string habitat,string eatingHabit)
        {
            Name=dog;
            Habitat=habitat;
            EatingHabit=eatingHabit;
        }
        
        
        
        
        
        public void DisplayName()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Habitat: "+Habitat);
            Console.WriteLine("Eating Habit: "+EatingHabit);
        }
    }
}