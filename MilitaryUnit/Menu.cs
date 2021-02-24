using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Menu
    {
      
        public void Display() 
        {
            Console.WriteLine("Welcome to Military Unit the game!");
            Console.WriteLine("How to play:\n(1) Pick a player\n(2) Pick your rank\n(3) Pick a weapon\n(4) PREPARE TO GO TO WAR!\n");
        }

        public int GetPlayer() 
        {
            int choice;

            do
            {
                Console.WriteLine("Pick a player!");
                Console.WriteLine("Enter 1: Supreme General (Officer)");
                Console.WriteLine("Enter 2: Sergeant (Enlisted)");
                choice = Int32.Parse(Console.ReadLine());
             
            }
            while (choice != 1 && choice !=2);
            return choice;
        }

        public OfficerRank GetOfficerRank() 
        {
            int choice;
            do
            {
                Console.WriteLine("Pick your rank!");
                Console.WriteLine("Enter 1: Second Lieutenant");
                Console.WriteLine("Enter 2: Firest Lieutenant");
                Console.WriteLine("Enter 3: Captain");
                Console.WriteLine("Enter 4: Major");
                Console.WriteLine("Enter 5: Lieutenant Colonel");
                Console.WriteLine("Enter 6: Colonel");
                choice = Int32.Parse(Console.ReadLine());
            }
            while (choice > 6 && choice <= 0);

            return choice switch
            {
                1 => OfficerRank.SecondLT,
                2 => OfficerRank.FirstLT,
                3 => OfficerRank.Capt,
                4 => OfficerRank.Maj,
                5 => OfficerRank.LtCol,
                6 => OfficerRank.Col,
                _ => OfficerRank.SecondLT,
            };
        }

        public EnlistedRank GetEnlistedRank() 
        {
            int choice;
            do
            {
                Console.WriteLine("Pick your rank!");
                Console.WriteLine("Enter 1: Private");
                Console.WriteLine("Enter 2: Private First Class");
                Console.WriteLine("Enter 3: Lance Corporal");
                Console.WriteLine("Enter 4: Corporal");
                Console.WriteLine("Enter 5: Sergeant");
                Console.WriteLine("Enter 6: Staff Sergeant");
                Console.WriteLine("Enter 7: Gunnery Sergeant");
                Console.WriteLine("Enter 8: First Sergeant");
                Console.WriteLine("Enter 9: Sergeant Major");
                choice = Int32.Parse(Console.ReadLine());
            }
            while (choice > 9 && choice <= 0);

            return choice switch
            {
                1 => EnlistedRank.Pvt,
                2 => EnlistedRank.Pfc,
                3 => EnlistedRank.LCpl,
                4 => EnlistedRank.Cpl,
                5 => EnlistedRank.Sgt,
                6 => EnlistedRank.SSgt,
                7 => EnlistedRank.GySgt,
                8 => EnlistedRank.FirstSgt,
                9 => EnlistedRank.SgtMaj,
                _ => EnlistedRank.Pvt,
            };

        }

        public int GetWeapon() 
        {
            int choice;

            do
            {
                Console.WriteLine("NOW ITS TIME TO PICK YOUR WEAPON!");
                Console.WriteLine("Enter 1: M16");
                Console.WriteLine("Enter 2: M4");
                Console.WriteLine("Enter 3: AK-74");
                Console.WriteLine("Enter 4: FN SCAR");
                Console.WriteLine("Enter 5: FAMAS G2");
                Console.WriteLine("Enter 6: AK-47");
                choice = Int32.Parse(Console.ReadLine());
            }
            while (choice > 7 || choice <= 0);

            return choice;
        }

    }
}
