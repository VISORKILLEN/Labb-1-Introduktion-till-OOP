using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Introduktion_till_OOP
{
    internal class Circle
    {
        public int Radie { get; set; }

        public float _pi = 3.141f;

        public Circle(int radie)
        {
            Radie = radie;
        }


        public double GetArea()
        {
            Console.WriteLine($"Radien är på en cirkel är {Radie} cm.");
            Console.WriteLine($"Så arean på den cirklen blir {Radie * Radie * _pi} cm^2");
            return Radie * Radie * _pi;
        }

        public double GetCircumference()
        {
            Console.WriteLine($"Omkretsen på den cirklen är {2 * Radie * _pi}");
            return 2 * Radie * _pi;
        }


        public double GetVolume()
        {
            Console.WriteLine($"Om man gör cirklen till ett klot så blir volymen {Radie * Radie * Radie * _pi * 4/3} cm^3\n");
            return Radie * Radie * Radie * _pi * 4 / 3;
        }
    }
}
