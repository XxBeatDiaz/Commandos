using Commandos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class AK47 : Weapon, IShootable
    {
        int NumberOfBullets;

        public AK47(int numberOfBullets) : base("AK47", "KALASHNIKOV")
        {
            NumberOfBullets = numberOfBullets;
        }

        public void Shoot()
        {
            NumberOfBullets--;
        }
    }
}
