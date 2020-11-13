using System;
using System.Collections.Generic;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace KeLi.SkillPoint.App.Thinking
{
    public class LinqQuery : IResult
    {
        private List<string> _data;

        private const string Test = "Hello";

        public void ShowResult()
        {
            _data = GetTestData(100000, Test);

            BenchmarkRunner.Run<LinqQuery>();
        }

        [Benchmark]
        public bool Test1()
        {
            return _data.First(f => f == Test) != null;
        }

        [Benchmark]
        public bool Test2()
        {
           return _data.FirstOrDefault(f => f == Test) != null;
        }

        [Benchmark]
        public bool Test3()
        {
            return _data.Contains(Test);
        }

        [Benchmark]
        public bool Test4()
        {
            return _data.Find(f => f == Test) != null;
        }

        [Benchmark]
        public bool Test5()
        {
            return _data.FindIndex(0, f => f == Test) != -1;
        }

        [Benchmark]
        public bool Test6()
        {
            return _data.Exists(e => e == Test);
        }

        [Benchmark]
        public bool Test7()
        {
           return _data.Any(a => a == Test);
        }

        private static List<string> GetTestData(int num, string test)
        {
            var results = new List<string>();

            for (var i = 0; i < num; i++)
                results.Add(new Random(i).Next(1, num).ToString());

            results.Insert(num / 3, test);

            return results;
        }
    }
}