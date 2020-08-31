using System;
using System.Collections.Generic;
using System.Linq;

namespace KeLi.SkillPoint.App.Thinking
{
    public class LoopUsage : IResult
    {
        private static int _index;

        public void ShowResult()
        {
            var max1 = LoopDataByFor().Max();

            Console.WriteLine(max1);

            var max2 = LoopDataByDelegate().Max();

            Console.WriteLine(max2);
        }

        private static List<int> LoopDataByFor()
        {
            var results = new List<int>();
            var rand = new Random();

            for (var i = 10; i-- > 0;)
                results.Add(rand.Next(0, 10));

            return results;
        }

        private static List<int> LoopDataByDelegate()
        {
            var results = new List<int>();
            Loop loop = GetData;

            for (var i = 0; i < 10; i++)
                results.Add(loop(ref _index));

            return results;
        }

        private static int GetData(ref int num)
        {
            return num++;
        }

        private delegate int Loop(ref int num);
    }
}