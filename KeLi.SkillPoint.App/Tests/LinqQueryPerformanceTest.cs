using System;
using System.Collections.Generic;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

// ReSharper disable All

namespace KeLi.SkillPoint.App.Thinking
{
    public class LinqQueryPerformanceTest : IResult
    {
        private const string Test = "Hello";

        public void ShowResult()
        {
            BenchmarkRunner.Run<LinqQueryPerformanceTest>();
        }

        [Benchmark(Description = "First")]
        public void Test1()
        {
            var data = GetTestData(100000, Test);

            data.First(f => f == Test);
        }

        [Benchmark(Description = "FirstOrDefault")]
        public void Test2()
        {
            var data = GetTestData(100000, Test);

            data.FirstOrDefault(f => f == Test);
        }

        [Benchmark(Description = "Contains")]
        public void Test3()
        {
            var data = GetTestData(100000, Test);

            data.Contains(Test);
        }

        [Benchmark(Description = "Find")]
        public void Test4()
        {
            var data = GetTestData(100000, Test);

            data.Find(f => f == Test);
        }

        [Benchmark(Description = "FindIndex")]
        public void Test5()
        {
            var data = GetTestData(100000, Test);

            data.FindIndex(0, f => f == Test);
        }

        [Benchmark(Description = "Exists")]
        public void Test6()
        {
            var data = GetTestData(100000, Test);

            data.Exists(e => e == Test);
        }

        [Benchmark(Description = "Any")]
        public void Test7()
        {
            var data = GetTestData(100000, Test);

            data.Any(a => a == Test);
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