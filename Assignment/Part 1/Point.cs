using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt
{
    struct Point
    {
        private readonly int X;
        private readonly int Y;

        public Point(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                throw new ArgumentException("0 Or Less is Not Valid");
            }
            this.X = x; this.Y = y;
        }

        static public void DisplayDistancBetweenTwoPoints(Point p1, Point p2)
        {
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;
            Console.WriteLine(Math.Round(Math.Sqrt(dx * dx + dy * dy)));
        }
    }
}
