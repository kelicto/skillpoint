using System;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable ReturnValueOfPureMethodIsNotUsed

namespace KeLi.SkillPoint.App.Usages
{
    internal class IEqualityComparerUsage : IResult
    {
        public void ShowResult()
        {
            Test1();
            Test2();
        }

        internal void Test1()
        {
            var data1 = GetTestData1();

            data1.GroupBy(g => g.Id, new AppleComparer()).ToDictionary(k => k.Key, v => v, new AppleComparer());

            var data2 = GetTestData2();

            data2.GroupBy(g => g.Id, new AppleComparer()).ToDictionary(k => k.Key, v => v, new AppleComparer());
        }

        internal void Test2()
        {
            var data1 = GetTestData1();

            data1.ToDictionary(k => k.Id, v => v, new AppleComparer());

            var data2 = GetTestData2();

            data2.ToDictionary(k => k.Id, v => v, new AppleComparer());
        }

        private List<Fruit> GetTestData1()
        {
            return new List<Fruit>
            {
                new Fruit(new Apple(1)),
                new Fruit(new Apple(2)),
                new Fruit(new Apple(3)),
                new Fruit(new Apple(4)),
                new Fruit(new Apple(5))
            };
        }

        private List<Fruit> GetTestData2()
        {
            return new List<Fruit>
            {
                new Fruit(new Apple(1)),
                new Fruit(new Apple(2)),
                new Fruit(new Apple(1)),
                new Fruit(new Apple(4)),
                new Fruit(new Apple(5))
            };
        }

        private class Fruit
        {
            internal Fruit(Apple id)
            {
                Id = id;
            }

            internal Apple Id { get; }
        }

        private class Apple
        {
            internal Apple(int id)
            {
                Id = id;
            }

            internal int Id { get; }
        }

        private class AppleComparer : IEqualityComparer<Apple>
        {
            public bool Equals(Apple x, Apple y)
            {
                if (x is null)
                    throw new ArgumentNullException(nameof(x));

                if (y is null)
                    throw new ArgumentNullException(nameof(y));

                return x.Id == y.Id;
            }

            public int GetHashCode(Apple obj)
            {
                return obj.Id;
            }
        }
    }
}