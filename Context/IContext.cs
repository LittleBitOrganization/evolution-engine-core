namespace LittleBit.Context
{
    public interface IContext
    {
        public void BindFromInstance<T>(T service);
        public void Bind<T>();
        public void Unbind<T>();
        public T Resolve<T>();
        public IContext CreateContext();
        public T Instantiate<T>(params object[] args);
    }
}
