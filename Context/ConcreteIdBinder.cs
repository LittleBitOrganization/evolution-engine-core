namespace LittleBit.Context
{
    public class ConcreteIdBinder<T>
    {
        private readonly BaseContext _baseContext;

        internal ConcreteIdBinder(BaseContext baseContext)
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
            _baseContext.BindFromInstance(instantiate);
        }
    }
}