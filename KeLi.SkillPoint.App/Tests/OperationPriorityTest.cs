using System;

namespace KeLi.SkillPoint.App.Tests
{
    internal class OperationPriorityTest : IResult
    {
        public void ShowResult()
        {
            object a = (int)1.1 / 1.0;
            object b = (int)(1.1 / 1.0);
            var s = a is int ? "1" : "1.0";
            var t = b is int ? "1" : "1.0";

            Console.WriteLine("(int)1.1/1.0={0}", s);
            Console.WriteLine();
            Console.WriteLine("(int)(1.1/1.0)={0}", t);
            Console.WriteLine();

            if (s == "1.0" && t == "1")
            {
                Console.WriteLine("Result: Casting priority than arithmetic precedence.");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Result: Casting priority precedence than the arithmetic operation.");
                Console.WriteLine();
            }
        }
    }
}