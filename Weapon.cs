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

        public Weapon(string name, string producer)
        {
            Name = name;
            Producer = producer;           
        }
    }   
}
