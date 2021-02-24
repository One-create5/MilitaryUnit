using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class SmallCaliberWeapon : Weapon
    {
        private const int LOWERDAMAGE = 1000;
        private double damage;


        public double Damage
        {
            get
            {
                return damage;
            }

        }

        public SmallCaliberWeapon(string name, double ammoType, int MagazineSize, int RPM) : base(name, ammoType, MagazineSize, RPM) 
        {
            damage = (ammoType * RPM) / LOWERDAMAGE;
        }

        public override string ToString()
        {
            return $"Weapon Name: {weaponName} Ammuntioin: {ammunitionType} Magazine Size: {magazine.Top()}";
        }

    }
}
