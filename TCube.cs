using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    internal class TCube : TSquare
    {

        public TCube()
        {
            a = 1;
        }

        public TCube(double a):base(a)
        {
        }
        public TCube(TCube cube)
        {
            a=cube.a;
        }

        public double Volume() => a * a * a;

        public override double Square()
        {
            return base.Square() * 6;
        }
        public override double Perimeter()
        {
            return base.Perimeter() * 3;
        }

    }
}
