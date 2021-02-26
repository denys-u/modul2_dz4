using modul2_dz4.description;
using modul2_dz4.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace modul2_dz4.Animals
{
    public class Lion : CatsTeam
    {
        public Lion(AnimalType animaltype, string name, double weight)
            : base(animaltype, name, weight)
        {
        }

        public override string Name => "Lion";

        public override AnimalType AnimalType => AnimalType.Mammals;

        public override Squad Squad => Squad.Predator;
    }
}
