using System;

namespace KeLi.SkillPoint.App.Problems
{
    internal class PrecisionMissingProblem : IResult
    {
        public void ShowResult()
        {
            var point1 = new Xyz(1.123456789123456, 1.123456789123123, 1.123456789456456);
            var point2 = new Xyz(1.123456789123455, 1.123456789123125, 1.123456789456455);

            Console.WriteLine(point1.ToString());
            Console.WriteLine(point2.ToString());
        }

        internal class Xyz
        {
            private readonly XyzProxy _proxy;

            internal Xyz(double x, double y, double z)
            {
                _proxy = new XyzProxy(x, y, z);
            }

            internal double X => _proxy.Px;

            internal double Y => _proxy.Py;

            internal double Z => _proxy.Pz;

            public override string ToString()
            {
                return _proxy.ToString();
            }
        }

        internal class XyzProxy
        {
            internal XyzProxy(double x, double y, double z)
            {
                Px = x;
                Py = y;
                Pz = z;
            }

            internal double Px { get; set; }

            internal double Py { get; set; }

            internal double Pz { get; set; }

            public override string ToString()
            {
                return "(" + Px + ", " + Py + ", " + Pz + ")";
            }
        }
    }
}