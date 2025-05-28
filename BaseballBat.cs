using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class BaseballBat : Weapon, IBreakable
    {
        string Name;
        string Color;
        double Weight;
        bool BreakStatus;
        int Hits;
        int RemainingHits;

        public BaseballBat(string color, double weight, int hits = 10) : base("Baseball bat", "Yenkis")
        {
            BreakStatus = true;
            Color = color;
            Weight = weight;
            Hits = hits;
            RemainingHits = hits;
        }
        public bool Status()
        {
            return BreakStatus;
        }

        public void Hit()
        {
            RemainingHits--;
        }

        public void ShowHits()
        {
            Console.WriteLine($"Remaining: {RemainingHits} from: {Hits} hits");
        }
    }
}
