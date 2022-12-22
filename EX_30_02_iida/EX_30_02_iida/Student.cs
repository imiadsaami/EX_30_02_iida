using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30_02_iida
{
    internal class Student:Person
    {
        public int _studentNumber;

        public int StudentNumber
        {
            get { return _studentNumber; }
        }

        public Student(DateTime bd, string n, int no, int a, int li) : base(n, a, no, bd, li)
        {
            _studentNumber = no;
        }
    }
}
