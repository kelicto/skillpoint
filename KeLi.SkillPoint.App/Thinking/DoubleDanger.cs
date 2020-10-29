using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeLi.SkillPoint.App.Thinking
{
    internal class DoubleDanger : IResult
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

        internal  void Test(double num)
        {
            // Old Method.
            Console.WriteLine(num);
        }
    }
}
