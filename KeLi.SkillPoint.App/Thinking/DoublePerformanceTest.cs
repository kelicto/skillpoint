﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using KeLi.Power.Tool;

namespace KeLi.SkillPoint.App.Thinking
{
    public class DoublePerformanceTest : IResult
    {
        public void ShowResult()
        {
            Action test1 = () =>
            {
                var _ = 0d;

                for (var i = 0; i < 1E9; i++)
                    _ += 0d;
            };

            var time1 = test1.GetTotalMs();

            Action test2 = () =>
            {
                var _ = 0.0;

                for (var i = 0; i < 1E9; i++)
                    _ += 0.0;
            };

            var time2 = test2.GetTotalMs();

            if (time2 > time1)
                Console.WriteLine($"0D -> 0.0 Performance(↓%) is {Math.Round((time2 - time1) / time1 * 100.0, 3)}");

            if (time2 < time1)
                Console.WriteLine($"0D -> 0.0 Performance(↑%) is {Math.Round((time1 - time2) / time1 * 100.0, 3)}");
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
