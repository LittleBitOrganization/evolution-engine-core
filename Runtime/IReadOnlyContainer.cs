using System.Collections.ObjectModel;

namespace LittleBit.Modules.CoreModule
{
    public interface IReadOnlyContainer<T1, T2>
    {
        ReadOnlyDictionary<T1, T2> Items { get; }

        T2 TryGetItem(T1 key);

        void TryRemoveItem(T1 key);
    }
}