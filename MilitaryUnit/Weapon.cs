using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Weapon
    {
        
        protected readonly double ammunitionType;
        protected readonly string weaponName;
        protected readonly MagazineStack magazine;
        protected readonly int roundsPerMinute;


        public Weapon(string name, double ammoType, int MagazineSize, int RPM) 
        {
            this.weaponName = name;
            this.ammunitionType = ammoType;
            this.magazine = new MagazineStack(MagazineSize);
            this.roundsPerMinute = RPM;
        }

        protected Boolean IsEmpty() => magazine.IsEmpty();
        protected Boolean IsFull() => magazine.IsFull();

        protected double GetAmmunitionType() => ammunitionType;

        protected int GetRPM() => roundsPerMinute;
        protected string GetWeaponName() => weaponName;
        public virtual void FireWeapon() 
        {
            if (magazine.IsEmpty())
            {
                Console.WriteLine("CLICK. You need to re-load");
            }
            else
            {
                magazine.popRound();
                Console.WriteLine("BANG BANG");
            }
        }

        public virtual void Reload() 
        {
            if (magazine.IsFull())
            {
                Console.WriteLine("Magazine Full!");
            }
            else
            {
                magazine.Reload();
                Console.WriteLine("Chak-chak **RELOADED**");
            }
        }

        public virtual int AmmoRemaining() 
        {
            if (magazine.IsEmpty()) 
            {
                return 0;
            }
            return magazine.Top() + 1;
        }

    }
}
