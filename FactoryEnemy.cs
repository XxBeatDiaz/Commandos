using Commandos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class FactoryEnemy
    {
        public static List<Enemy> Enemies = new List<Enemy> { };
        private static int numName = 1;
        public static void AddEnemy(string type)
        {
            Enemy enemy;
            switch (type)
            {
                case "Zombi":
                    enemy = new Enemy($"Zing{numName}");
                    Enemies.Add(enemy);
                    numName++;
                    break;

                case "Goblin":
                    enemy = new Enemy($"Gabi{numName}");
                    Enemies.Add(enemy);
                    numName++;
                    break;

                case "Terrorist":
                    enemy = new Enemy($"Muahmad{numName}");
                    Enemies.Add(enemy);
                    numName++;
                    break;

                case "Monster":
                    enemy = new Enemy($"Frankainshtain{numName}");
                    Enemies.Add(enemy);
                    numName++;
                    break;

                default:
                    enemy = new Enemy($"yoram{numName}");
                    Enemies.Add(enemy);
                    numName++;
                    break;
            }
        }
        public List<Enemy> GetList()
        {
            return Enemies;
        }
    }
}
