namespace LittleBit.Modules.CoreModule
{
    public interface IOriginator<T>
    {
        T Backup();

        void Restore(T data);
    }
}