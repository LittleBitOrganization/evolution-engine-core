namespace LittleBit.Context
{
    public class ConcreteIdBinder<T>
    {
        private readonly Context _context;

        internal ConcreteIdBinder(Context context)
        {
            _context = context;
        }

        public void To<TFrom>() where TFrom : T
        {
            Bind<TFrom>();
        }

        private void Bind<TFrom>() where TFrom : T
        {
            var instantiate = _context.Instantiate<TFrom>();
            _context.BindFromInstance(instantiate);
        }
    }
}