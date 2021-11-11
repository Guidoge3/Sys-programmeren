using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class Armor : Equipment
    {
        public override void equip()
        {
            Console.WriteLine("Equip Armor from the equipment class");
        }
    }
}