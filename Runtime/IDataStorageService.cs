namespace LittleBit.Modules.CoreModule
{
    public interface IDataStorageService : IService
    {
        public delegate void GenericCallback<T>(T item);

        public T GetData<T>(string key) where T : Data, new();

        public void RemoveData<T>(string key) where T : Data;
        public void SetData<T>(string key, T data, SaveMode saveMode = SaveMode.Save) where T : Data;
        public void AddUpdateDataListener<T>(object handler, string key, GenericCallback<T> onUpdateData);
        public void AddUpdateDataListenerWithUpdateData<T>(object handler, string key, GenericCallback<T> onUpdateData) where T : Data, new();
        public void RemoveUpdateDataListener<T>(object handler, string key, GenericCallback<T> onUpdateData);
        public void RemoveAllUpdateDataListenersOnObject(object handler);
        StorageData<T> CreateDataWrapper<T>(object handler, string key) where T : Data, new();

    }
    
    
}