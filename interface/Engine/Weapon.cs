using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine{
    public class Weapon : Item{

        public int MinimumDamage { get; set; } //minimum damage that the weapon can deal
        public int MaximumDamage { get; set; } //maximum damage that the weapon can deal

    }
}
