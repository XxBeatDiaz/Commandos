using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class Enemy
    {
        string Name;
        int HealthBar;
        bool Status;

        public Enemy(string name, int healthBar, bool status = true)
        {
            Name = name;
            HealthBar = healthBar;
            Status = status;
        }

        public void Scream()
        {
            Console.WriteLine("Screaming: Im a ENEMY!!!!");
        }
    }

}
