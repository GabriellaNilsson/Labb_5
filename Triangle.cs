using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5
{
    public class Triangle
    {
        // Attributes
        private double _base;
        private double _height;

        // Properties
        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        
        // Constructor
        public Triangle(double _Base, double height)
        {
            _base = _Base;
            _height = height;
        }

        // Method for area
        public double GetAreaTriangle()
        {
            return ( Base * Height) / 2;
        }
    }
}
