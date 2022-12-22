using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30_02_iida
{
    internal class Life:Thing
    {
        readonly private DateTime _birthDay = new DateTime();
        public int _life_span;

        public DateTime birthday
        {
            get { return _birthDay; }
        }

        public string name
        {
            get { return _name; }
        }

        public int life_span
        {
            get { return _life_span; }
        }

        public bool CheckBirthDay()
        {
            if (birthday.Date == DateTime.Today.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Life(DateTime bd, string n, int li) : base(n)
        {
            this._birthDay = bd;
            this._life_span = li;
        }
    }
}
