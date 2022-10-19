namespace LittleBit.Context
{
    public class ConcreteIdBinder<T>
    {
        private readonly IDiContext _baseContext;

        internal ConcreteIdBinder(IDiContext baseContext)
        {
            _baseContext = baseContext;
        }

        public void To<TFrom>() where TFrom : T
        {
            Bind<TFrom>();
        }

        private void Bind<TFrom>() where TFrom : T
        {
            var instantiate = _baseContext.Instantiate<TFrom>();
            _baseContext.BindFromInstance<T>(instantiate);
        }
    }
}