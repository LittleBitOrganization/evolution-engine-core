using System;
using System.Collections.ObjectModel;

namespace LittleBit.Modules.CoreModule
{
    public interface IReadOnlyContainer<T1, T2>
    {
        public event Action<T1, T2> OnItemAdded;
        
        ReadOnlyDictionary<T1, T2> Items { get; }

        T2 TryGetItem(T1 key);

        void GetItemWhenAdded(T1 key, Action<T2> onAdded);

        void TryRemoveItem(T1 key);
    }
}