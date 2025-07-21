using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal struct Rectangle
    {
        #region attributes
        private double width;
        private double height;
        #endregion

        #region properties
        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
                else
                    Console.WriteLine("Width must be greater than 0");
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
                else
                    Console.WriteLine("Height must be greater than 0");
            }
        }
        public double Area
        {
            get { return width * height; }
        }
        #endregion
        #region methods
        public void Display()
        {
            Console.WriteLine($"Rectangle Dimensions:");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Area: {Area}");
        }
        #endregion

    }
}
