using modul2_dz4.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace modul2_dz4.description
{
    public abstract class CatsTeam: Animal
    {
        public CatsTeam(AnimalType animaltype, string name, double weight)
            :base(animaltype,name,weight)
        {
        }
    }
}
