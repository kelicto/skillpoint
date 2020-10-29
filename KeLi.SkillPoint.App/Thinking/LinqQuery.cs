using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace KeLi.SkillPoint.App.Thinking
{
    internal class LinqQuery : IResult
    {
        public void ShowResult()
        {
            var strs = new List<string>();
            var num = 1000000;
            var test = "Test";

            for (var i = 0; i < num; i++)
                strs.Add(new Random(i).Next(1, num).ToString());

            strs.Insert(num / 3, test);

            var sw = new Stopwatch();

            sw = new Stopwatch();
            sw.Start();
            var result1 = strs.Find(f => f == test);
            sw.Stop();
            Console.WriteLine($"Find: {sw.Elapsed.TotalMilliseconds}, {result1}");
            Console.WriteLine("Does support lambda, safe, based on index");
            Console.WriteLine();

            sw = new Stopwatch();
            sw.Start();
            var result2 = strs.First(f => f == test);
            sw.Stop();
            Console.WriteLine($"First: {sw.Elapsed.TotalMilliseconds}, {result2}");
            Console.WriteLine("Does support lambda, unsafe, based on iterator");
            Console.WriteLine();

            sw = new Stopwatch();
            sw.Start();
            var result3 = strs.FirstOrDefault(f => f == test);
            sw.Stop();
            Console.WriteLine($"FirstOrDefault: {sw.Elapsed.TotalMilliseconds}, {result3}");
            Console.WriteLine("Does support lambda, safe, based on iterator");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            sw = new Stopwatch();
            sw.Start();
            var result4 = strs.Contains(test);
            sw.Stop();
            Console.WriteLine($"Contains: {sw.Elapsed.TotalMilliseconds}, {result4}");
            Console.WriteLine("Doesn't support lambda, safe, based on index");
            Console.WriteLine();

            sw = new Stopwatch();
            sw.Start();
            var result5 = strs.FindIndex(0, f => f == test) != -1;
            sw.Stop();
            Console.WriteLine($"FindIndex: {sw.Elapsed.TotalMilliseconds}, {result5}");
            Console.WriteLine("Does support lambda, safe, based on index");
            Console.WriteLine();

            sw = new Stopwatch();
            sw.Start();
            var result6 = strs.Exists(e => e == test);
            sw.Stop();
            Console.WriteLine($"Exists: {sw.Elapsed.TotalMilliseconds}, {result6}");
            Console.WriteLine("Does support lambda, safe, based on index, packed 'FindIndex'");
            Console.WriteLine();

            sw = new Stopwatch();
            sw.Start();
            var result7 = strs.Any(a => a == test);
            sw.Stop();
            Console.WriteLine($"Any: {sw.Elapsed.TotalMilliseconds}, {result7}");
            Console.WriteLine("Does support lambda, safe, based on iterator");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Gets target data(Speed): Find >> First == FirstOrDefault");
            Console.WriteLine("Exists target data(Speed): Contains > FindIndex == Exists >> Any");
            Console.ReadKey();
        }
    }
}