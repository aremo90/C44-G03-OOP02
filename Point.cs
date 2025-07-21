using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal struct Point
    {
        #region attributes
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            int difference;
            if (X > Y)
            {
                difference = X - Y;
            }
            else
            {
                difference = Y - X;
            }
            return $"distance between: ({X} , {Y}) = {difference}";
        }
        #endregion
    }
}
