using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class Weapon
    {
        string Name;
        string Producer;
        int NumberOfBullets;

        public Weapon(string name, string producer)
        {
            Name = name;
            Producer = producer;           
        }
    }   
}
