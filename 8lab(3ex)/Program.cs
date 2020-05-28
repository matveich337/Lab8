using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> func;

            Console.WriteLine("Введите радиус для фигур : ");

            double radius = Convert.ToDouble(Console.ReadLine());

            Square figures = new Square();

            func = figures.SquareCircle;

            Console.WriteLine("Площадь круга - {0}", func.Invoke(radius));

            func = figures.LengthCircle;

            Console.WriteLine("Длина круга - {0}", func.Invoke(radius));

            func = figures.VolumeSphere;

            Console.WriteLine("Обьем сферы - {0}", func.Invoke(radius));
        }
    }
}
