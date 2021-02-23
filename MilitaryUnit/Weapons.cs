using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    public class Weapons
    {
        
        private int ammunitionType;
        private string weaponName;
        private MagazineStack magazine;

        public Weapons(string name, int ammoType, int MagazineSize) 
        {
            this.weaponName = name;
            this.ammunitionType = ammoType;
            this.magazine = new MagazineStack(MagazineSize);
        }

        public Boolean IsEmpty() => magazine.IsEmpty();
        public Boolean IsFull() => magazine.IsFull();
        public virtual void FireWeapon() 
        {
            if (magazine.IsEmpty())
            {
                Console.WriteLine("CLICK. You need to re-load");
            }
            else
            {
                magazine.PullTrigger();
                Console.WriteLine("BANG BANG");
            }
        }

        public virtual void Reload() 
        {
            if (magazine.IsFull())
            {
                Console.WriteLine("Magazine Full!");
            }
            magazine.Reload();
            Console.WriteLine("Chak-chak **RELOADED**");
        }

    }
}
