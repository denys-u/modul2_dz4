using System;
using System.Collections.Generic;
using System.Text;
using modul2_dz4.enums;
namespace modul2_dz4.description
{
    public abstract class Animal
    {
        protected Animal(AnimalType Animaltype, string name, double weight)
        {
            Weight = weight;
        }
        public double Weight { get; }

        public abstract Squad Squad { get; }

        public abstract AnimalType AnimalType { get; }

        public abstract string Name { get; }
    }
}
