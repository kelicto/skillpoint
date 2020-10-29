using System;

using KeLi.SkillPoint.App.Properties;

namespace KeLi.SkillPoint.App.Thinking
{
    internal class PriorityUsage : IResult
    {
        public void ShowResult()
        {
            object a = (int)1.1 / 1.0;
            object b = (int)(1.1 / 1.0);
            var s = a is int ? "1" : "1.0";
            var t = b is int ? "1" : "1.0";

            Console.WriteLine(Resources.PuFormula1, s);
            Console.WriteLine();
            Console.WriteLine(Resources.PuFormula2, t);
            Console.WriteLine();

            if (s == "1.0" && t == "1")
            {
                Console.WriteLine(Resources.PuHigh);
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine(Resources.PuLow);
                Console.WriteLine();
            }
        }
    }
}