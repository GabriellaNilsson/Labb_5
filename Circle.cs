using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5
{
    public class Circle
    {
        // Attributes
        private float _pi = 3.141f;
        private int _radius;

        // Properties
        public float Pi
        {
            get { return _pi; }
        }
        
        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        
        // Constructor
        public Circle (int radius)
        {
            _radius = radius;
        }

        // Method for area
        public float GetArea()
        {
            return Radius * Radius * Pi;
        }

        // Method for circumference
        public float GetCircumference()
        {
            return Pi * Radius * 2;
        }

        // Method for volume
        public double GetVolume()
        {
            return (4.0 / 3.0) * _pi * Math.Pow(_radius, 3);
        }
    }
}
