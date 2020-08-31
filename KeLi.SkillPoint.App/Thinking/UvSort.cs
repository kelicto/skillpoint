using System;
using System.Collections.Generic;
using System.Linq;

namespace KeLi.SkillPoint.App.Thinking
{
    public class UvSort : IResult
    {
        public void ShowResult()
        {
            var uvs = new List<Uv> { new Uv(11, 10), new Uv(8, 6), new Uv(8, 9), new Uv(7, 11) };

            SortUvs(uvs);
            uvs.Sort(new UvCompare());
        }

        public static List<Uv> SortUvs(List<Uv> uvs)
        {
            List<Uv> results;

            if (uvs == null || uvs.Count == 0)
                results = new List<Uv>();

            else
                results = uvs.OrderBy(o => o.U).ThenBy(t => t.V).ToList();

            return results;
        }

        public class UvCompare : IComparer<Uv>
        {
            public int Compare(Uv p1, Uv p2)
            {
                int result;

                if (p1 == null || p2 == null)
                    throw new Exception();

                if (p1.U.CompareTo(p2.U) > 0)
                    result = 1;

                else if (p1.U.CompareTo(p2.U) == 0)
                {
                    if (p1.V.CompareTo(p2.V) > 0)
                        result = 1;

                    else if (p1.V.CompareTo(p2.V) == 0)
                        result = 0;

                    else
                        result = -1;
                }

                else
                    result = -1;

                return result;
            }
        }

        public class Uv
        {
            public Uv(double u, double v)
            {
                U = u;
                V = v;
            }

            public double U { get; }

            public double V { get; }
        }
    }
}