namespace LittleBit.Modules.CoreModule
{
    public interface ISaveService : IService
    {
        public void AddSavableObject(ISavable savableObject);
        public void SaveData(string key, object data);
        public T LoadData<T>(string key) where T : Data;
    }
}