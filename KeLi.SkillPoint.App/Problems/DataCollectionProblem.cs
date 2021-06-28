using System.Collections;
using System.Collections.Generic;

// ReSharper disable CollectionNeverQueried.Local
// ReSharper disable UseObjectOrCollectionInitializer
// ReSharper disable ReturnValueOfPureMethodIsNotUsed

namespace KeLi.SkillPoint.App.Usages
{
    internal class DataCollectionProblem : IResult
    {
        public void ShowResult()
        {
            //var bitAry = new BitArray(10);

            var aryList = new ArrayList();

            // O(n)
            aryList.IndexOf(1);

            // O(1)
            aryList.Add(1);

            // O(n)
            aryList.Insert(1, 1);
            aryList.Remove(1);
            aryList.RemoveAt(1);

            var list = new List<int>();

            // O(n)
            list.IndexOf(1);

            // O(1)
            list.Add(1);

            // O(n)
            list.Insert(1, 1);
            list.Remove(1);
            list.RemoveAt(1);

            var hash2 = new HashSet<int> { 1 };

            // O(1)
            hash2.Remove(1);

            var sort3 = new SortedSet<int>();

            // O(n);
            sort3.Add(1);

            //var linkedList = new LinkedList<int>();

            var hash = new Hashtable();

            // O(1)
            hash.Add(1, 1);
            hash.Remove(1);

            var dict = new Dictionary<int, int>();

            // O(1)
            dict.Add(1, 1);
            dict.Remove(1);

            var dict2 = new SortedDictionary<int, int>();

            // O(1)
            dict2.Add(1, 1);
            dict2.Remove(1);

            var sort = new SortedList();

            // O(log n)
            sort.IndexOfKey(1);

            // O(n)
            sort.IndexOfValue(1);

            // O(n)/O(log n)
            sort.Add(1, 1);

            // O(n)
            sort.Remove(1);
            sort.RemoveAt(1);

            var sort2 = new SortedList<int, int>();

            // O(log n)
            sort2.IndexOfKey(1);

            // O(n)
            sort2.IndexOfValue(1);

            sort2.Add(1, 1);

            // O(n)
            sort2.Remove(1);
            sort2.RemoveAt(1);

            var queue = new Queue();

            // O(1)
            queue.Enqueue(1);
            queue.Dequeue();
            queue.Peek();

            var queue2 = new Queue<int>();

            // O(1)
            queue2.Enqueue(1);
            queue2.Dequeue();
            queue2.Peek();

            var stack = new Stack();

            // O(1)
            stack.Push(1);
            stack.Pop();
            stack.Peek();

            var stack2 = new Stack<int>();

            // O(1)
            stack2.Push(1);
            stack2.Pop();
            stack2.Peek();
        }
    }
}