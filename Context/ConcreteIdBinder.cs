namespace LittleBit.Context
{
    public class ConcreteIdBinder<T>
    {
        private readonly IDiContext _diContext;

        public ConcreteIdBinder(IDiContext diContext)
        {
            _diContext = diContext;
        }

        public void To<TFrom>() where TFrom : T
        {
            Bind<TFrom>();
        }

        private void Bind<TFrom>() where TFrom : T
        {
            var instantiate = _diContext.Instantiate<TFrom>();
            _diContext.BindFromInstance<T>(instantiate);
        }
    }
}