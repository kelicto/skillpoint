using System;

namespace KeLi.SkillPoint.App.Problems
{
    internal class DoubleDangerProblem : IResult
    {
        public void ShowResult()
        {
            // If Add new method, maybe use wrong overview method.
            // So, using strict value to tell type of the variable to replace.
            // For example, Test(0.0).
            Test(0);
        }

        internal void Test(int num)
        {
            // New Mehtod.
            Console.WriteLine(num);
        }

        internal void Test(double num)
        {
            // Old Method.
            Console.WriteLine(num);
        }
    }
}