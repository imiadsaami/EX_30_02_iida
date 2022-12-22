using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30_02_iida
{
    class Worker:Person
    {
        public string _professionName;

        public string ProfessionName
        {
            get { return _professionName; }
        }

        public Worker(string n, string p, DateTime bd, int a) : base(bd, n, p, a)
        {
            _professionName = p;
        }
    }
}
