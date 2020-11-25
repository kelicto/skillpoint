using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace KeLi.SkillPoint.App.Thinking
{
    public class DoublePerformanceTest : IResult
    {
        public void ShowResult()
        {
            BenchmarkRunner.Run<DoublePerformanceTest>();
        }

        [Benchmark]
        public void Test1()
        {
            var _ = 0d;

            for (var i = 0; i < 1E9; i++)
                _ += 0d;
        }

        [Benchmark]
        public void Test2()
        {
            var _ = 0.0;

            for (var i = 0; i < 1E9; i++)
                _ += 0.0;
        }
    }
}
