using System;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fire weapon 5 times");
            Weapons m16 = new Weapons("M16",556,5);

            for (int i = 0; i < 7; i++)
            {
                m16.Reload();
                m16.Reload();

            }


        }
    }
}
