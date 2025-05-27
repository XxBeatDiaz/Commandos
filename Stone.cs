using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class Stone
    {
        string Name;
        double Weight;
        string Color;
        bool Status;
        int Hits;
        int RemainingHits;

        public Stone(string name, double weight, string color, bool status = true, int hits = 5)
        {
            Name = name;
            Weight = weight;
            Color = color;
            Status = status;
            Hits = hits;
            RemainingHits = 0;
        }
    }
}
