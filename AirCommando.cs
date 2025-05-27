﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    class AirCommando : Commando
    {
        public AirCommando(string name, string codeName) : base(name, codeName) { }
        
        public void parachuting()
        {
            Console.WriteLine("The pilot parachuting");
        }

        public override void Attack()
        {
            Console.WriteLine("Air commando");
            base.Attack();
        }
    }
}
