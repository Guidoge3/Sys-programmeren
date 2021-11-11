using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class Weapons : Equipment
    {
        public override void equip()
        {
            Console.WriteLine("Equip Weapon from the equipment class");
        }
    }
}
