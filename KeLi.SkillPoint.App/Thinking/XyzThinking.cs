using System;

namespace KeLi.SkillPoint.App.Thinking
{
    public class XyzThinking
    {
        public static void ShowResult()
        {
            var point1 = new Xyz(1.123456789123456, 1.123456789123123, 1.123456789456456);
            var point2 = new Xyz(1.123456789123455, 1.123456789123125, 1.123456789456455);

            Console.WriteLine(point1.ToString());
            Console.WriteLine(point2.ToString());
        }

        public class Xyz
        {
            private readonly XyzProxy _proxy;

            public Xyz(double x, double y, double z)
            {
                _proxy = new XyzProxy(x, y, z);
            }

            public double X => _proxy.Px;

            public double Y => _proxy.Py;

            public double Z => _proxy.Pz;

            public override string ToString()
            {
                return _proxy.ToString();
            }
        }

        public class XyzProxy
        {
            public XyzProxy(double x, double y, double z)
            {
                Px = x;
                Py = y;
                Pz = z;
            }

            public double Px { get; set; }

            public double Py { get; set; }

            public double Pz { get; set; }

            public override string ToString()
            {
                return "(" + Px + ", " + Py + ", " + Pz + ")";
            }
        }
    }
}