using System;

using KeLi.SkillPoint.App.Thinking;

namespace KeLi.SkillPoint.App.Syntax
{
    public class ParameterType : IResult
    {
        public void ShowResult()
        {
            var a = 1;
            var b = 2;

            SwapNumByRef(ref a, ref b);
            SwapNumByOut(out _, out _);

            const int e = 1;
            const int f = 2;
            const int g = 3;
            const bool h = true;

            ShowInputParams<object>(e, f, g, h);
        }

        private static void SwapNumByRef(ref int a, ref int b)
        {
            var temp = a;

            a = b;
            b = temp;
        }

        private static void SwapNumByOut(out int a, out int b)
        {
            a = 1;
            b = 2;

            var temp = a;

            a = b;
            b = temp;
        }

        private static void ShowInputParams<T>(params T[] ts)
        {
            if (ts == null || ts.Length <= 0)
                return;

            foreach (var t in ts)
                Console.Write(t + " ");
        }
    }
}