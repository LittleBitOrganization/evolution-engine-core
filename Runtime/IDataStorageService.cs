using System;

namespace LittleBit.Modules.CoreModule
{
    public interface IDataStorageService : IService
    {
        public T GetData<T>(string key) where T : Data, new();
        public void SetData<T>(string key, T data) where T : Data;
        public void AddUpdateDataListener(string key, Action onUpdateData);
        public void RemoveUpdateDataListener(string key, Action onUpdateData);
    }
}
