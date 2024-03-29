using System;
using System.Collections.Generic;
using System.Linq;


public class LQueue<T> : List<T>
    {
        new public void Add(T item)
        {
            throw new NotSupportedException();
        }

        new public void AddRange(IEnumerable<T> collection)
        {
            throw new NotSupportedException();
        }

        new public void Insert(int index, T item)
        {
            throw new NotSupportedException();
        }

        new public void InsertRange(int index, IEnumerable<T> collection)
        {
            throw new NotSupportedException();
        }

        new public void Reverse()
        {
            throw new NotSupportedException();
        }

        new public void Reverse(int index, int count)
        {
            throw new NotSupportedException();
        }

        new public void Sort()
        {
            throw new NotSupportedException();
        }

        new public void Sort(Comparison<T> comparison)
        {
            throw new NotSupportedException();
        }

        new public void Sort(IComparer<T> comparer)
        {
            throw new NotSupportedException();
        }

        new public void Sort(int index, int count, IComparer<T> comparer)
        {
            throw new NotSupportedException();
        }

        public void Enqueue(T item)
        {
            base.Add(item);
        }

        public T Dequeue()
        {
            var t = base[0];
            base.RemoveAt(0);
            return t;
        }

        public T Peek()
        {
            return base[0];
        }

        public T Peek(Func<T, bool> predicate)
        {
            List<T> list = new List<T>();

            list = this.Where(predicate).ToList();

            return list.Count > 0 ? list[0] : base[0];
        }
    }
