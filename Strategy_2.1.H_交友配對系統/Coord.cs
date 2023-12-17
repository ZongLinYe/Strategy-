using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_2._1.H_交友配對系統
{
    public class Coord
    {
        public Coord(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }
        // 計算兩個座標的距離
        public double Distance(Coord coord)
        {
            return Math.Sqrt(Math.Pow(X - coord.X, 2) + Math.Pow(Y - coord.Y, 2));
        }
    }
}
