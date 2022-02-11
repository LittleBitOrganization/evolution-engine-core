namespace LittleBit.Modules.CoreModule
{
    public interface ISaveService : IService
    {
        public void SaveData(string key, object data);
        public T LoadData<T>(string key) where T : Data;

        public void ClearData(string key);
    }
    
    public enum SaveMode
    {
        Save,
        NotSave,
    }
}