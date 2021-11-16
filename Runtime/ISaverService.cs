namespace LittleBit.Modules.CoreModule
{
    public interface ISaverService : IService
    {
        public void AddSavableObject(ISavable savableObject);
        public void RemoveSavableObject(ISavable savableObject);
    }
}