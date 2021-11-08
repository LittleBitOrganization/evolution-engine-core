namespace LittleBit.Modules.CoreModule
{
    public interface IDataGetValue<out T>
    {
        public T GetNewInstanceData();
        public string GetKeyData();
    }
}