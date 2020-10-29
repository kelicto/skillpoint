using System;

namespace KeLi.SkillPoint.App.Arithmetic
{
    internal class LineRelationship : IResult
    {
        public void ShowResult()
        {
            var p1 = new Point(1.0, 2.0);
            var p2 = new Point(2.0, 5.0);
            var p3 = new Point(3.0, 4.0);
            var p4 = new Point(4.0, 1.0);
            var r1 = CrossRect(p1, p2, p3, p4);
            var r2 = CrossLine(p1, p2, p3, p4);

            Console.WriteLine(r1 && r2);
        }

        private static bool CrossRect(Point p1, Point p2, Point q1, Point q2)
        {
            var v1 = Math.Min(p1.X, p2.X);
            var v2 = Math.Max(p1.X, p2.X);
            var v3 = Math.Min(p1.Y, p2.Y);
            var v4 = Math.Max(p1.Y, p2.Y);
            var v5 = Math.Min(q1.X, q2.X);
            var v6 = Math.Max(q1.X, q2.X);
            var v7 = Math.Min(q1.Y, q2.Y);
            var v8 = Math.Max(q1.Y, q2.Y);

            return v1 <= v6 && v5 <= v2 && v3 <= v8 && v7 <= v4;
        }

        private static bool CrossLine(Point p1, Point p2, Point q1, Point q2)
        {
            var v1 = p1.X - q1.X;
            var v2 = p1.Y - q1.Y;
            var v3 = p2.X - q1.X;
            var v4 = p2.Y - p1.Y;
            var v5 = q2.X - q1.X;
            var v6 = q2.Y - q1.Y;
            var v7 = (v1 * v6 - v2 * v5) * (v5 * v4 - v6 * v3) > 0;
            var o1 = p1.Y - p2.Y;
            var o2 = p2.X - p1.X;
            var o3 = p2.Y - p1.Y;
            var o4 = q1.X - p1.X;
            var o5 = q1.Y - p1.Y;
            var o6 = q2.X - p1.X;
            var o7 = q2.Y - p1.Y;
            var o8 = (o4 * o1 - o5 * o2) * (o2 * o7 - o3 * o6) > 0;

            return v7 && o8;
        }

        internal class Point
        {
            internal Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            internal double X { get; set; }

            internal double Y { get; set; }
        }
    }
}