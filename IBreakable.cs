using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    public interface IBreakable
    {
        public bool Status();
        public void Hit();
    }
}
