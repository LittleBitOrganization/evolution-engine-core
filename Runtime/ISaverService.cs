namespace LittleBit.Modules.CoreModule
{
    public interface ISaverService
    {
        public void AddSavableObject(ISavable savableObject);
        public void RemoveSavableObject(ISavable savableObject);
    }
}