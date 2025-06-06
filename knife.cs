﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class Knife : Weapon, IBreakable
    {
        string TypeMetal;
        string Color;
        double Weight;
        bool BreakStatus;
        int Hits;
        int RemainingHits;

        public Knife(string typeMetal,  string color, double weight, int hits = 10) : base("Knife", "Naman")
        {            
            BreakStatus = true;
            TypeMetal = typeMetal;
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
