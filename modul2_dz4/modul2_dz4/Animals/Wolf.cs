using modul2_dz4.description;
using modul2_dz4.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace modul2_dz4.Animals
{
    public class Wolf : DoggTeam
    {
        public Wolf(AnimalType animaltype, string name, double weight)
            : base(animaltype, name, weight)
        {
        }
    }
}
