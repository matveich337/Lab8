using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Square
    {
        public double SquareCircle(double radius)
        {

            return Math.PI * Math.Pow(radius, 2);

        }

        public double LengthCircle(double radius)
        {

            return 2 * Math.PI * radius;

        }

        public double VolumeSphere(double radius)
        {

            return ((double)4 / 3) * Math.PI * Math.Pow(radius, 3);

        }
    }
}
