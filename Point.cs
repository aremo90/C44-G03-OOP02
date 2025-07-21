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
        //public int X;
        //public int Y;
        #endregion
        #region constructor
        // c# 9
        // empty parameterless constructor
        //public Point ()
        //{
        //    X = 0;
        //    Y = 0;
        //}

        //C# 10
        // compiler will automatically create a constructor

        //public Point(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //}

        //public Point(int x)
        //{
        //    X = x;
        //}


        #endregion
        #region methods

        //public override string ToString()
        //{
        //    return $"Point: ({X}, {Y})";
        //}

        #endregion
    }
}
