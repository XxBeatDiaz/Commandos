using Commandos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class FactoryWeapon 
    {
        private static List<Weapon> Weapons = new List<Weapon> { };
        private static int numName = 1;
        public static void AddWeapon(string type)
        {
            Weapon weapon;
            switch (type)
            {
                case "Stone":
                    weapon = new Weapon($"avi{numName}", "a", 4);
                    Weapons.Add(weapon);
                    numName++;
                    break;

                case "Knife":
                    weapon = new Weapon($"yosi{numName}", "y", 8);
                    Weapons.Add(weapon);
                    numName++;
                    break;

                case "AK7":
                    weapon = new Weapon($"avi{numName}", "a", 30);
                    Weapons.Add(weapon);
                    numName++;
                    break;

                case "M4A1":
                    weapon = new Weapon($"yosi{numName}", "y", 27);
                    Weapons.Add(weapon);
                    numName++;
                    break;

                default:
                    weapon = new Weapon($"yoram{numName}", "m", 0);
                    Weapons.Add(weapon);
                    numName++;
                    break;
            }
        }
        public List<Weapon> GetList()
        {
            return Weapons;
        }
    }
}
