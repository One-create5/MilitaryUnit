using System;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallCaliberWeapon m16 = new SmallCaliberWeapon("M16", 5.56, 3, 750);
            SmallCaliberWeapon m4 = new SmallCaliberWeapon("M4", 5.56, 3, 750);
            SmallCaliberWeapon ak74 = new SmallCaliberWeapon("AK-74", 5.45, 3, 600);
            SmallCaliberWeapon fnScar = new SmallCaliberWeapon("FN SCAR", 5.56, 3, 600);
            SmallCaliberWeapon famas = new SmallCaliberWeapon("FAMAS G2", 5.56, 3, 900);
            SmallCaliberWeapon ak47 = new SmallCaliberWeapon("AK-47", 7.62, 3, 600);

            Officer badGuy = new Officer("Blue Falcon",OfficerRank.Col);
            Officer supremeGeneral;
            Enlisted sergeant;
            Personnel player;
          
            SmallCaliberWeapon myWeapon;
            SmallCaliberWeapon badGuyWeapon = new SmallCaliberWeapon("AUG",5.56,100,680);

            int playerChoice;
            int weaponChoice;
            

            double playerHealth = 20.0;
            double badGuyHealth = 18.0;

            Menu menu = new Menu();
            menu.Display();

            playerChoice = menu.GetPlayer();

            if (playerChoice == 1)
            {
                var rankChoice = menu.GetOfficerRank();
                player = new Officer("Supreme General", rankChoice);
            }
            else
            {
                var rankChoice = menu.GetEnlistedRank();
                player = new Enlisted("Sergeant", rankChoice);
            }

            weaponChoice = menu.GetWeapon();

            switch (weaponChoice)
            {
                case 1:
                    myWeapon = m16;
                    break;
                case 2:
                    myWeapon = m4;
                    break;
                case 3:
                    myWeapon = ak74;
                    break;
                case 4:
                    myWeapon = fnScar;
                    break;
                case 5:
                    myWeapon = famas;
                    break;
                case 6:
                    myWeapon = ak47;
                    break;
                default:
                    myWeapon = m16;
                    break;
            }

            string fireWeapon;
            if (playerChoice == 1)
            {
                supremeGeneral = (Officer)player;
                Console.WriteLine($"Time to go to WAR {supremeGeneral.getRank()} {supremeGeneral.Name}");
                Console.Write($"Contact FRONT! {badGuy.getRank()} {badGuy.Name} is shooting at you : \t");
                badGuyWeapon.FireWeapon();
                Console.WriteLine("Enter fire to fire weapon or enter reload to reload weapon");
                do
                {
                    

                    fireWeapon = Console.ReadLine();

                    if (fireWeapon.ToLower() == "fire")
                    {
                        
                        Console.Write("You fired: \t");
                        myWeapon.FireWeapon();
                        badGuyHealth -= myWeapon.Damage;
                        Console.Write($"{badGuy.getRank()} {badGuy.Name} shot back\t");
                        badGuyWeapon.FireWeapon();
                        playerHealth -= badGuyWeapon.Damage;
                    }
                    else if( fireWeapon.ToLower() == "reload")
                    {
                        myWeapon.Reload();
                        
                    }
                    
                } while (playerHealth >= 0 || badGuyHealth >= 0 );
            }
            else if (playerChoice == 2)
            {
                sergeant = (Enlisted)player;
                Console.WriteLine($"Time to go to WAR {sergeant.getRank()} {sergeant.Name}");
                Console.Write($"Contact FRONT! {badGuy.getRank()} {badGuy.Name} is shooting at you : \t");
                badGuyWeapon.FireWeapon();
                Console.WriteLine("Enter fire to fire weapon or enter reload to reload weapon");
                do
                {
                   

                    fireWeapon = Console.ReadLine();

                    if (fireWeapon.ToLower() == "fire")
                    {
                        Console.Write("You fired: \t");
                        myWeapon.FireWeapon();
                        badGuyHealth -= myWeapon.Damage;
                        Console.Write($"{badGuy.getRank()} {badGuy.Name} shot back\t");
                        badGuyWeapon.FireWeapon();
                        playerHealth -= badGuyWeapon.Damage;
                    }
                    else if (fireWeapon.ToLower() == "reload")
                    {
                        myWeapon.Reload();

                    }
                    
                } while (playerHealth >= 0 || badGuyHealth >= 0);
            }

            if (playerHealth > badGuyHealth)
            {
                Console.WriteLine("Congradulations you survived");
            }
            else 
            {
                Console.WriteLine("You didn't make it =(");
            }
        }
    }
}
