using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        delegate int UseOperation(int x, int y);

        delegate void GetGreeting();

        static void Main(string[] args)
        {

            GetGreeting partDay;

            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 18)
            {

                partDay = GoodDay;

            }
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour <= 24)
            {

                partDay = GoodEvening;

            }
            else if (DateTime.Now.Hour >= 24 || DateTime.Now.Hour <= 6)
            {

                partDay = GoodNight;

            }
            else
            {

                partDay = GoodMorning;

            }

            partDay.Invoke();

            UseOperation useOperation;

            string action = "";


            Console.WriteLine("Enter two integers: ");

            int x = Convert.ToInt32(Console.ReadLine());

            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose one of the proposed operations(1,2,3,4) : \n1 - add\n2 - subtract\n3 - devide \n4 - multiply");

            int operation = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            switch (operation)
            {
                case 1: useOperation = Add; result = useOperation.Invoke(x, y); break;
                case 2: useOperation = Sub; result = useOperation.Invoke(x, y); break;
                case 3: useOperation = Div; result = useOperation.Invoke(x, y); break;
                case 4: useOperation = Multiply; result = useOperation.Invoke(x, y); break;
                default: Console.WriteLine("Error!"); break;
            }

            Console.WriteLine("Result - {0}", result);

            action = Console.ReadLine();

            Console.WriteLine();

        }

        static void GoodMorning()
        {

            Console.WriteLine("Good Morning!");

        }
        static void GoodDay()
        {

            Console.WriteLine("Good Day!");

        }
        static void GoodEvening()
        {

            Console.WriteLine("Good Evening!");

        }
        static void GoodNight()
        {

            Console.WriteLine("Good Night!");

        }

        static int Add(int x, int y)
        {

            return x + y;

        }
        static int Sub(int x, int y)
        {

            return x - y;

        }
        static int Div(int x, int y)
        {

            return x / y;

        }
        static int Multiply(int x, int y)
        {

            return x * y;

        }
    }
}