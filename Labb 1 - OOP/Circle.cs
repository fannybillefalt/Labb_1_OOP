using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___OOP
{
    internal class Circle
    {
        // fields
        private float _pi = 3.141f;
        int Radius; 

        //constructor
        public Circle(int radie)
        {
            Radius = radie;
        }

        //methods
        public float GetArea()
        {
            float circleArea = Radius * Radius * _pi;
            return circleArea;
        }

        public float Circumference()
        {
            float circumference = 2 * _pi * Radius;
            return circumference;
        }
        public float Volume()
        {
            float volume = (4 / 3) * _pi * (Radius * Radius * Radius);
            return volume;
        }
        
    }
}
