using System;
using System.Collections.Generic;
using System.Linq;

namespace LittleBit.Modules.CoreModule.Collections
{
    public class LStack<T> : List<T>
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

        public void Push(T item)
        {
            base.Add(item);
        }

        public T Pop()
        {
            var t = base[Count - 1];
            base.RemoveAt(Count - 1);
            return t;
        }

        public T Peek()
        {
            return base[Count -1];
        }

        public T Peek(Func<T, bool> predicate)
        {
            List<T> list = new List<T>();

            list = this.Where(predicate).ToList();

            return list.Count > 0 ? list[0] : base[0];
        }

        public bool TryPeek(out T item)
        {
            if (Count == 0)
            {
                item = default;
                return false;
            }
            else
            {
                item = Peek();
                return true;
            }
        }

        public bool TryPop(out T item)
        {
            if (Count == 0)
            {
                item = default;
                return false;
            }
            else
            {
                item = Pop();
                return true;
            }
        }
    }
}