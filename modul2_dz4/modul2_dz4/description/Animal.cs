using System;
using System.Collections.Generic;
using System.Text;
using modul2_dz4.enums;
namespace modul2_dz4.description
{
    public abstract class Animal
    {
        protected Animal(AnimalType animaltype, string name, double weight)
        {
            Weight = weight;
            Name = name;
        }
        public double Weight { get; }

        public AnimalType animaltype { get; }
        
        public string Name { get; }
    }
}
