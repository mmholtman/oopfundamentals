using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O4_OOP_Encapsulation_Exercise_2
{
    public class Room
    {
        private double _height;
        private double _width;
        private double _length;

        public double Height
        {
            get => _height;
            private set
            {
                if (value >= 10 && value <= 12)
                {
                    _height = value;
                }
                else
                {
                    throw new Exception("The height is outside the specified range.");
                }
            }
        }

        public double Width
        {
            get => _width;
            private set
            {
                if (value < 6 || value > 30)
                {

                    throw new Exception("The width is outside the specified range.");
                }
                _width = value;
            }
        }

        public double Length
        {
            get => _length;
            private set
            {
                if (value < 6 || value > 30)
                {
                    throw new Exception("The length is outside the specified range.");
                }
                _length = value;
            }
        }

        public Room(double height, double width, double length)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        public Room()
        {

        }

        public double CalculateSurfaceArea(Room room)
        {
            var surfaceArea = room.Length * room.Height;
            return surfaceArea;
        }
        
    }
}
