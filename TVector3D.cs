using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    internal class TVector3D
    {
        private double x;
        private double y;
        private double z;

        public TVector3D()
        {
            x = 1;
            y = 1;
            z = 1;
        }

        public TVector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public TVector3D(TVector3D vector3D)
        {
            x = vector3D.x;
            y = vector3D.y;
            z = vector3D.z;
        }

        public override string ToString()
        {
            return $"(x:{x},y:{y},z:{z})";
        }

        public void SetValues(params double[] xyz)
        {
            if (xyz == null)
                return;
            if (xyz.Length >= 1)
            {
                this.x = xyz[0];
            }
            if (xyz.Length >= 2) { 
                this.y = xyz[1];
            }
            if (xyz.Length >= 3)
            {
                this.z = xyz[2];
            }
        }

        public double GetLength()
        {
            double square(double x) => x * x;
            return Math.Sqrt(square(x) + square(y) + square(z));
        }

        public TVector3D Normalize()
        {
            var invertedLength = 1 / GetLength();
            return new TVector3D(x * invertedLength, y * invertedLength, z *  invertedLength);
        }

        public  bool IsEquals(TVector3D vector) =>
            x == vector.x && y == vector.y && z == vector.z;

        public static TVector3D operator +(TVector3D vector1, TVector3D vector2) =>
            new TVector3D(vector1.x + vector2.x, vector1.y + vector2.y, vector1.z + vector2.z);

        public static TVector3D operator -(TVector3D vector1, TVector3D vector2) =>
           new TVector3D(vector1.x - vector2.x, vector1.y - vector2.y, vector1.z - vector2.z);

        public static TVector3D operator *(TVector3D vector1, TVector3D vector2) =>
          new TVector3D(vector1.x * vector2.x, vector1.y * vector2.y, vector1.z * vector2.z);
    }
}
