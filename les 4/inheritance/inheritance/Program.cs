using System;

namespace inheritance
{
    abstract class Equipment
    {
        public abstract void equip();
    }

    class test
    {
    static void Main(string[] args)
        {
            Equipment armor;
            armor = new Armor();
            armor.equip();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Equipment weapons;
            weapons = new Weapons();
            weapons.equip();
        }

    }
}
