namespace LittleBit.Modules.CoreModule
{
    public interface IDataStorageService : IService
    {
        public delegate void GenericCallback<T>(T item);
        public T GetData<T>(string key) where T : Data, new();
        public void SetData<T>(string key, T data) where T : Data;
        //public void AddUpdateDataListener(string key, Action <string> onUpdateData);
        public void AddUpdateDataListener<T>(string key, GenericCallback<T> onUpdateData);
        public void RemoveUpdateDataListener<T>(string key, GenericCallback<T> onUpdateData);
    }
}
