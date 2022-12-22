using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30_02_iida
{
    class Person:Animal
    {
        public int _age;

        public int Age
        {
            get { return _age; }
        }

        public Person(DateTime bd, string n, int a, int li) : base(bd, n, a, li)
        {
            _age = a;
        }
    }
}
