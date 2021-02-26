using modul2_dz4.Animals;
using modul2_dz4.description;
using modul2_dz4.Resualt;
using System;
using System.Collections.Generic;
using System.Text;

namespace modul2_dz4.Abstractions
{
    class PresentServise : IPresentServise
    {
        public PresentServise()
        {
        }

        public AnimalEnclosure NewAnimalEnclosure()
        {
            var animal = new Animal[]
            {
                new Lion(),
                new Aligator(),
                new Wolf(),
            };
        }
    }
}