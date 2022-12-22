using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_30_02_iida
{
    /// <summary>
    /// 物体
    /// </summary>
    internal class Thing
    {
        public readonly string _name;
        public float _width;
        public float _height;
        public float _depth;
        public float _weight;

        public string Name
        {
            get { return _name; }
        }

        public float Width
        {
            get { return _width; }
        }

        public float Height
        {
            get { return _height; }
        }

        public float Depth
        {
            get { return _depth; }
        }

        public float Weight
        {
            get { return _weight; }
        }

        public Thing(string n = null, float w = 0, float h = 0, float d = 0, float we = 0)
        {
            _name = n;
            _width = w;
            _height = h;
            _depth = d;
            _weight = we;
        }
    }
}
