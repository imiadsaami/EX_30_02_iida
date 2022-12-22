using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30_02_iida
{
    class Machine:Thing
    {
        public Machine(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float we = 0) : base(n, w, h, d, we)
        {
        }
    }
}
