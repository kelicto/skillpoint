using System;
using System.Collections.Generic;

using KeLi.SkillPoint.App.Properties;

namespace KeLi.SkillPoint.App.Syntax
{
    internal class HashcodeUsage : IResult
    {
        public void ShowResult()
        {
            const int num = 123456789;
            var pointA = new Point(1, 2);
            var pointB = new Point(1, 4);
            var dic = new Dictionary<object, int>();

            Console.WriteLine(num.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(Resources.HashCodeTest);
            Console.WriteLine();

            dic.Add(pointA, 1);
            dic.Add(pointB, 2);

            Console.WriteLine(dic[new Point(1, 2)]);
            Console.WriteLine();
            Console.WriteLine(dic.ContainsKey(new Point(1, 2)));
            Console.WriteLine();
            Console.WriteLine(pointA.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(pointB.GetHashCode());
            Console.WriteLine();
        }

        internal class Point
        {
            internal Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            internal int X { get; }

            internal int Y { get; }

            public override bool Equals(object obj)
            {
                var hashcode = obj as Point;

                return hashcode != null && hashcode.X == X && hashcode.Y == Y;
            }

            protected bool Equals(Point other)
            {
                return X == other.X && Y == other.Y;
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (X * 397) ^ Y;
                }
            }
        }
    }
}