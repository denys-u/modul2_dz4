using System;
using System.Collections.Generic;
using System.Text;
using modul2_dz4.enums;
namespace modul2_dz4.description
{
    public abstract class Animal
    {
        protected Animal(AnimalType animaltype, double weight)
        {
            Weight = weight;
        }
        public double Weight { get; }
    }
}
