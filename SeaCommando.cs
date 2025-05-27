﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName) : base(name, codeName) { }

        public void Swiming()
        {
            Console.WriteLine("The soldier swims");
        }
    }
}
