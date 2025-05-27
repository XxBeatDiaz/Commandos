using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class Knife
    {
        string Name;
        string TypeMetal;
        string Prudocer;
        string Color;
        double Weight;
        int Hits;
        int RemainingHits;
        bool Status;

        public Knife(string name, string typeMetal, string prudocer, string color, double weight, bool status = true, int hits = 10)
        {
            Name = name;
            TypeMetal = typeMetal;
            Prudocer = prudocer;
            Color = color;
            Weight = weight;
            Status = status;
            Hits = hits;
            RemainingHits = hits;
        }
    }
}
