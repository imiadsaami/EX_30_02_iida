using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30_02_iida
{
    internal class Refrigerator:Machine
    {
        public Refrigerator(DateTime bd, string n, float w, float h, float d, float we) : base(bd, n, w, h, d, we)
        {
        }
    }
}
