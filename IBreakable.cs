using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    public interface IBreakable
    {
        public bool Status { get; set; }
        public int MaxHits { get; set; }
        public int RemainingHits { get; set; }
    }
}
