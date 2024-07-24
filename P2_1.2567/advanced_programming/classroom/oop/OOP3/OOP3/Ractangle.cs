using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Ractangle
    {
        private double _width;
        private double _height;
        private double _area;


        public Ractangle(double width, double height)
        {
            _width = CheckNumber(width);
            _height = CheckNumber(height);
        }

        public double CheckNumber(double value)
        {
            if (value >= 0)
            {
                return value;
            }
            else
            {
                return 1;
            }
        }


        public double GetWidth()
        {
            
            return CheckNumber(_width);
        }

        public void SetWidth(double width)
        {
            _width = CheckNumber(width);
        }


        public double GetHeight()
        {
            return CheckNumber(_height);
        }

        public void SetHeight(double height)
        {
            _height = CheckNumber(height);
        }


        public double GetArea()
        {
            _area = _height * _width;
            return _area;
        }
    }
}
