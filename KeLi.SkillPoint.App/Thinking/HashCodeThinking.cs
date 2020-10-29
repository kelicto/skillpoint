using System;
using System.Collections.Generic;
using System.Linq;

namespace KeLi.SkillPoint.App.Thinking
{
    internal class HashCodeThinking : IResult
    {
        public void ShowResult()
        {
            Test1();
            Test2();
        }

        internal void Test1()
        {
            try
            {
                var data = GetQualifiedTestData();
                var test1 = data.GroupBy(g => g.Id, new TestModelComparer()).ToDictionary(k => k.Key, v => v, new TestModelComparer());

                Console.WriteLine(test1.Count > 0 ? "'GroupBy+ToDictionary' call success by qualified data."
                    : "'GroupBy+ToDictionary' call failed by qualified data.");
            }
            catch
            {
                Console.WriteLine("'GroupBy+ToDictionary' call failed by qualified data.");
            }

            try
            {
                var data = GetFaultyTestData();
                var test2 = data.GroupBy(g => g.Id, new TestModelComparer()).ToDictionary(k => k.Key, v => v, new TestModelComparer());

                Console.WriteLine(test2.Count > 0 ? "'GroupBy+ToDictionary' call success by faulty data."
                    : "'GroupBy+ToDictionary' call failed by faulty data.");
            }
            catch
            {
                Console.WriteLine("'GroupBy+ToDictionary' call failed by faulty data.");
            }
        }

        internal void Test2()
        {
            try
            {
                var data = GetQualifiedTestData();
                var test1 = data.ToDictionary(k => k.Id, v => v, new TestModelComparer());

                Console.WriteLine(test1.Count > 0 ? "'ToDictionary' call success by qualified data."
                    : "'ToDictionary' call failed by qualified data.");
            }
            catch
            {
                Console.WriteLine("'ToDictionary' call failed by qualified data.");
            }

            try
            {
                var data = GetFaultyTestData();
                var test2 = data.ToDictionary(k => k.Id, v => v, new TestModelComparer());

                Console.WriteLine(test2.Count > 0 ? "'ToDictionary' call success by faulty data."
                    : "'ToDictionary' call failed by faulty data.");
            }
            catch
            {
                Console.WriteLine("'ToDictionary' call failed by faulty data.");
            }
        }

        private List<TestItem> GetQualifiedTestData()
        {
            return new List<TestItem>
            {
                new TestItem(new TestModel(1)),
                new TestItem(new TestModel(2)),
                new TestItem(new TestModel(3)),
                new TestItem(new TestModel(4)),
                new TestItem(new TestModel(5))
            };
        }

        private List<TestItem> GetFaultyTestData()
        {
            return new List<TestItem>
            {
                new TestItem(new TestModel(1)),
                new TestItem(new TestModel(2)),
                new TestItem(new TestModel(1)),
                new TestItem(new TestModel(4)),
                new TestItem(new TestModel(5))
            };
        }

        private class TestItem
        {
            internal TestItem(TestModel id)
            {
                Id = id;
            }

            internal TestModel Id { get; }
        }

        private class TestModel
        {
            internal TestModel(int id)
            {
                Id = id;
            }

            internal int Id { get; }
        }

        private class TestModelComparer : IEqualityComparer<TestModel>
        {
            public bool Equals(TestModel x, TestModel y)
            {
                if (x is null)
                    throw new ArgumentNullException(nameof(x));

                if (y is null)
                    throw new ArgumentNullException(nameof(y));

                return x.Id == y.Id;
            }

            public int GetHashCode(TestModel obj)
            {
                return obj.Id;
            }
        }
    }
}