using Commandos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class M16 : Weapon, IShootable
    {
        int NumberOfBullets;

        public M16(int numberOfBullets) : base("M16", "COLT")
        {
            NumberOfBullets = numberOfBullets;
        }

        public void Shoot()
        {
            NumberOfBullets--;
        }
    }
}
